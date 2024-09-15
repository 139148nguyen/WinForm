namespace SimpleCalculator
{
    partial class Calc
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
            groupBox1 = new GroupBox();
            button12 = new Button();
            dotBtn = new Button();
            num0 = new Button();
            num9 = new Button();
            num8 = new Button();
            num7 = new Button();
            num6 = new Button();
            num5 = new Button();
            num4 = new Button();
            num3 = new Button();
            num2 = new Button();
            num1 = new Button();
            screenCalc = new TextBox();
            groupBox2 = new GroupBox();
            clean = new Button();
            calcBtn = new Button();
            divBtn = new Button();
            mulBtn = new Button();
            subBtn = new Button();
            addBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button12);
            groupBox1.Controls.Add(dotBtn);
            groupBox1.Controls.Add(num0);
            groupBox1.Controls.Add(num9);
            groupBox1.Controls.Add(num8);
            groupBox1.Controls.Add(num7);
            groupBox1.Controls.Add(num6);
            groupBox1.Controls.Add(num5);
            groupBox1.Controls.Add(num4);
            groupBox1.Controls.Add(num3);
            groupBox1.Controls.Add(num2);
            groupBox1.Controls.Add(num1);
            groupBox1.Location = new Point(12, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(298, 259);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Numerical";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button12
            // 
            button12.Location = new Point(192, 193);
            button12.Name = "button12";
            button12.Size = new Size(87, 36);
            button12.TabIndex = 11;
            button12.UseVisualStyleBackColor = true;
            // 
            // dotBtn
            // 
            dotBtn.Location = new Point(99, 193);
            dotBtn.Name = "dotBtn";
            dotBtn.Size = new Size(87, 36);
            dotBtn.TabIndex = 10;
            dotBtn.Text = ".";
            dotBtn.UseVisualStyleBackColor = true;
            dotBtn.Click += dotBtn_Click;
            // 
            // num0
            // 
            num0.Location = new Point(6, 193);
            num0.Name = "num0";
            num0.Size = new Size(87, 36);
            num0.TabIndex = 9;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = true;
            num0.Click += num0_Click;
            // 
            // num9
            // 
            num9.Location = new Point(192, 141);
            num9.Name = "num9";
            num9.Size = new Size(87, 36);
            num9.TabIndex = 8;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Click += num9_Click;
            // 
            // num8
            // 
            num8.Location = new Point(99, 141);
            num8.Name = "num8";
            num8.Size = new Size(87, 36);
            num8.TabIndex = 7;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            num8.Click += num8_Click;
            // 
            // num7
            // 
            num7.Location = new Point(6, 141);
            num7.Name = "num7";
            num7.Size = new Size(87, 36);
            num7.TabIndex = 6;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            num7.Click += num7_Click;
            // 
            // num6
            // 
            num6.Location = new Point(192, 88);
            num6.Name = "num6";
            num6.Size = new Size(87, 36);
            num6.TabIndex = 5;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Click += num6_Click;
            // 
            // num5
            // 
            num5.Location = new Point(99, 88);
            num5.Name = "num5";
            num5.Size = new Size(87, 36);
            num5.TabIndex = 4;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Click += num5_Click;
            // 
            // num4
            // 
            num4.Location = new Point(6, 88);
            num4.Name = "num4";
            num4.Size = new Size(87, 36);
            num4.TabIndex = 3;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Click += num4_Click;
            // 
            // num3
            // 
            num3.Location = new Point(192, 36);
            num3.Name = "num3";
            num3.Size = new Size(87, 36);
            num3.TabIndex = 2;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Click += num3_Click;
            // 
            // num2
            // 
            num2.Location = new Point(99, 36);
            num2.Name = "num2";
            num2.Size = new Size(87, 36);
            num2.TabIndex = 1;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Click += num2_Click;
            // 
            // num1
            // 
            num1.Location = new Point(6, 36);
            num1.Name = "num1";
            num1.Size = new Size(87, 36);
            num1.TabIndex = 0;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += num1_Click;
            // 
            // screenCalc
            // 
            screenCalc.Location = new Point(12, 12);
            screenCalc.Name = "screenCalc";
            screenCalc.Size = new Size(418, 27);
            screenCalc.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(clean);
            groupBox2.Controls.Add(calcBtn);
            groupBox2.Controls.Add(divBtn);
            groupBox2.Controls.Add(mulBtn);
            groupBox2.Controls.Add(subBtn);
            groupBox2.Controls.Add(addBtn);
            groupBox2.Location = new Point(313, 51);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(117, 291);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operator";
            // 
            // clean
            // 
            clean.Location = new Point(18, 236);
            clean.Name = "clean";
            clean.Size = new Size(87, 36);
            clean.TabIndex = 8;
            clean.Text = "C";
            clean.UseVisualStyleBackColor = true;
            clean.Click += clean_Click;
            // 
            // calcBtn
            // 
            calcBtn.Location = new Point(18, 194);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(87, 36);
            calcBtn.TabIndex = 7;
            calcBtn.Text = "=";
            calcBtn.UseVisualStyleBackColor = true;
            calcBtn.Click += calcBtn_Click;
            // 
            // divBtn
            // 
            divBtn.Location = new Point(18, 152);
            divBtn.Name = "divBtn";
            divBtn.Size = new Size(87, 36);
            divBtn.TabIndex = 6;
            divBtn.Text = "/";
            divBtn.UseVisualStyleBackColor = true;
            divBtn.Click += divBtn_Click;
            // 
            // mulBtn
            // 
            mulBtn.Location = new Point(18, 110);
            mulBtn.Name = "mulBtn";
            mulBtn.Size = new Size(87, 36);
            mulBtn.TabIndex = 5;
            mulBtn.Text = "*";
            mulBtn.UseVisualStyleBackColor = true;
            mulBtn.Click += mulBtn_Click;
            // 
            // subBtn
            // 
            subBtn.Location = new Point(18, 68);
            subBtn.Name = "subBtn";
            subBtn.Size = new Size(87, 36);
            subBtn.TabIndex = 4;
            subBtn.Text = "-";
            subBtn.UseVisualStyleBackColor = true;
            subBtn.Click += subBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(18, 26);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(87, 36);
            addBtn.TabIndex = 3;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // Calc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 354);
            Controls.Add(groupBox2);
            Controls.Add(screenCalc);
            Controls.Add(groupBox1);
            Name = "Calc";
            Text = "Simple Calculating";
            Load += Calc_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button12;
        private Button dotBtn;
        private Button num0;
        private Button num9;
        private Button num8;
        private Button num7;
        private Button num6;
        private Button num5;
        private Button num4;
        private Button num3;
        private Button num2;
        private Button num1;
        private TextBox screenCalc;
        private GroupBox groupBox2;
        private Button calcBtn;
        private Button divBtn;
        private Button mulBtn;
        private Button subBtn;
        private Button addBtn;
        private Button clean;
    }
}