namespace Shampaz
{
    partial class SellFactorsReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFactors = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.clnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFactorsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFactorItemsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.pDateFrom = new System.Windows.Forms.PersianDatePicker();
            this.pDateTo = new System.Windows.Forms.PersianDatePicker();
            this.btnFilter = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtFactorsCount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFactorItemsCount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFactorsTotalPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFactors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFactors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnDate,
            this.clnFactorsQuantity,
            this.clnFactorItemsQuantity,
            this.clnTotalPrice});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFactors.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFactors.EnableHeadersVisualStyles = false;
            this.dgvFactors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvFactors.Location = new System.Drawing.Point(12, 43);
            this.dgvFactors.Name = "dgvFactors";
            this.dgvFactors.ReadOnly = true;
            this.dgvFactors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFactors.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFactors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFactors.Size = new System.Drawing.Size(916, 363);
            this.dgvFactors.TabIndex = 0;
            this.dgvFactors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactors_CellDoubleClick);
            this.dgvFactors.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgvFactors_SortCompare);
            // 
            // clnDate
            // 
            this.clnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clnDate.HeaderText = "تاریخ";
            this.clnDate.Name = "clnDate";
            this.clnDate.ReadOnly = true;
            this.clnDate.Width = 59;
            // 
            // clnFactorsQuantity
            // 
            this.clnFactorsQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clnFactorsQuantity.HeaderText = "تعداد فاکتورها";
            this.clnFactorsQuantity.Name = "clnFactorsQuantity";
            this.clnFactorsQuantity.ReadOnly = true;
            this.clnFactorsQuantity.Width = 107;
            // 
            // clnFactorItemsQuantity
            // 
            this.clnFactorItemsQuantity.HeaderText = "تعداد اقلام";
            this.clnFactorItemsQuantity.Name = "clnFactorItemsQuantity";
            this.clnFactorItemsQuantity.ReadOnly = true;
            // 
            // clnTotalPrice
            // 
            this.clnTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clnTotalPrice.HeaderText = "قیمت";
            this.clnTotalPrice.Name = "clnTotalPrice";
            this.clnTotalPrice.ReadOnly = true;
            this.clnTotalPrice.Width = 63;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(882, 13);
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
            this.labelX2.Location = new System.Drawing.Point(550, 13);
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
            this.pDateFrom.Location = new System.Drawing.Point(590, 11);
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
            this.pDateTo.Location = new System.Drawing.Point(268, 11);
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
            this.btnFilter.Location = new System.Drawing.Point(170, 14);
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
            this.labelX3.Location = new System.Drawing.Point(836, 412);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(92, 23);
            this.labelX3.TabIndex = 16;
            this.labelX3.Text = "تعداد فاکتورها :";
            // 
            // labelX4
            // 
            this.labelX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(591, 412);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(104, 23);
            this.labelX4.TabIndex = 17;
            this.labelX4.Text = "جمع تعداد اقلام :";
            // 
            // labelX5
            // 
            this.labelX5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(295, 412);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(104, 23);
            this.labelX5.TabIndex = 18;
            this.labelX5.Text = "جمع کل قیمت :";
            // 
            // txtFactorsCount
            // 
            this.txtFactorsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtFactorsCount.Border.Class = "TextBoxBorder";
            this.txtFactorsCount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFactorsCount.Location = new System.Drawing.Point(701, 413);
            this.txtFactorsCount.Name = "txtFactorsCount";
            this.txtFactorsCount.PreventEnterBeep = true;
            this.txtFactorsCount.Size = new System.Drawing.Size(129, 23);
            this.txtFactorsCount.TabIndex = 19;
            // 
            // txtFactorItemsCount
            // 
            this.txtFactorItemsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtFactorItemsCount.Border.Class = "TextBoxBorder";
            this.txtFactorItemsCount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFactorItemsCount.Location = new System.Drawing.Point(405, 413);
            this.txtFactorItemsCount.Name = "txtFactorItemsCount";
            this.txtFactorItemsCount.PreventEnterBeep = true;
            this.txtFactorItemsCount.Size = new System.Drawing.Size(180, 23);
            this.txtFactorItemsCount.TabIndex = 20;
            // 
            // txtFactorsTotalPrice
            // 
            this.txtFactorsTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtFactorsTotalPrice.Border.Class = "TextBoxBorder";
            this.txtFactorsTotalPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFactorsTotalPrice.Location = new System.Drawing.Point(118, 413);
            this.txtFactorsTotalPrice.Name = "txtFactorsTotalPrice";
            this.txtFactorsTotalPrice.PreventEnterBeep = true;
            this.txtFactorsTotalPrice.Size = new System.Drawing.Size(171, 23);
            this.txtFactorsTotalPrice.TabIndex = 21;
            // 
            // SellFactorsReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 446);
            this.Controls.Add(this.txtFactorsTotalPrice);
            this.Controls.Add(this.txtFactorItemsCount);
            this.Controls.Add(this.txtFactorsCount);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
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
            this.Name = "SellFactorsReports";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تجمیع فروش تاریخ";
            this.Load += new System.EventHandler(this.SellFactorList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvFactors;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnFilter;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFactorsCount;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFactorItemsCount;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFactorsTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFactorsQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFactorItemsQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTotalPrice;
        public System.Windows.Forms.PersianDatePicker pDateFrom;
        public System.Windows.Forms.PersianDatePicker pDateTo;
    }
}