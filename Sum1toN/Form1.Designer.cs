namespace Sum1toN
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
            naturalNumber = new TextBox();
            btnCalc = new Button();
            groupBox1 = new GroupBox();
            sNumber = new TextBox();
            sString = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnReset = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 31);
            label1.Name = "label1";
            label1.Size = new Size(176, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter the natural number:";
            // 
            // naturalNumber
            // 
            naturalNumber.Location = new Point(219, 31);
            naturalNumber.Name = "naturalNumber";
            naturalNumber.Size = new Size(143, 27);
            naturalNumber.TabIndex = 1;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(399, 27);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(94, 29);
            btnCalc.TabIndex = 2;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(sNumber);
            groupBox1.Controls.Add(sString);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(37, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 125);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Result";
            // 
            // sNumber
            // 
            sNumber.Location = new Point(65, 79);
            sNumber.Name = "sNumber";
            sNumber.Size = new Size(365, 27);
            sNumber.TabIndex = 5;
            // 
            // sString
            // 
            sString.Location = new Point(65, 32);
            sString.Name = "sString";
            sString.Size = new Size(365, 27);
            sString.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 79);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 1;
            label3.Text = "S = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 35);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 0;
            label2.Text = "S = ";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(219, 259);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 333);
            Controls.Add(btnReset);
            Controls.Add(groupBox1);
            Controls.Add(btnCalc);
            Controls.Add(naturalNumber);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Sum 1 to N";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox naturalNumber;
        private Button btnCalc;
        private GroupBox groupBox1;
        private TextBox sNumber;
        private TextBox sString;
        private Label label3;
        private Label label2;
        private Button btnReset;
    }
}
