namespace Calculator_Winforms
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btnClear = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnSubtract = new Button();
            btnAdd = new Button();
            btnEquals = new Button();
            btnDecimal = new Button();
            btnZero = new Button();
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = SystemColors.Window;
            txtDisplay.Font = new Font("Segoe UI", 20F);
            txtDisplay.Location = new Point(24, 24);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(332, 52);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(24, 92);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(158, 48);
            btnClear.TabIndex = 1;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(198, 92);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(48, 48);
            btnDivide.TabIndex = 2;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += operatorButton_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(256, 92);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(48, 48);
            btnMultiply.TabIndex = 3;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += operatorButton_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(314, 92);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(42, 48);
            btnSubtract.TabIndex = 4;
            btnSubtract.Text = "−";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += operatorButton_Click;
            // 
            // Number buttons
            // 
            btnSeven.Location = new Point(24, 156);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(74, 48);
            btnSeven.TabIndex = 5;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += numberButton_Click;
            btnEight.Location = new Point(110, 156);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(74, 48);
            btnEight.TabIndex = 6;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += numberButton_Click;
            btnNine.Location = new Point(198, 156);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(48, 48);
            btnNine.TabIndex = 7;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += numberButton_Click;
            btnAdd.Location = new Point(256, 156);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 106);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += operatorButton_Click;
            btnFour.Location = new Point(24, 214);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(74, 48);
            btnFour.TabIndex = 9;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += numberButton_Click;
            btnFive.Location = new Point(110, 214);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(74, 48);
            btnFive.TabIndex = 10;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += numberButton_Click;
            btnSix.Location = new Point(198, 214);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(48, 48);
            btnSix.TabIndex = 11;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += numberButton_Click;
            btnOne.Location = new Point(24, 272);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(74, 48);
            btnOne.TabIndex = 12;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += numberButton_Click;
            btnTwo.Location = new Point(110, 272);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(74, 48);
            btnTwo.TabIndex = 13;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += numberButton_Click;
            btnThree.Location = new Point(198, 272);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(48, 48);
            btnThree.TabIndex = 14;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += numberButton_Click;
            btnZero.Location = new Point(24, 330);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(160, 48);
            btnZero.TabIndex = 15;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += numberButton_Click;
            btnDecimal.Location = new Point(198, 330);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(48, 48);
            btnDecimal.TabIndex = 16;
            btnDecimal.Text = ",";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += decimalButton_Click;
            btnEquals.Location = new Point(256, 272);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(100, 106);
            btnEquals.TabIndex = 17;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // Form2
            // 
            AcceptButton = btnEquals;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 405);
            Controls.Add(btnEquals);
            Controls.Add(btnDecimal);
            Controls.Add(btnZero);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnAdd);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnSubtract);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnClear);
            Controls.Add(txtDisplay);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Basic Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnClear;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnSubtract;
        private Button btnAdd;
        private Button btnEquals;
        private Button btnDecimal;
        private Button btnZero;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
    }
}
