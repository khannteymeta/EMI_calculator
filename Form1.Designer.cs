namespace EMICalulator
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
            label2 = new Label();
            label3 = new Label();
            amountTextBox = new TextBox();
            rateTextBox = new TextBox();
            termNumericUpDown = new NumericUpDown();
            button1 = new Button();
            outputLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)termNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(62, 58);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 0;
            label1.Text = "Loan amount (P)  : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 123);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 1;
            label2.Text = "Annual rate (R) % :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 192);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 2;
            label3.Text = "Term (n) :";
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(247, 52);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(243, 31);
            amountTextBox.TabIndex = 3;
            amountTextBox.TextChanged += textBox1_TextChanged;
            // 
            // rateTextBox
            // 
            rateTextBox.Location = new Point(247, 117);
            rateTextBox.Name = "rateTextBox";
            rateTextBox.Size = new Size(239, 31);
            rateTextBox.TabIndex = 4;
            rateTextBox.TextChanged += rateTextBox_TextChanged;
            // 
            // termNumericUpDown
            // 
            termNumericUpDown.Location = new Point(247, 192);
            termNumericUpDown.Name = "termNumericUpDown";
            termNumericUpDown.Size = new Size(180, 31);
            termNumericUpDown.TabIndex = 6;
            termNumericUpDown.ValueChanged += termNumericUpDown_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(527, 55);
            button1.Name = "button1";
            button1.Size = new Size(187, 181);
            button1.TabIndex = 7;
            button1.Text = "Calculator EMI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // outputLabel
            // 
            outputLabel.BorderStyle = BorderStyle.Fixed3D;
            outputLabel.Location = new Point(753, 55);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(158, 181);
            outputLabel.TabIndex = 8;
            outputLabel.Click += outputLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 294);
            Controls.Add(outputLabel);
            Controls.Add(button1);
            Controls.Add(termNumericUpDown);
            Controls.Add(rateTextBox);
            Controls.Add(amountTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Equated Monthly Installment Calculator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)termNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox amountTextBox;
        private TextBox rateTextBox;
        private NumericUpDown termNumericUpDown;
        private Button button1;
        private Label outputLabel;
    }
}
