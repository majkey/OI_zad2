using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace RozpoznawanieTwarzy
{
    class ImageSupport
    {
        Bitmap image { get; set; }                     // obraz
        public Bitmap resultImage { get; set; }        // obraz wynikowy (z oznaczeniami)
        public int sampleWidth { get; set; }           // szerokość okna przesuwnego
        public int sampleHeight { get; set; }          // wysokość okna przesuwnego
        public int offsetStep { get; set; }            // krok jaki wykonuje ramka w poziomie lub pionie
        public int learningSampleWidth { get; set; }   // szerokość próbki uczącej
        public int learningSampleHeight { get; set; }  // wysokość próbki uczącej

        public ImageSupport(Bitmap image)
        {
            this.image = ImageSupport.MakeGrayscale(image);
            this.resultImage = this.image;
            this.sampleHeight = 32;
            this.sampleWidth = 32;
            this.learningSampleHeight = 32;
            this.learningSampleWidth = 32;
            this.offsetStep = 8;
        }

        /*
         * Pobiera próbkę uczącą sieć.
         * Próbka jest konkatenacją wierszy. Wartości próbki to wartości poszczególnych pikselów.
         *   int xOffset - przesunięcie ramki w poziomie
         *   int yOffset - przesunięcie ramki w pionie
         */
        public double [] GetLearningSample(int xOffset, int yOffset)
        {
            double [] result;
            Bitmap tmp;
            if ((tmp = GetSample(xOffset, yOffset)) != null)
            {
                result = new double[tmp.Width * tmp.Height];
                for (int i = 0; i < tmp.Width; i++)
                    for (int j = 0; j < tmp.Height; j++)
                        result[i * tmp.Width + j] = (double)tmp.GetPixel(i, j).R;
            }
            else
            {
                result = null;
            }
            return result;
        }

        /*
         * Pobiera próbkę uczącą sieć.
         * Próbka jest konkatenacją wierszy. Wartości próbki to wartości poszczególnych pikselów.
         *   Rectangle field - obszar z ktrego została pobrana próbka.
         */
        public double[] GetLearningSample(Rectangle field)
        {
            double[] result;
            Bitmap tmp;
            if (field.X + field.Width <= this.image.Width && field.Y + field.Height <= this.image.Height)
            {
                tmp = ImageSupport.ResizeBitmap(ImageSupport.CropBitmap(this.image, field.X, field.Y, field.Width, field.Height), this.learningSampleWidth, this.learningSampleHeight);
                result = new double[tmp.Width * tmp.Height];
                for (int i = 0; i < tmp.Width; i++)
                    for (int j = 0; j < tmp.Height; j++)
                        result[i * tmp.Width + j] = (double)tmp.GetPixel(i, j).R;
            }
            else
                result = null;
            return result;
        }

        /*
         * Skalowanie obrazu.
         *   Bitmap bitmap - skalowany obraz
         *   int nWidth - nowa szerokość obrazu
         *   int nHeight - nowa szerokość obrazu
         */
        private static Bitmap ResizeBitmap(Bitmap bitmap, int nWidth, int nHeight)
        {
            Bitmap result = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((Image)result))
                g.DrawImage(bitmap, 0, 0, nWidth, nHeight);
            return result;
        }

        /*
         * Kadrowanie obrazu.
         * Wycina fragment obrazu o wymiarach cropWidth x cropHeight o przesunięciu
         * równym [cropX, cropY].
         *   Bitmap bitmap - kadrowana bitmapa
         *   int cropX - przesunięcie X kadru
         *   int cropY - przesunięcie Y kadru
         *   int cropWidth - wysokość kadru
         *   int cropHeight - szerokość kadru
         */
        private static Bitmap CropBitmap(Bitmap bitmap, int cropX, int cropY, int cropWidth, int cropHeight)
        {
            Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
            Bitmap cropped = bitmap.Clone(rect, bitmap.PixelFormat);
            return cropped;
        }

        /*
         * Pobiera ramkę wielkości this.sampleWidth x this.sampleHeight zaczynającą
         * się w punkcie [xOffset * this.offsetStep, yOffset * this.offsetStep].
         *   int xOffset - przesunięcie ramki w poziomie
         *   int yOffset - przesunięcie ramki w pionie
         */
        public Bitmap GetSample(int xOffset, int yOffset)
        {
            Bitmap result;
            if (xOffset * this.offsetStep + this.sampleWidth <= this.image.Width &&
                yOffset * this.offsetStep + this.sampleHeight <= this.image.Height)
            {
                result = ImageSupport.ResizeBitmap(ImageSupport.CropBitmap(this.image, xOffset * this.offsetStep, yOffset * this.offsetStep, this.sampleWidth, this.sampleHeight), this.learningSampleWidth, this.learningSampleHeight);
            }
            else
            {
                result = null;
            }
            return result;
        }

        /*
         * Rysuje obramowanie ramki przesuwnej.
         *   int xOffset - przesunięcie ramki w poziomie
         *   int yOffset - przesunięcie ramki w pionie
         */
        public Bitmap DrawFrame(int xOffset, int yOffset)
        {
            Bitmap result = ImageSupport.ResizeBitmap(this.resultImage, this.resultImage.Width, this.resultImage.Height);
            if (xOffset * this.offsetStep + this.sampleWidth <= this.image.Width &&
                yOffset * this.offsetStep + this.sampleHeight <= this.image.Height)
            {
                for (int i = 0; i < this.sampleWidth; i++)
                {
                    Color color;
                    if (i % 2 == 0)
                        color = Color.Black;
                    else
                        color = Color.White;
                    result.SetPixel(xOffset * this.offsetStep + i, yOffset * this.offsetStep, color);
                    result.SetPixel(xOffset * this.offsetStep + i, yOffset * this.offsetStep + this.sampleHeight, color);
                }
                for (int j = 0; j < this.sampleHeight; j++)
                {
                    Color color;
                    if(j % 2 == 0)
                        color = Color.Black;
                    else
                        color = Color.White;
                    result.SetPixel(xOffset * this.offsetStep, yOffset * this.offsetStep + j, color);
                    result.SetPixel(xOffset * this.offsetStep + this.sampleWidth, yOffset * this.offsetStep + j, color);
                }
            }
            return result;
        }

        /*
        * Dorysowuje obramowanie ramki przesuwnej do this.resultImage.
        *   int xOffset - przesunięcie ramki w poziomie
        *   int yOffset - przesunięcie ramki w pionie
        */
        public void DrawFrameOnResultImage(int xOffset, int yOffset)
        {
            this.resultImage = DrawFrame(xOffset, yOffset);
        }

        /*
         * Normalizacja tablicy danych.
         * Zwraca wektor znormalizowany, czyli taki, którego długość wynosi 1.
         *   double [] input - wektor do normalizacji
         */
        public static double [] Normalize(double [] input)
        {
            double[] result = new double[input.Length];
            double sum = 0.0;
            foreach (double e in input)
                sum += Math.Pow(e, 2.0);
            for (int i = 0; i < input.Length; i++)
                result[i] = input[i] / Math.Sqrt(sum);
            return result;
        }

        /*
         * Konwersja bitmapy na bitmapę w skali szarości.
         *   Bitmap original - konwertowana bitmapa
         */
        private static Bitmap MakeGrayscale(Bitmap original)
        {
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);
            Graphics g = Graphics.FromImage(newBitmap);
            ColorMatrix colorMatrix = new ColorMatrix(new float[][] {
                new float[] {.3f, .3f, .3f, 0, 0},
                new float[] {.59f, .59f, .59f, 0, 0},
                new float[] {.11f, .11f, .11f, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
            });
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(colorMatrix);
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);
            g.Dispose();
            return newBitmap;
        }
    }
}