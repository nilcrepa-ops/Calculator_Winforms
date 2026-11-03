namespace Calculator_Winforms
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
            button1 = new Button();
            button6 = new Button();
            button7 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button06 = new Button();
            button8 = new Button();
            button09 = new Button();
            button0 = new Button();
            btnMult = new Button();
            btnSubstract = new Button();
            btnAdd = new Button();
            btnEquals = new Button();
            btnComa = new Button();
            btnDiv = new Button();
            btnClear = new Button();
            txtBxResult = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(51, 378);
            button1.Name = "button1";
            button1.Size = new Size(90, 50);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(51, 322);
            button6.Name = "button6";
            button6.Size = new Size(90, 50);
            button6.TabIndex = 3;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(51, 266);
            button7.Name = "button7";
            button7.Size = new Size(90, 50);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(147, 378);
            button2.Name = "button2";
            button2.Size = new Size(90, 50);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(247, 378);
            button3.Name = "button3";
            button3.Size = new Size(90, 50);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(147, 322);
            button5.Name = "button5";
            button5.Size = new Size(90, 50);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button06
            // 
            button06.Location = new Point(247, 322);
            button06.Name = "button06";
            button06.Size = new Size(90, 50);
            button06.TabIndex = 5;
            button06.Text = "6";
            button06.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(147, 266);
            button8.Name = "button8";
            button8.Size = new Size(90, 50);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button09
            // 
            button09.Location = new Point(247, 266);
            button09.Name = "button09";
            button09.Size = new Size(90, 50);
            button09.TabIndex = 8;
            button09.Text = "9";
            button09.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            button0.Location = new Point(147, 434);
            button0.Name = "button0";
            button0.Size = new Size(90, 50);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(343, 266);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(90, 50);
            btnMult.TabIndex = 10;
            btnMult.Text = "x";
            btnMult.UseVisualStyleBackColor = true;
            // 
            // btnSubstract
            // 
            btnSubstract.Location = new Point(343, 322);
            btnSubstract.Name = "btnSubstract";
            btnSubstract.Size = new Size(90, 50);
            btnSubstract.TabIndex = 11;
            btnSubstract.Text = "-";
            btnSubstract.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(343, 378);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 50);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = SystemColors.MenuHighlight;
            btnEquals.Location = new Point(343, 434);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(90, 50);
            btnEquals.TabIndex = 13;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            // 
            // btnComa
            // 
            btnComa.Location = new Point(247, 434);
            btnComa.Name = "btnComa";
            btnComa.Size = new Size(90, 50);
            btnComa.TabIndex = 14;
            btnComa.Text = ",";
            btnComa.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(343, 210);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(90, 50);
            btnDiv.TabIndex = 15;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveBorder;
            btnClear.Location = new Point(51, 434);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 50);
            btnClear.TabIndex = 16;
            btnClear.Text = "c";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // txtBxResult
            // 
            txtBxResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBxResult.Location = new Point(51, 121);
            txtBxResult.Multiline = true;
            txtBxResult.Name = "txtBxResult";
            txtBxResult.PlaceholderText = "0";
            txtBxResult.Size = new Size(382, 83);
            txtBxResult.TabIndex = 17;
            txtBxResult.TextAlign = HorizontalAlignment.Right;
            txtBxResult.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 714);
            Controls.Add(txtBxResult);
            Controls.Add(btnClear);
            Controls.Add(btnDiv);
            Controls.Add(btnComa);
            Controls.Add(btnEquals);
            Controls.Add(btnAdd);
            Controls.Add(btnSubstract);
            Controls.Add(btnMult);
            Controls.Add(button0);
            Controls.Add(button09);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button06);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button6;
        private Button button7;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button06;
        private Button button8;
        private Button button09;
        private Button button0;
        private Button btnMult;
        private Button btnSubstract;
        private Button btnAdd;
        private Button btnEquals;
        private Button btnComa;
        private Button btnDiv;
        private Button btnClear;
        private TextBox txtBxResult;
    }
}
