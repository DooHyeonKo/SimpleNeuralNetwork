using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleNeuralNetwork
{
    public partial class MainForm : Form
    {
        double[] Inputs;
        double[] Weights;
        double[] Biases;

        public MainForm()
        {
            InitializeComponent();
        }

        // Simple Neural Network Logic

        // Vector Dot 

        double[] VectorDot(double[] vector1, double[] vector2)
        {
            double[] newVector = new double[vector1.Length]; // Vector result

            for (int i = 0; i < vector1.Length; i++)
            {
                newVector[i] = vector1[i] * vector2[i];
            }

            return newVector;
        }

        double[] VectorSum(double[] vector1, double[] vector2)
        {
            double[] newVector = new double[vector1.Length]; // Vector result

            for (int i = 0; i < vector1.Length; i++)
            {
                newVector[i] = vector1[i] + vector2[i];
            }

            return newVector;
        }

        double[] VectorSigmoid(double[] vector)
        {
            double[] newVector = new double[vector.Length]; // Vector result

            for (int i = 0; i < vector.Length; i++)
            {
                newVector[i] = 1 / (1 + Math.Exp(-vector[i])); // Sigmoid function
            }

            return newVector;
        }

        // Softmax

        double[] Softmax(double[] vector)
        {
            var vectorExp = vector.Select(Math.Exp);
            var vectorSum = vectorExp.Sum();
            var softmaxVector = vectorExp.Select(i => i / vectorSum);

            return softmaxVector.ToArray();
        }

        // UI Logic

        double[] ConvertVector(string text, char splitWord)
        {
            var split = text.Split(splitWord);
            var vectorResult = split.Select(i => double.Parse(i));
            return vectorResult.ToArray();
        }

        // Input Logic

        private void btnAddInputs_Click(object sender, EventArgs e)
        {
            Inputs = ConvertVector(txtInputs.Text, ',');
        }

        private void btnAddWeights_Click(object sender, EventArgs e)
        {
            Weights = ConvertVector(txtWeights.Text, ',');
        }

        private void btnAddBiases_Click(object sender, EventArgs e)
        {
            Biases = ConvertVector(txtBiases.Text, ',');
        }

        // Calculate Logic

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1 Layer

            var dotVector1 = VectorSum(VectorDot(Inputs, Weights), Biases);
            var sigmoidVector1 = VectorSigmoid(dotVector1);

            // 2 Layer

            var dotVector2= VectorSum(VectorDot(Inputs, Weights), Biases);
            var sigmoidVector2  = VectorSigmoid(dotVector2);

            // 3 Layer

            var dotVector3 = VectorSum(VectorDot(Inputs, Weights), Biases);
            var sigmoidVector3 = VectorSigmoid(dotVector3);

            // Classify

            var softmaxVector = Softmax(sigmoidVector3);

            // Get classifiy score

            var softmaxScore = softmaxVector.Sum();

            lblScore.Text = $"Score => {softmaxScore.ToString()}";
        }
    }
}
