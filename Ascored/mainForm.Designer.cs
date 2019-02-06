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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.ModifiedDateDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbSortCustomer = new System.Windows.Forms.Label();
            this.orderGuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusDgvColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbSortCustomer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearch);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер или имя заказчика:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(312, 264);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(347, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewOrders.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.ShowCellToolTips = false;
            this.dataGridViewOrders.Size = new System.Drawing.Size(642, 193);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellDoubleClick);
            // 
            // ModifiedDateDgvColumn
            // 
            this.ModifiedDateDgvColumn.DataPropertyName = "ModifiedDate";
            this.ModifiedDateDgvColumn.HeaderText = "Дата изменения";
            this.ModifiedDateDgvColumn.Name = "ModifiedDateDgvColumn";
            this.ModifiedDateDgvColumn.ReadOnly = true;
            this.ModifiedDateDgvColumn.Width = 120;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 300;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сортировка:";
            // 
            // lbSortCustomer
            // 
            this.lbSortCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSortCustomer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSortCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSortCustomer.Location = new System.Drawing.Point(125, 33);
            this.lbSortCustomer.Name = "lbSortCustomer";
            this.lbSortCustomer.Size = new System.Drawing.Size(142, 16);
            this.lbSortCustomer.TabIndex = 4;
            this.lbSortCustomer.Text = "По имени заказчика  ▲";
            this.lbSortCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(DataModels.Order);
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(296, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "По номер заказа  ▲";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(447, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "По стоимости  ▲";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(581, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "По дате  ▲";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
        private System.Windows.Forms.Label lbSortCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

