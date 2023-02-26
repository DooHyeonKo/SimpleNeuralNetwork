
namespace SimpleNeuralNetwork
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInputs = new System.Windows.Forms.Label();
            this.txtInputs = new System.Windows.Forms.TextBox();
            this.btnAddInputs = new System.Windows.Forms.Button();
            this.lblWeights = new System.Windows.Forms.Label();
            this.txtWeights = new System.Windows.Forms.TextBox();
            this.btnAddWeights = new System.Windows.Forms.Button();
            this.lblBiases = new System.Windows.Forms.Label();
            this.txtBiases = new System.Windows.Forms.TextBox();
            this.btnAddBiases = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInputs
            // 
            this.lblInputs.AutoSize = true;
            this.lblInputs.Location = new System.Drawing.Point(31, 25);
            this.lblInputs.Name = "lblInputs";
            this.lblInputs.Size = new System.Drawing.Size(47, 12);
            this.lblInputs.TabIndex = 0;
            this.lblInputs.Text = "Inputs: ";
            // 
            // txtInputs
            // 
            this.txtInputs.Location = new System.Drawing.Point(33, 49);
            this.txtInputs.Multiline = true;
            this.txtInputs.Name = "txtInputs";
            this.txtInputs.Size = new System.Drawing.Size(306, 77);
            this.txtInputs.TabIndex = 1;
            // 
            // btnAddInputs
            // 
            this.btnAddInputs.Location = new System.Drawing.Point(155, 135);
            this.btnAddInputs.Name = "btnAddInputs";
            this.btnAddInputs.Size = new System.Drawing.Size(184, 23);
            this.btnAddInputs.TabIndex = 2;
            this.btnAddInputs.Text = "Add Inputs";
            this.btnAddInputs.UseVisualStyleBackColor = true;
            this.btnAddInputs.Click += new System.EventHandler(this.btnAddInputs_Click);
            // 
            // lblWeights
            // 
            this.lblWeights.AutoSize = true;
            this.lblWeights.Location = new System.Drawing.Point(448, 25);
            this.lblWeights.Name = "lblWeights";
            this.lblWeights.Size = new System.Drawing.Size(53, 12);
            this.lblWeights.TabIndex = 0;
            this.lblWeights.Text = "Weights:";
            // 
            // txtWeights
            // 
            this.txtWeights.Location = new System.Drawing.Point(450, 49);
            this.txtWeights.Multiline = true;
            this.txtWeights.Name = "txtWeights";
            this.txtWeights.Size = new System.Drawing.Size(306, 77);
            this.txtWeights.TabIndex = 1;
            // 
            // btnAddWeights
            // 
            this.btnAddWeights.Location = new System.Drawing.Point(572, 135);
            this.btnAddWeights.Name = "btnAddWeights";
            this.btnAddWeights.Size = new System.Drawing.Size(184, 23);
            this.btnAddWeights.TabIndex = 2;
            this.btnAddWeights.Text = "Add Inputs";
            this.btnAddWeights.UseVisualStyleBackColor = true;
            this.btnAddWeights.Click += new System.EventHandler(this.btnAddWeights_Click);
            // 
            // lblBiases
            // 
            this.lblBiases.AutoSize = true;
            this.lblBiases.Location = new System.Drawing.Point(31, 189);
            this.lblBiases.Name = "lblBiases";
            this.lblBiases.Size = new System.Drawing.Size(48, 12);
            this.lblBiases.TabIndex = 0;
            this.lblBiases.Text = "Biases:";
            // 
            // txtBiases
            // 
            this.txtBiases.Location = new System.Drawing.Point(33, 213);
            this.txtBiases.Multiline = true;
            this.txtBiases.Name = "txtBiases";
            this.txtBiases.Size = new System.Drawing.Size(306, 77);
            this.txtBiases.TabIndex = 1;
            // 
            // btnAddBiases
            // 
            this.btnAddBiases.Location = new System.Drawing.Point(155, 299);
            this.btnAddBiases.Name = "btnAddBiases";
            this.btnAddBiases.Size = new System.Drawing.Size(184, 23);
            this.btnAddBiases.TabIndex = 2;
            this.btnAddBiases.Text = "Add Inputs";
            this.btnAddBiases.UseVisualStyleBackColor = true;
            this.btnAddBiases.Click += new System.EventHandler(this.btnAddBiases_Click);
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblScore.Location = new System.Drawing.Point(446, 208);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(310, 114);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score => 0.0\r\n";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(572, 325);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(218, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 356);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnAddWeights);
            this.Controls.Add(this.btnAddBiases);
            this.Controls.Add(this.btnAddInputs);
            this.Controls.Add(this.txtWeights);
            this.Controls.Add(this.txtBiases);
            this.Controls.Add(this.txtInputs);
            this.Controls.Add(this.lblWeights);
            this.Controls.Add(this.lblBiases);
            this.Controls.Add(this.lblInputs);
            this.Name = "MainForm";
            this.Text = "Simple Neural Network";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputs;
        private System.Windows.Forms.TextBox txtInputs;
        private System.Windows.Forms.Button btnAddInputs;
        private System.Windows.Forms.Label lblWeights;
        private System.Windows.Forms.TextBox txtWeights;
        private System.Windows.Forms.Button btnAddWeights;
        private System.Windows.Forms.Label lblBiases;
        private System.Windows.Forms.TextBox txtBiases;
        private System.Windows.Forms.Button btnAddBiases;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnCalculate;
    }
}

