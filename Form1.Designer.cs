﻿namespace IncomeTaxCalculation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtIncome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lblOutput = new Label();
            btnCalculateTax = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 22);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 0;
            label1.Text = "Income Tax Calculator";
            // 
            // txtIncome
            // 
            txtIncome.Location = new Point(171, 80);
            txtIncome.Name = "txtIncome";
            txtIncome.Size = new Size(100, 23);
            txtIncome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 123);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Tax To Pay";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 83);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 3;
            label3.Text = "Enter your Income";
            // 
            // lblOutput
            // 
            lblOutput.BackColor = Color.White;
            lblOutput.Location = new Point(185, 123);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(76, 15);
            lblOutput.TabIndex = 4;
            // 
            // btnCalculateTax
            // 
            btnCalculateTax.Location = new Point(171, 51);
            btnCalculateTax.Name = "btnCalculateTax";
            btnCalculateTax.Size = new Size(100, 23);
            btnCalculateTax.TabIndex = 5;
            btnCalculateTax.Text = "Calculate Tax";
            btnCalculateTax.UseVisualStyleBackColor = true;
            btnCalculateTax.Click += btnCalculateTax_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 259);
            Controls.Add(btnCalculateTax);
            Controls.Add(lblOutput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtIncome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Income Tax calculator 2024";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIncome;
        private Label label2;
        private Label label3;
        private Label lblOutput;
        private Button btnCalculateTax;
    }
}
