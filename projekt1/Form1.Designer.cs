namespace projekt1
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
            this.button1 = new System.Windows.Forms.Button();
            this.rateUSDTextBox = new System.Windows.Forms.TextBox();
            this.rateEURTextBox = new System.Windows.Forms.TextBox();
            this.rateCHFTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PLNTextBox = new System.Windows.Forms.Label();
            this.AmountPLNTextBox = new System.Windows.Forms.TextBox();
            this.USDRadioButton = new System.Windows.Forms.RadioButton();
            this.EURRadioButton = new System.Windows.Forms.RadioButton();
            this.CHFRadioButton = new System.Windows.Forms.RadioButton();
            this.calculatedAmountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rateUSDTextBox
            // 
            this.rateUSDTextBox.Location = new System.Drawing.Point(147, 31);
            this.rateUSDTextBox.Name = "rateUSDTextBox";
            this.rateUSDTextBox.Size = new System.Drawing.Size(100, 23);
            this.rateUSDTextBox.TabIndex = 2;
            // 
            // rateEURTextBox
            // 
            this.rateEURTextBox.Location = new System.Drawing.Point(147, 60);
            this.rateEURTextBox.Name = "rateEURTextBox";
            this.rateEURTextBox.Size = new System.Drawing.Size(100, 23);
            this.rateEURTextBox.TabIndex = 3;
            // 
            // rateCHFTextBox
            // 
            this.rateCHFTextBox.Location = new System.Drawing.Point(147, 89);
            this.rateCHFTextBox.Name = "rateCHFTextBox";
            this.rateCHFTextBox.Size = new System.Drawing.Size(100, 23);
            this.rateCHFTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kurs USD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kurs EUR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kurs CHF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kalkulator Walutowy";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PLNTextBox
            // 
            this.PLNTextBox.AutoSize = true;
            this.PLNTextBox.Location = new System.Drawing.Point(4, 221);
            this.PLNTextBox.Name = "PLNTextBox";
            this.PLNTextBox.Size = new System.Drawing.Size(64, 15);
            this.PLNTextBox.TabIndex = 9;
            this.PLNTextBox.Text = "Kwota (ZŁ)";
            // 
            // AmountPLNTextBox
            // 
            this.AmountPLNTextBox.Location = new System.Drawing.Point(4, 239);
            this.AmountPLNTextBox.Name = "AmountPLNTextBox";
            this.AmountPLNTextBox.Size = new System.Drawing.Size(100, 23);
            this.AmountPLNTextBox.TabIndex = 10;
            // 
            // USDRadioButton
            // 
            this.USDRadioButton.AutoSize = true;
            this.USDRadioButton.Location = new System.Drawing.Point(132, 239);
            this.USDRadioButton.Name = "USDRadioButton";
            this.USDRadioButton.Size = new System.Drawing.Size(47, 19);
            this.USDRadioButton.TabIndex = 11;
            this.USDRadioButton.TabStop = true;
            this.USDRadioButton.Text = "USD";
            this.USDRadioButton.UseVisualStyleBackColor = true;
            this.USDRadioButton.Click += new System.EventHandler(this.USDRadioButton_Click);
            // 
            // EURRadioButton
            // 
            this.EURRadioButton.AutoSize = true;
            this.EURRadioButton.Location = new System.Drawing.Point(132, 264);
            this.EURRadioButton.Name = "EURRadioButton";
            this.EURRadioButton.Size = new System.Drawing.Size(46, 19);
            this.EURRadioButton.TabIndex = 12;
            this.EURRadioButton.TabStop = true;
            this.EURRadioButton.Text = "EUR";
            this.EURRadioButton.UseVisualStyleBackColor = true;
            // 
            // CHFRadioButton
            // 
            this.CHFRadioButton.AutoSize = true;
            this.CHFRadioButton.Location = new System.Drawing.Point(132, 289);
            this.CHFRadioButton.Name = "CHFRadioButton";
            this.CHFRadioButton.Size = new System.Drawing.Size(48, 19);
            this.CHFRadioButton.TabIndex = 13;
            this.CHFRadioButton.TabStop = true;
            this.CHFRadioButton.Text = "CHF";
            this.CHFRadioButton.UseVisualStyleBackColor = true;
            // 
            // calculatedAmountTextBox
            // 
            this.calculatedAmountTextBox.Location = new System.Drawing.Point(228, 239);
            this.calculatedAmountTextBox.Name = "calculatedAmountTextBox";
            this.calculatedAmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.calculatedAmountTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kwota w walucie:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calculatedAmountTextBox);
            this.Controls.Add(this.CHFRadioButton);
            this.Controls.Add(this.EURRadioButton);
            this.Controls.Add(this.USDRadioButton);
            this.Controls.Add(this.AmountPLNTextBox);
            this.Controls.Add(this.PLNTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rateCHFTextBox);
            this.Controls.Add(this.rateEURTextBox);
            this.Controls.Add(this.rateUSDTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private TextBox rateUSDTextBox;
        private TextBox rateEURTextBox;
        private TextBox rateCHFTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label PLNTextBox;
        private TextBox AmountPLNTextBox;
        private RadioButton USDRadioButton;
        private RadioButton EURRadioButton;
        private RadioButton CHFRadioButton;
        private TextBox calculatedAmountTextBox;
        private Label label5;
    }
}