namespace Shampaz
{
    partial class ProductAddForm
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
            this.lblName = new DevComponents.DotNetBar.LabelX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPrice = new DevComponents.DotNetBar.LabelX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtProfit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // lblName
            // 
            // 
            // 
            // 
            this.lblName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblName.Location = new System.Drawing.Point(320, 11);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(75, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "نام :";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.PreventEnterBeep = true;
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(302, 23);
            this.txtName.TabIndex = 1;
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.Border.Class = "TextBoxBorder";
            this.txtPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPrice.Location = new System.Drawing.Point(12, 41);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PreventEnterBeep = true;
            this.txtPrice.Size = new System.Drawing.Size(302, 23);
            this.txtPrice.TabIndex = 3;
            // 
            // lblPrice
            // 
            // 
            // 
            // 
            this.lblPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPrice.Location = new System.Drawing.Point(320, 40);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPrice.Size = new System.Drawing.Size(75, 23);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "قیمت :";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnSave.Location = new System.Drawing.Point(320, 98);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtProfit
            // 
            // 
            // 
            // 
            this.txtProfit.Border.Class = "TextBoxBorder";
            this.txtProfit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProfit.Location = new System.Drawing.Point(12, 70);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.PreventEnterBeep = true;
            this.txtProfit.Size = new System.Drawing.Size(302, 23);
            this.txtProfit.TabIndex = 6;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(320, 69);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "سود :";
            // 
            // ProductAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 138);
            this.Controls.Add(this.txtProfit);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductAddForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "افزودن کالا";
            this.Load += new System.EventHandler(this.ProductAddForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPrice;
        private DevComponents.DotNetBar.LabelX lblPrice;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProfit;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}