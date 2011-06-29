using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AForge.Neuro;
using AForge.Neuro.Learning;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace RozpoznawanieTwarzy
{
    [Serializable]
    class Perceptron
    {
        public double learningRate { get; set; }      // współczynnik uczenia
        public double momentum { get; set; }          // współczynnik momentum
        public double sigmoidAlphaValue { get; set; } // współczynnik alfa funkcji sigmoidalnej (funkcji aktywacji)
        public int neuronsInFirstLayer { get; set; }  // ilość neuronów w warstwie ukrytej
        public double errorRate { get; set; }         // margines błędu
        ActivationNetwork network;                    // sieć neuronowa

        public Perceptron() {}

        /* 
         * Naucz sieć neuronową.
         * Uczy perceptron przy pomocy algorytmu wstecznej propagacji.
         * Sieć oczy się doputy, dopuki błąd uczenia w danej epoce nie będzie mniejszy niż
         * dany margines błędu (this.errorRate). Zwraca ilość epok nauczania.
         *   double [][] input  - tablica wektorów wejściowych
         *   double [][] output - tablica oczekiwanych wektorów wyjściowych
         */
        public int Learn(double [][] input, double [][] output)
        {
            if (input.Length == output.Length)
            {
                double samples = (double)input.Length;
                this.network = new ActivationNetwork(new BipolarSigmoidFunction(this.sigmoidAlphaValue), input[0].Length, this.neuronsInFirstLayer, 1);
                BackPropagationLearning teacher = new BackPropagationLearning(network);
                teacher.LearningRate = this.learningRate;
                teacher.Momentum = this.momentum;
                int epoch = 0;
                while (teacher.RunEpoch(input, output) < this.errorRate) { epoch++; }
                return epoch;
            }
            else
            {
                throw new Exception("Size of input and output arrays differs!");
            }
        }

        /* 
         * Zwraca przybliżony wektor wyjściowy dla pewnego zadanego wektora wejściowego.
         *   double [] input - wektor wejściowy
         */ 
        public double [] Eval(double [] input)
        {
            return network.Compute(input);
        }

        public void SaveToFile(string fileName)
        {
            Stream stream = null;
            try
            {
                IFormatter formatter = new BinaryFormatter();
                stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, 1);
                formatter.Serialize(stream, this);
            }
            catch
            {}
            finally
            {
                if (null != stream)
                    stream.Close();
            }
        }

        public static Perceptron LoadFromFile(string fileName)
        {
            Stream stream = null;
            Perceptron p = null;
            try
            {
                IFormatter formatter = new BinaryFormatter();
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
                int version = (int)formatter.Deserialize(stream);
                p = (Perceptron)formatter.Deserialize(stream);
            }
            catch
            {
                // do nothing, just ignore any possible errors
            }
            finally
            {
                if (null != stream)
                    stream.Close();
            }
            return p;
        }
    }
}
