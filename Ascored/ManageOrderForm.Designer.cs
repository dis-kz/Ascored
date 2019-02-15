namespace Ascored
{
    partial class ManageOrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOrderForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tbpEntry = new System.Windows.Forms.TabPage();
            this.tbpOrder = new System.Windows.Forms.TabPage();
            this.tbpShipped = new System.Windows.Forms.TabPage();
            this.tbpArchiv = new System.Windows.Forms.TabPage();
            this.dataGridViewEntry = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOpenOrderCard = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.dataGridViewShipped = new System.Windows.Forms.DataGridView();
            this.dataGridViewArchiv = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tbpEntry.SuspendLayout();
            this.tbpOrder.SuspendLayout();
            this.tbpShipped.SuspendLayout();
            this.tbpArchiv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntry)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShipped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArchiv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbpEntry);
            this.tabControl.Controls.Add(this.tbpOrder);
            this.tabControl.Controls.Add(this.tbpShipped);
            this.tabControl.Controls.Add(this.tbpArchiv);
            this.tabControl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(13, 88);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(15, 5);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(690, 380);
            this.tabControl.TabIndex = 0;
            // 
            // tbpEntry
            // 
            this.tbpEntry.BackColor = System.Drawing.Color.White;
            this.tbpEntry.Controls.Add(this.button1);
            this.tbpEntry.Controls.Add(this.btnOpenOrderCard);
            this.tbpEntry.Controls.Add(this.btnCreateOrder);
            this.tbpEntry.Controls.Add(this.dataGridViewEntry);
            this.tbpEntry.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbpEntry.Location = new System.Drawing.Point(4, 27);
            this.tbpEntry.Name = "tbpEntry";
            this.tbpEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEntry.Size = new System.Drawing.Size(682, 349);
            this.tbpEntry.TabIndex = 0;
            this.tbpEntry.Text = "Заявка";
            // 
            // tbpOrder
            // 
            this.tbpOrder.Controls.Add(this.dataGridViewOrder);
            this.tbpOrder.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbpOrder.Location = new System.Drawing.Point(4, 27);
            this.tbpOrder.Name = "tbpOrder";
            this.tbpOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOrder.Size = new System.Drawing.Size(682, 349);
            this.tbpOrder.TabIndex = 1;
            this.tbpOrder.Text = " Производство";
            this.tbpOrder.UseVisualStyleBackColor = true;
            // 
            // tbpShipped
            // 
            this.tbpShipped.Controls.Add(this.dataGridViewShipped);
            this.tbpShipped.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbpShipped.Location = new System.Drawing.Point(4, 27);
            this.tbpShipped.Name = "tbpShipped";
            this.tbpShipped.Padding = new System.Windows.Forms.Padding(3);
            this.tbpShipped.Size = new System.Drawing.Size(682, 349);
            this.tbpShipped.TabIndex = 2;
            this.tbpShipped.Text = "Отгружено";
            this.tbpShipped.UseVisualStyleBackColor = true;
            // 
            // tbpArchiv
            // 
            this.tbpArchiv.Controls.Add(this.dataGridViewArchiv);
            this.tbpArchiv.Location = new System.Drawing.Point(4, 27);
            this.tbpArchiv.Name = "tbpArchiv";
            this.tbpArchiv.Padding = new System.Windows.Forms.Padding(3);
            this.tbpArchiv.Size = new System.Drawing.Size(682, 349);
            this.tbpArchiv.TabIndex = 3;
            this.tbpArchiv.Text = "Архив";
            this.tbpArchiv.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEntry
            // 
            this.dataGridViewEntry.AllowUserToAddRows = false;
            this.dataGridViewEntry.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEntry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewEntry.ColumnHeadersHeight = 27;
            this.dataGridViewEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewEntry.EnableHeadersVisualStyles = false;
            this.dataGridViewEntry.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewEntry.Name = "dataGridViewEntry";
            this.dataGridViewEntry.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewEntry.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewEntry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewEntry.Size = new System.Drawing.Size(667, 300);
            this.dataGridViewEntry.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Поиск:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(83, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(288, 22);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(593, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Удалить";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.button1, "Удалить");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnOpenOrderCard
            // 
            this.btnOpenOrderCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenOrderCard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOpenOrderCard.FlatAppearance.BorderSize = 0;
            this.btnOpenOrderCard.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnOpenOrderCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnOpenOrderCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenOrderCard.Image = global::Ascored.Properties.Resources.projectcard16;
            this.btnOpenOrderCard.Location = new System.Drawing.Point(127, 312);
            this.btnOpenOrderCard.Name = "btnOpenOrderCard";
            this.btnOpenOrderCard.Size = new System.Drawing.Size(85, 26);
            this.btnOpenOrderCard.TabIndex = 4;
            this.btnOpenOrderCard.Text = "Открыть";
            this.btnOpenOrderCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenOrderCard.UseVisualStyleBackColor = true;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreateOrder.FlatAppearance.BorderSize = 0;
            this.btnCreateOrder.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnCreateOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateOrder.Image = global::Ascored.Properties.Resources.create16;
            this.btnCreateOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateOrder.Location = new System.Drawing.Point(6, 312);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(115, 26);
            this.btnCreateOrder.TabIndex = 5;
            this.btnCreateOrder.Text = "Создать новый";
            this.btnCreateOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 300;
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
            this.cmbSort.Location = new System.Drawing.Point(478, 29);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(190, 22);
            this.cmbSort.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Сортировка:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbSort);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(13, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 72);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Панель управления";
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            this.dataGridViewOrder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewOrder.ColumnHeadersHeight = 27;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewOrder.EnableHeadersVisualStyles = false;
            this.dataGridViewOrder.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewOrder.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewOrder.Size = new System.Drawing.Size(667, 300);
            this.dataGridViewOrder.TabIndex = 2;
            // 
            // dataGridViewShipped
            // 
            this.dataGridViewShipped.AllowUserToAddRows = false;
            this.dataGridViewShipped.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShipped.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewShipped.ColumnHeadersHeight = 27;
            this.dataGridViewShipped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewShipped.EnableHeadersVisualStyles = false;
            this.dataGridViewShipped.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewShipped.Name = "dataGridViewShipped";
            this.dataGridViewShipped.RowHeadersVisible = false;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewShipped.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewShipped.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewShipped.Size = new System.Drawing.Size(667, 300);
            this.dataGridViewShipped.TabIndex = 3;
            // 
            // dataGridViewArchiv
            // 
            this.dataGridViewArchiv.AllowUserToAddRows = false;
            this.dataGridViewArchiv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArchiv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewArchiv.ColumnHeadersHeight = 27;
            this.dataGridViewArchiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewArchiv.EnableHeadersVisualStyles = false;
            this.dataGridViewArchiv.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewArchiv.Name = "dataGridViewArchiv";
            this.dataGridViewArchiv.RowHeadersVisible = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewArchiv.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewArchiv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewArchiv.Size = new System.Drawing.Size(667, 300);
            this.dataGridViewArchiv.TabIndex = 3;
            // 
            // ManageOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ManageOrderForm";
            this.Text = "Заказы";
            this.tabControl.ResumeLayout(false);
            this.tbpEntry.ResumeLayout(false);
            this.tbpOrder.ResumeLayout(false);
            this.tbpShipped.ResumeLayout(false);
            this.tbpArchiv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntry)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShipped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArchiv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tbpEntry;
        private System.Windows.Forms.TabPage tbpOrder;
        private System.Windows.Forms.TabPage tbpShipped;
        private System.Windows.Forms.TabPage tbpArchiv;
        private System.Windows.Forms.DataGridView dataGridViewEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnOpenOrderCard;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.DataGridView dataGridViewShipped;
        private System.Windows.Forms.DataGridView dataGridViewArchiv;
    }
}