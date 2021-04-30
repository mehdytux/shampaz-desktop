namespace Shampaz
{
    partial class PersonBuysAggregationForm
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
            this.dgvFactors = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.pDateFrom = new System.Windows.Forms.PersianDatePicker();
            this.pDateTo = new System.Windows.Forms.PersianDatePicker();
            this.btnFilter = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtSumNumbers = new System.Windows.Forms.TextBox();
            this.txtSumPrice = new System.Windows.Forms.TextBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPaymentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFactors
            // 
            this.dgvFactors.AllowUserToAddRows = false;
            this.dgvFactors.AllowUserToDeleteRows = false;
            this.dgvFactors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFactors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFactors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnName,
            this.clnNumbers,
            this.clnTotalPrice,
            this.clnPaymentPrice,
            this.clnRemaining,
            this.clnNature});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFactors.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFactors.EnableHeadersVisualStyles = false;
            this.dgvFactors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvFactors.Location = new System.Drawing.Point(12, 43);
            this.dgvFactors.Name = "dgvFactors";
            this.dgvFactors.ReadOnly = true;
            this.dgvFactors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFactors.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFactors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFactors.Size = new System.Drawing.Size(811, 357);
            this.dgvFactors.TabIndex = 0;
            this.dgvFactors.SelectionChanged += new System.EventHandler(this.dgvFactors_SelectionChanged);
            this.dgvFactors.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgvFactors_SortCompare);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(777, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(45, 23);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "تاریخ از";
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(445, 13);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(26, 23);
            this.labelX2.TabIndex = 12;
            this.labelX2.Text = "تا";
            // 
            // pDateFrom
            // 
            this.pDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pDateFrom.AutoSize = true;
            this.pDateFrom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pDateFrom.BackColor = System.Drawing.Color.White;
            this.pDateFrom.GeorgianDate = null;
            this.pDateFrom.Location = new System.Drawing.Point(485, 14);
            this.pDateFrom.Margin = new System.Windows.Forms.Padding(0);
            this.pDateFrom.Name = "pDateFrom";
            this.pDateFrom.PersianDate.Day = 0;
            this.pDateFrom.PersianDate.Month = 0;
            this.pDateFrom.PersianDate.Year = 0;
            this.pDateFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pDateFrom.Size = new System.Drawing.Size(289, 25);
            this.pDateFrom.TabIndex = 13;
            // 
            // pDateTo
            // 
            this.pDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pDateTo.AutoSize = true;
            this.pDateTo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pDateTo.BackColor = System.Drawing.Color.White;
            this.pDateTo.GeorgianDate = null;
            this.pDateTo.Location = new System.Drawing.Point(164, 14);
            this.pDateTo.Margin = new System.Windows.Forms.Padding(0);
            this.pDateTo.Name = "pDateTo";
            this.pDateTo.PersianDate.Day = 0;
            this.pDateTo.PersianDate.Month = 0;
            this.pDateTo.PersianDate.Year = 0;
            this.pDateTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pDateTo.Size = new System.Drawing.Size(289, 25);
            this.pDateTo.TabIndex = 14;
            // 
            // btnFilter
            // 
            this.btnFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFilter.Location = new System.Drawing.Point(65, 14);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFilter.TabIndex = 15;
            this.btnFilter.Text = "اعمال";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(747, 406);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 16;
            this.labelX3.Text = "جمع تعداد :";
            // 
            // txtSumNumbers
            // 
            this.txtSumNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSumNumbers.Location = new System.Drawing.Point(545, 406);
            this.txtSumNumbers.Name = "txtSumNumbers";
            this.txtSumNumbers.Size = new System.Drawing.Size(196, 23);
            this.txtSumNumbers.TabIndex = 17;
            // 
            // txtSumPrice
            // 
            this.txtSumPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSumPrice.Location = new System.Drawing.Point(194, 406);
            this.txtSumPrice.Name = "txtSumPrice";
            this.txtSumPrice.Size = new System.Drawing.Size(196, 23);
            this.txtSumPrice.TabIndex = 19;
            // 
            // labelX4
            // 
            this.labelX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(396, 406);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 18;
            this.labelX4.Text = "جمع قیمت :";
            // 
            // clnId
            // 
            this.clnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clnId.HeaderText = "شناسه";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 75;
            // 
            // clnName
            // 
            this.clnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clnName.HeaderText = "نام شخص";
            this.clnName.Name = "clnName";
            this.clnName.ReadOnly = true;
            this.clnName.Width = 90;
            // 
            // clnNumbers
            // 
            this.clnNumbers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clnNumbers.HeaderText = "تعداد اقلام";
            this.clnNumbers.Name = "clnNumbers";
            this.clnNumbers.ReadOnly = true;
            this.clnNumbers.Width = 88;
            // 
            // clnTotalPrice
            // 
            this.clnTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clnTotalPrice.HeaderText = "قیمت";
            this.clnTotalPrice.Name = "clnTotalPrice";
            this.clnTotalPrice.ReadOnly = true;
            this.clnTotalPrice.Width = 63;
            // 
            // clnPaymentPrice
            // 
            this.clnPaymentPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clnPaymentPrice.HeaderText = "پرداختی";
            this.clnPaymentPrice.Name = "clnPaymentPrice";
            this.clnPaymentPrice.ReadOnly = true;
            this.clnPaymentPrice.Width = 78;
            // 
            // clnRemaining
            // 
            this.clnRemaining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clnRemaining.HeaderText = "باقیمانده";
            this.clnRemaining.Name = "clnRemaining";
            this.clnRemaining.ReadOnly = true;
            this.clnRemaining.Width = 80;
            // 
            // clnNature
            // 
            this.clnNature.HeaderText = "ماهیت";
            this.clnNature.Name = "clnNature";
            this.clnNature.ReadOnly = true;
            // 
            // PersonBuysAggregationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 441);
            this.Controls.Add(this.txtSumPrice);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtSumNumbers);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.pDateTo);
            this.Controls.Add(this.pDateFrom);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dgvFactors);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PersonBuysAggregationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "تجمیع  خرید اشخاص";
            this.Load += new System.EventHandler(this.SellFactorList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvFactors;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.PersianDatePicker pDateFrom;
        private System.Windows.Forms.PersianDatePicker pDateTo;
        private DevComponents.DotNetBar.ButtonX btnFilter;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.TextBox txtSumNumbers;
        private System.Windows.Forms.TextBox txtSumPrice;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPaymentPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNature;
    }
}