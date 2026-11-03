namespace Calculator_Winforms
{
    partial class Form1
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
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            grpIva = new GroupBox();
            rbIva21 = new RadioButton();
            rbIva10 = new RadioButton();
            rbIva4 = new RadioButton();
            rbIva0 = new RadioButton();
            grpDiscount = new GroupBox();
            rbD20 = new RadioButton();
            rbD10 = new RadioButton();
            rbD5 = new RadioButton();
            rbD0 = new RadioButton();
            chkPartner = new CheckBox();
            btnCalculate = new Button();
            lblNoIva = new Label();
            txtNoIva = new TextBox();
            lblWithIva = new Label();
            txtWithIva = new TextBox();
            grpIva.SuspendLayout();
            grpDiscount.SuspendLayout();
            SuspendLayout();
            //
            // lblPrice
            //
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(32, 30);
            lblPrice.Text = "Price";
            //
            // txtPrice
            //
            txtPrice.Location = new Point(32, 53);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(180, 27);
            txtPrice.TabIndex = 0;
            //
            // lblQuantity
            //
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(32, 94);
            lblQuantity.Text = "Quantity";
            //
            // txtQuantity
            //
            txtQuantity.Location = new Point(32, 117);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(180, 27);
            txtQuantity.TabIndex = 1;
            //
            // grpIva
            //
            grpIva.Controls.Add(rbIva21);
            grpIva.Controls.Add(rbIva10);
            grpIva.Controls.Add(rbIva4);
            grpIva.Controls.Add(rbIva0);
            grpIva.Location = new Point(250, 20);
            grpIva.Name = "grpIva";
            grpIva.Size = new Size(220, 145);
            grpIva.TabStop = false;
            grpIva.Text = "IVA";
            //
            // rbIva21
            //
            rbIva21.AutoSize = true;
            rbIva21.Location = new Point(20, 108);
            rbIva21.Name = "rbIva21";
            rbIva21.Text = "21%";
            rbIva21.UseVisualStyleBackColor = true;
            //
            // rbIva10
            //
            rbIva10.AutoSize = true;
            rbIva10.Location = new Point(20, 82);
            rbIva10.Name = "rbIva10";
            rbIva10.Text = "10%";
            rbIva10.UseVisualStyleBackColor = true;
            //
            // rbIva4
            //
            rbIva4.AutoSize = true;
            rbIva4.Location = new Point(20, 56);
            rbIva4.Name = "rbIva4";
            rbIva4.Text = "4%";
            rbIva4.UseVisualStyleBackColor = true;
            //
            // rbIva0
            //
            rbIva0.AutoSize = true;
            rbIva0.Checked = true;
            rbIva0.Location = new Point(20, 30);
            rbIva0.Name = "rbIva0";
            rbIva0.TabStop = true;
            rbIva0.Text = "0%";
            rbIva0.UseVisualStyleBackColor = true;
            //
            // grpDiscount
            //
            grpDiscount.Controls.Add(rbD20);
            grpDiscount.Controls.Add(rbD10);
            grpDiscount.Controls.Add(rbD5);
            grpDiscount.Controls.Add(rbD0);
            grpDiscount.Location = new Point(250, 181);
            grpDiscount.Name = "grpDiscount";
            grpDiscount.Size = new Size(220, 145);
            grpDiscount.TabStop = false;
            grpDiscount.Text = "Discount";
            //
            // rbD20
            //
            rbD20.AutoSize = true;
            rbD20.Location = new Point(20, 108);
            rbD20.Name = "rbD20";
            rbD20.Text = "20%";
            rbD20.UseVisualStyleBackColor = true;
            //
            // rbD10
            //
            rbD10.AutoSize = true;
            rbD10.Location = new Point(20, 82);
            rbD10.Name = "rbD10";
            rbD10.Text = "10%";
            rbD10.UseVisualStyleBackColor = true;
            //
            // rbD5
            //
            rbD5.AutoSize = true;
            rbD5.Location = new Point(20, 56);
            rbD5.Name = "rbD5";
            rbD5.Text = "5%";
            rbD5.UseVisualStyleBackColor = true;
            //
            // rbD0
            //
            rbD0.AutoSize = true;
            rbD0.Checked = true;
            rbD0.Location = new Point(20, 30);
            rbD0.Name = "rbD0";
            rbD0.TabStop = true;
            rbD0.Text = "0%";
            rbD0.UseVisualStyleBackColor = true;
            //
            // chkPartner
            //
            chkPartner.AutoSize = true;
            chkPartner.Location = new Point(32, 181);
            chkPartner.Name = "chkPartner";
            chkPartner.Size = new Size(209, 24);
            chkPartner.TabIndex = 2;
            chkPartner.Text = "Partner (aplica 30% fijo)";
            chkPartner.UseVisualStyleBackColor = true;
            chkPartner.CheckedChanged += chkPartner_CheckedChanged;
            //
            // btnCalculate
            //
            btnCalculate.Location = new Point(32, 229);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(180, 42);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            //
            // lblNoIva
            //
            lblNoIva.AutoSize = true;
            lblNoIva.Location = new Point(32, 357);
            lblNoIva.Text = "NO IVA";
            //
            // txtNoIva
            //
            txtNoIva.Location = new Point(32, 381);
            txtNoIva.Name = "txtNoIva";
            txtNoIva.ReadOnly = true;
            txtNoIva.Size = new Size(438, 27);
            txtNoIva.TabIndex = 4;
            //
            // lblWithIva
            //
            lblWithIva.AutoSize = true;
            lblWithIva.Location = new Point(32, 426);
            lblWithIva.Text = "with IVA";
            //
            // txtWithIva
            //
            txtWithIva.Location = new Point(32, 450);
            txtWithIva.Name = "txtWithIva";
            txtWithIva.ReadOnly = true;
            txtWithIva.Size = new Size(438, 27);
            txtWithIva.TabIndex = 5;
            //
            // Form1
            //
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 520);
            Controls.Add(txtWithIva);
            Controls.Add(lblWithIva);
            Controls.Add(txtNoIva);
            Controls.Add(lblNoIva);
            Controls.Add(btnCalculate);
            Controls.Add(chkPartner);
            Controls.Add(grpDiscount);
            Controls.Add(grpIva);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IVA Calculator";
            grpIva.ResumeLayout(false);
            grpIva.PerformLayout();
            grpDiscount.ResumeLayout(false);
            grpDiscount.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private GroupBox grpIva;
        private RadioButton rbIva21;
        private RadioButton rbIva10;
        private RadioButton rbIva4;
        private RadioButton rbIva0;
        private GroupBox grpDiscount;
        private RadioButton rbD20;
        private RadioButton rbD10;
        private RadioButton rbD5;
        private RadioButton rbD0;
        private CheckBox chkPartner;
        private Button btnCalculate;
        private Label lblNoIva;
        private TextBox txtNoIva;
        private Label lblWithIva;
        private TextBox txtWithIva;
    }
}
