namespace Shampaz
{
    partial class BuyFactorAddForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pdpDate = new System.Windows.Forms.PersianDatePicker();
            this.dgvItems = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.clnProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lblFactorId = new DevComponents.DotNetBar.LabelX();
            this.btnPerson = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtTotalPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btnAddProduct = new DevComponents.DotNetBar.ButtonX();
            this.btnSaveAndClose = new DevComponents.DotNetBar.ButtonX();
            this.txtPayment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnSaveNew = new DevComponents.DotNetBar.ButtonX();
            this.btnProductRemove = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // pdpDate
            // 
            this.pdpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pdpDate.AutoSize = true;
            this.pdpDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pdpDate.BackColor = System.Drawing.Color.White;
            this.pdpDate.GeorgianDate = null;
            this.pdpDate.Location = new System.Drawing.Point(286, 11);
            this.pdpDate.Margin = new System.Windows.Forms.Padding(0);
            this.pdpDate.Name = "pdpDate";
            this.pdpDate.PersianDate.Day = 0;
            this.pdpDate.PersianDate.Month = 0;
            this.pdpDate.PersianDate.Year = 0;
            this.pdpDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pdpDate.Size = new System.Drawing.Size(289, 25);
            this.pdpDate.TabIndex = 0;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnProductId,
            this.clnProductName,
            this.clnProductPrice,
            this.clnNumber,
            this.clnTotalPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvItems.Location = new System.Drawing.Point(12, 48);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItems.Size = new System.Drawing.Size(816, 337);
            this.dgvItems.TabIndex = 1;
            this.dgvItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellEndEdit);
            // 
            // clnProductId
            // 
            this.clnProductId.HeaderText = "شناسه";
            this.clnProductId.Name = "clnProductId";
            this.clnProductId.Visible = false;
            // 
            // clnProductName
            // 
            this.clnProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnProductName.HeaderText = "محصول";
            this.clnProductName.Name = "clnProductName";
            // 
            // clnProductPrice
            // 
            this.clnProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnProductPrice.HeaderText = "فی";
            this.clnProductPrice.Name = "clnProductPrice";
            this.clnProductPrice.Width = 51;
            // 
            // clnNumber
            // 
            this.clnNumber.HeaderText = "تعداد";
            this.clnNumber.Name = "clnNumber";
            // 
            // clnTotalPrice
            // 
            this.clnTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnTotalPrice.HeaderText = "قیمت کل";
            this.clnTotalPrice.Name = "clnTotalPrice";
            this.clnTotalPrice.Width = 82;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(768, 10);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(60, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "فروشنده : ";
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(163, 10);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(92, 23);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "شماره فاکتور : ";
            // 
            // lblFactorId
            // 
            this.lblFactorId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lblFactorId.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFactorId.Location = new System.Drawing.Point(111, 12);
            this.lblFactorId.Name = "lblFactorId";
            this.lblFactorId.Size = new System.Drawing.Size(57, 23);
            this.lblFactorId.TabIndex = 7;
            // 
            // btnPerson
            // 
            this.btnPerson.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerson.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPerson.Image = global::Shampaz.Properties.Resources.search_16;
            this.btnPerson.Location = new System.Drawing.Point(611, 10);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(151, 23);
            this.btnPerson.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPerson.TabIndex = 9;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(214, 390);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(60, 23);
            this.labelX3.TabIndex = 10;
            this.labelX3.Text = "قیمت کل :";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.txtTotalPrice.Border.Class = "TextBoxBorder";
            this.txtTotalPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTotalPrice.Location = new System.Drawing.Point(12, 391);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PreventEnterBeep = true;
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(196, 23);
            this.txtTotalPrice.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(750, 480);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtDescription.Border.Class = "TextBoxBorder";
            this.txtDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescription.Location = new System.Drawing.Point(296, 392);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PreventEnterBeep = true;
            this.txtDescription.Size = new System.Drawing.Size(466, 71);
            this.txtDescription.TabIndex = 13;
            // 
            // labelX4
            // 
            this.labelX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(768, 391);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(60, 23);
            this.labelX4.TabIndex = 14;
            this.labelX4.Text = "توضیحات :";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddProduct.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddProduct.Location = new System.Drawing.Point(12, 362);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(104, 23);
            this.btnAddProduct.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddProduct.TabIndex = 15;
            this.btnAddProduct.Text = "افزودن محصول";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAndClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveAndClose.Location = new System.Drawing.Point(637, 480);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(107, 23);
            this.btnSaveAndClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveAndClose.TabIndex = 16;
            this.btnSaveAndClose.Text = "ذخیره و بستن";
            this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveAndClose_Click);
            // 
            // txtPayment
            // 
            this.txtPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.txtPayment.Border.Class = "TextBoxBorder";
            this.txtPayment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPayment.Location = new System.Drawing.Point(12, 420);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.PreventEnterBeep = true;
            this.txtPayment.Size = new System.Drawing.Size(196, 23);
            this.txtPayment.TabIndex = 19;
            // 
            // labelX5
            // 
            this.labelX5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(214, 419);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(60, 23);
            this.labelX5.TabIndex = 18;
            this.labelX5.Text = "پرداختی :";
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveNew.Location = new System.Drawing.Point(524, 480);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(107, 23);
            this.btnSaveNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveNew.TabIndex = 20;
            this.btnSaveNew.Text = "ذخیره و جدید";
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnProductRemove
            // 
            this.btnProductRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnProductRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProductRemove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnProductRemove.Location = new System.Drawing.Point(122, 362);
            this.btnProductRemove.Name = "btnProductRemove";
            this.btnProductRemove.Size = new System.Drawing.Size(104, 23);
            this.btnProductRemove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnProductRemove.TabIndex = 21;
            this.btnProductRemove.Text = "حذف محصول";
            this.btnProductRemove.Click += new System.EventHandler(this.btnProductRemove_Click);
            // 
            // BuyFactorAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 517);
            this.Controls.Add(this.btnProductRemove);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.btnSaveAndClose);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.btnPerson);
            this.Controls.Add(this.lblFactorId);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.pdpDate);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BuyFactorAddForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاکتور فروش";
            this.Load += new System.EventHandler(this.SellFactorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PersianDatePicker pdpDate;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvItems;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lblFactorId;
        private DevComponents.DotNetBar.ButtonX btnPerson;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTotalPrice;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescription;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTotalPrice;
        private DevComponents.DotNetBar.ButtonX btnAddProduct;
        private DevComponents.DotNetBar.ButtonX btnSaveAndClose;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPayment;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnSaveNew;
        private DevComponents.DotNetBar.ButtonX btnProductRemove;
    }
}