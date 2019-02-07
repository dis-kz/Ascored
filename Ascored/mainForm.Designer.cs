namespace Ascored
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnOpenOrderCard = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.orderGuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusDgvColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ModifiedDateDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnOpenOrderCard);
            this.groupBox1.Controls.Add(this.btnCreateOrder);
            this.groupBox1.Controls.Add(this.dataGridViewOrders);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(675, 306);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание/редактирование заказов";
            // 
            // cmbSort
            // 
            this.cmbSort.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "по умолчанию",
            "по наименованию заказчика ▲",
            "по номеру заказа ▲",
            "по стоимости ▲",
            "по дате изменения ▲"});
            this.cmbSort.Location = new System.Drawing.Point(460, 24);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(199, 22);
            this.cmbSort.TabIndex = 5;
            this.cmbSort.SelectionChangeCommitted += new System.EventHandler(this.cmbSort_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сортировка:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Найти:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(321, 264);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(338, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnOpenOrderCard
            // 
            this.btnOpenOrderCard.Location = new System.Drawing.Point(142, 262);
            this.btnOpenOrderCard.Name = "btnOpenOrderCard";
            this.btnOpenOrderCard.Size = new System.Drawing.Size(119, 26);
            this.btnOpenOrderCard.TabIndex = 1;
            this.btnOpenOrderCard.Text = "Открыть ТКЗ";
            this.btnOpenOrderCard.UseVisualStyleBackColor = true;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(17, 262);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(119, 26);
            this.btnCreateOrder.TabIndex = 1;
            this.btnCreateOrder.Text = "Создать новый";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AutoGenerateColumns = false;
            this.dataGridViewOrders.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewOrders.ColumnHeadersHeight = 27;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderGuidDataGridViewTextBoxColumn,
            this.CustomerDgvColumn,
            this.NumberDgvColumn,
            this.CostDgvColumn,
            this.StatusDgvColumn,
            this.ModifiedDateDgvColumn});
            this.dataGridViewOrders.DataSource = this.orderBindingSource;
            this.dataGridViewOrders.EnableHeadersVisualStyles = false;
            this.dataGridViewOrders.Location = new System.Drawing.Point(17, 59);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewOrders.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.ShowCellToolTips = false;
            this.dataGridViewOrders.Size = new System.Drawing.Size(642, 193);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellDoubleClick);
            // 
            // orderGuidDataGridViewTextBoxColumn
            // 
            this.orderGuidDataGridViewTextBoxColumn.DataPropertyName = "OrderGuid";
            this.orderGuidDataGridViewTextBoxColumn.HeaderText = "OrderGuid";
            this.orderGuidDataGridViewTextBoxColumn.Name = "orderGuidDataGridViewTextBoxColumn";
            this.orderGuidDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderGuidDataGridViewTextBoxColumn.Visible = false;
            // 
            // CustomerDgvColumn
            // 
            this.CustomerDgvColumn.DataPropertyName = "Customer";
            this.CustomerDgvColumn.HeaderText = "Заказчик";
            this.CustomerDgvColumn.Name = "CustomerDgvColumn";
            this.CustomerDgvColumn.ReadOnly = true;
            this.CustomerDgvColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CustomerDgvColumn.Width = 185;
            // 
            // NumberDgvColumn
            // 
            this.NumberDgvColumn.DataPropertyName = "Number";
            this.NumberDgvColumn.HeaderText = "Номер заказа";
            this.NumberDgvColumn.Name = "NumberDgvColumn";
            this.NumberDgvColumn.ReadOnly = true;
            this.NumberDgvColumn.Width = 120;
            // 
            // CostDgvColumn
            // 
            this.CostDgvColumn.DataPropertyName = "Cost";
            this.CostDgvColumn.HeaderText = "Стоимость";
            this.CostDgvColumn.Name = "CostDgvColumn";
            this.CostDgvColumn.ReadOnly = true;
            // 
            // StatusDgvColumn
            // 
            this.StatusDgvColumn.DataPropertyName = "Status";
            this.StatusDgvColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.StatusDgvColumn.HeaderText = "Статус заказа";
            this.StatusDgvColumn.Name = "StatusDgvColumn";
            this.StatusDgvColumn.ReadOnly = true;
            this.StatusDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusDgvColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ModifiedDateDgvColumn
            // 
            this.ModifiedDateDgvColumn.DataPropertyName = "ModifiedDate";
            this.ModifiedDateDgvColumn.HeaderText = "Дата изменения";
            this.ModifiedDateDgvColumn.Name = "ModifiedDateDgvColumn";
            this.ModifiedDateDgvColumn.ReadOnly = true;
            this.ModifiedDateDgvColumn.Width = 120;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(DataModels.Order);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 300;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 389);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MainForm";
            this.Text = "Welcome to Ascored";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderGuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerDgvColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberDgvColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostDgvColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn StatusDgvColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedDateDgvColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Button btnOpenOrderCard;
    }
}

