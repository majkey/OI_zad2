using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace RozpoznawanieTwarzy
{
    class DataFile
    {
        public List<Rectangle> data;

        public DataFile(string filePath)
        {
            StreamReader streamReader = new StreamReader(filePath);
            string text;
            this.data = new List<Rectangle>();
            while ((text = streamReader.ReadLine()) != null)
            {
                string [] line = text.Split(' ');
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);
                int w = int.Parse(line[2]) - x;
                int h = int.Parse(line[3]) - y;
                this.data.Add(new Rectangle(x, y, w, h));
            }
            streamReader.Close();
        }
    }
}
