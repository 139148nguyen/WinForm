namespace FindMaxNumber
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
            label4 = new Label();
            numberA = new TextBox();
            numberB = new TextBox();
            numberC = new TextBox();
            btnFind = new Button();
            label5 = new Label();
            maxNumber = new TextBox();
            minNumber = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnRef = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter the numbers";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 85);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 1;
            label2.Text = "A";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(234, 85);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 2;
            label3.Text = "B";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 85);
            label4.Name = "label4";
            label4.Size = new Size(18, 20);
            label4.TabIndex = 3;
            label4.Text = "C";
            // 
            // numberA
            // 
            numberA.Location = new Point(49, 82);
            numberA.Name = "numberA";
            numberA.Size = new Size(136, 27);
            numberA.TabIndex = 4;
            // 
            // numberB
            // 
            numberB.Location = new Point(258, 82);
            numberB.Name = "numberB";
            numberB.Size = new Size(136, 27);
            numberB.TabIndex = 5;
            // 
            // numberC
            // 
            numberC.Location = new Point(477, 82);
            numberC.Name = "numberC";
            numberC.Size = new Size(136, 27);
            numberC.TabIndex = 6;
            // 
            // btnFind
            // 
            btnFind.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFind.Location = new Point(275, 196);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 7;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 281);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 8;
            label5.Text = "Result:";
            // 
            // maxNumber
            // 
            maxNumber.Location = new Point(130, 322);
            maxNumber.Name = "maxNumber";
            maxNumber.Size = new Size(136, 27);
            maxNumber.TabIndex = 9;
            maxNumber.TextChanged += maxNumber_TextChanged;
            // 
            // minNumber
            // 
            minNumber.Location = new Point(436, 322);
            minNumber.Name = "minNumber";
            minNumber.Size = new Size(136, 27);
            minNumber.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 325);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 11;
            label6.Text = "Max Number:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(332, 325);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 12;
            label7.Text = "Min Number:";
            // 
            // btnRef
            // 
            btnRef.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRef.Location = new Point(275, 389);
            btnRef.Name = "btnRef";
            btnRef.Size = new Size(94, 29);
            btnRef.TabIndex = 13;
            btnRef.Text = "Refesh";
            btnRef.UseVisualStyleBackColor = true;
            btnRef.Click += btnRef_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 450);
            Controls.Add(btnRef);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(minNumber);
            Controls.Add(maxNumber);
            Controls.Add(label5);
            Controls.Add(btnFind);
            Controls.Add(numberC);
            Controls.Add(numberB);
            Controls.Add(numberA);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Find Min Max ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox numberA;
        private TextBox numberB;
        private TextBox numberC;
        private Button btnFind;
        private Label label5;
        private TextBox maxNumber;
        private TextBox minNumber;
        private Label label6;
        private Label label7;
        private Button btnRef;
    }
}
