namespace BMIcalculator
{
    partial class BMIcalculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCentimeter = new System.Windows.Forms.RadioButton();
            this.radioButtonFeet = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonPound = new System.Windows.Forms.RadioButton();
            this.radioButtonKg = new System.Windows.Forms.RadioButton();
            this.TextBoxFeet = new System.Windows.Forms.TextBox();
            this.TextBoxInch = new System.Windows.Forms.TextBox();
            this.TextBoxCentimeter = new System.Windows.Forms.TextBox();
            this.TextBoxWeight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCentimeter);
            this.groupBox1.Controls.Add(this.radioButtonFeet);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Height";
            // 
            // radioButtonCentimeter
            // 
            this.radioButtonCentimeter.AutoSize = true;
            this.radioButtonCentimeter.Location = new System.Drawing.Point(101, 22);
            this.radioButtonCentimeter.Name = "radioButtonCentimeter";
            this.radioButtonCentimeter.Size = new System.Drawing.Size(94, 21);
            this.radioButtonCentimeter.TabIndex = 0;
            this.radioButtonCentimeter.TabStop = true;
            this.radioButtonCentimeter.Text = "Centimeter";
            this.radioButtonCentimeter.UseVisualStyleBackColor = true;
            // 
            // radioButtonFeet
            // 
            this.radioButtonFeet.AutoSize = true;
            this.radioButtonFeet.Location = new System.Drawing.Point(7, 22);
            this.radioButtonFeet.Name = "radioButtonFeet";
            this.radioButtonFeet.Size = new System.Drawing.Size(52, 21);
            this.radioButtonFeet.TabIndex = 0;
            this.radioButtonFeet.TabStop = true;
            this.radioButtonFeet.Text = "Feet";
            this.radioButtonFeet.UseVisualStyleBackColor = true;
            this.radioButtonFeet.CheckedChanged += new System.EventHandler(this.radioButtonFeet_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonPound);
            this.groupBox2.Controls.Add(this.radioButtonKg);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 45);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weight";
            // 
            // radioButtonPound
            // 
            this.radioButtonPound.AutoSize = true;
            this.radioButtonPound.Location = new System.Drawing.Point(101, 22);
            this.radioButtonPound.Name = "radioButtonPound";
            this.radioButtonPound.Size = new System.Drawing.Size(66, 21);
            this.radioButtonPound.TabIndex = 0;
            this.radioButtonPound.TabStop = true;
            this.radioButtonPound.Text = "Pound";
            this.radioButtonPound.UseVisualStyleBackColor = true;
            // 
            // radioButtonKg
            // 
            this.radioButtonKg.AutoSize = true;
            this.radioButtonKg.Location = new System.Drawing.Point(7, 22);
            this.radioButtonKg.Name = "radioButtonKg";
            this.radioButtonKg.Size = new System.Drawing.Size(42, 21);
            this.radioButtonKg.TabIndex = 0;
            this.radioButtonKg.TabStop = true;
            this.radioButtonKg.Text = "Kg";
            this.radioButtonKg.UseVisualStyleBackColor = true;
            this.radioButtonKg.CheckedChanged += new System.EventHandler(this.radioButtonKg_CheckedChanged);
            // 
            // TextBoxFeet
            // 
            this.TextBoxFeet.Location = new System.Drawing.Point(12, 104);
            this.TextBoxFeet.Name = "TextBoxFeet";
            this.TextBoxFeet.PlaceholderText = "Feet";
            this.TextBoxFeet.Size = new System.Drawing.Size(100, 23);
            this.TextBoxFeet.TabIndex = 1;
            this.TextBoxFeet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFeet_KeyPress);
            // 
            // TextBoxInch
            // 
            this.TextBoxInch.Location = new System.Drawing.Point(118, 104);
            this.TextBoxInch.Name = "TextBoxInch";
            this.TextBoxInch.PlaceholderText = "Inch";
            this.TextBoxInch.Size = new System.Drawing.Size(100, 23);
            this.TextBoxInch.TabIndex = 1;
            this.TextBoxInch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInch_KeyPress);
            // 
            // TextBoxCentimeter
            // 
            this.TextBoxCentimeter.Location = new System.Drawing.Point(12, 104);
            this.TextBoxCentimeter.Name = "TextBoxCentimeter";
            this.TextBoxCentimeter.PlaceholderText = "Centimeter";
            this.TextBoxCentimeter.Size = new System.Drawing.Size(206, 23);
            this.TextBoxCentimeter.TabIndex = 2;
            this.TextBoxCentimeter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCentimeter_KeyPress);
            // 
            // TextBoxWeight
            // 
            this.TextBoxWeight.Location = new System.Drawing.Point(12, 184);
            this.TextBoxWeight.Name = "TextBoxWeight";
            this.TextBoxWeight.Size = new System.Drawing.Size(206, 23);
            this.TextBoxWeight.TabIndex = 3;
            this.TextBoxWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxWeight_KeyPress);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 213);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(87, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Underweight = <18.5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Normal weight = 18.5–24.9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Overweight = 25–29.9";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Obesity = BMI of 30 or greater";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(239, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 123);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(143, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "BMI Calculator";
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelResult.Location = new System.Drawing.Point(257, 203);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(0, 21);
            this.LabelResult.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(171, 213);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(47, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(12, 256);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(75, 23);
            this.btnHistory.TabIndex = 10;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(418, 256);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BMIcalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 281);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.TextBoxWeight);
            this.Controls.Add(this.TextBoxCentimeter);
            this.Controls.Add(this.TextBoxInch);
            this.Controls.Add(this.TextBoxFeet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BMIcalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMIcalculator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButtonCentimeter;
        private RadioButton radioButtonFeet;
        private GroupBox groupBox2;
        private RadioButton radioButtonPound;
        private RadioButton radioButtonKg;
        private TextBox TextBoxFeet;
        private TextBox TextBoxInch;
        private TextBox TextBoxCentimeter;
        private TextBox TextBoxWeight;
        private Button btnCalculate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox3;
        private Label label5;
        private Label LabelResult;
        private Button btnClear;
        private Button btnHistory;
        private Button btnExit;
    }
}