using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AForge.Neuro;
using AForge.Neuro.Learning;

namespace RozpoznawanieTwarzy
{
    class Perceptron
    {
        double learningRate { get; set; }      // współczynnik uczenia
        double momentum { get; set; }          // współczynnik momentum
        double sigmoidAlphaValue { get; set; } // współczynnik alfa funkcji sigmoidalnej (funkcji aktywacji)
        int neuronsInFirstLayer { get; set; }  // ilość neuronów w warstwie ukrytej
        double errorRate { get; set; }         // margines błędu
        ActivationNetwork network;             // sieć neuronowa

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
                int samples = input.Length;
                this.network = new ActivationNetwork(new BipolarSigmoidFunction(this.sigmoidAlphaValue), input.Length, this.neuronsInFirstLayer, 1);
                BackPropagationLearning teacher = new BackPropagationLearning(network);
                teacher.LearningRate = this.learningRate;
                teacher.Momentum = this.momentum;
                int epoch = 0;
                while (teacher.RunEpoch(input, output) / samples < this.errorRate) { epoch++; }
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
    }
}
