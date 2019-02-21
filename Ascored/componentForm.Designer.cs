namespace Ascored
{
    partial class ComponentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCreateGroup = new System.Windows.Forms.Button();
            this.btnAddComponent = new System.Windows.Forms.Button();
            this.dataGridViewComponents = new System.Windows.Forms.DataGridView();
            this.componentGuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupDgvColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReferDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComponents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnCreateGroup);
            this.groupBox1.Controls.Add(this.btnAddComponent);
            this.groupBox1.Controls.Add(this.dataGridViewComponents);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 467);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список компонентов";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Найти:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(336, 432);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(379, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateGroup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreateGroup.FlatAppearance.BorderSize = 0;
            this.btnCreateGroup.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnCreateGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCreateGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateGroup.Image = global::Ascored.Properties.Resources.creategroup16;
            this.btnCreateGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateGroup.Location = new System.Drawing.Point(150, 429);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(129, 26);
            this.btnCreateGroup.TabIndex = 2;
            this.btnCreateGroup.Text = "Создать группу";
            this.btnCreateGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateGroup.UseVisualStyleBackColor = true;
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            // 
            // btnAddComponent
            // 
            this.btnAddComponent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddComponent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddComponent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddComponent.FlatAppearance.BorderSize = 0;
            this.btnAddComponent.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAddComponent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddComponent.Image = global::Ascored.Properties.Resources.create16;
            this.btnAddComponent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddComponent.Location = new System.Drawing.Point(15, 429);
            this.btnAddComponent.Name = "btnAddComponent";
            this.btnAddComponent.Size = new System.Drawing.Size(129, 26);
            this.btnAddComponent.TabIndex = 2;
            this.btnAddComponent.Text = " Добавить новый";
            this.btnAddComponent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddComponent.UseVisualStyleBackColor = true;
            this.btnAddComponent.Click += new System.EventHandler(this.btnAddComponent_Click);
            // 
            // dataGridViewComponents
            // 
            this.dataGridViewComponents.AllowUserToAddRows = false;
            this.dataGridViewComponents.AutoGenerateColumns = false;
            this.dataGridViewComponents.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComponents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewComponents.ColumnHeadersHeight = 27;
            this.dataGridViewComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewComponents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.componentGuidDataGridViewTextBoxColumn,
            this.NameDgvColumn,
            this.GroupDgvColumn,
            this.ReferDgvColumn,
            this.PriceDgvColumn});
            this.dataGridViewComponents.DataSource = this.componentBindingSource;
            this.dataGridViewComponents.EnableHeadersVisualStyles = false;
            this.dataGridViewComponents.Location = new System.Drawing.Point(15, 20);
            this.dataGridViewComponents.Name = "dataGridViewComponents";
            this.dataGridViewComponents.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewComponents.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewComponents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewComponents.Size = new System.Drawing.Size(700, 399);
            this.dataGridViewComponents.TabIndex = 0;
            this.dataGridViewComponents.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewComponents_CellEndEdit);
            this.dataGridViewComponents.DoubleClick += new System.EventHandler(this.dataGridViewComponents_DoubleClick);
            // 
            // componentGuidDataGridViewTextBoxColumn
            // 
            this.componentGuidDataGridViewTextBoxColumn.DataPropertyName = "ComponentGuid";
            this.componentGuidDataGridViewTextBoxColumn.HeaderText = "ComponentGuid";
            this.componentGuidDataGridViewTextBoxColumn.Name = "componentGuidDataGridViewTextBoxColumn";
            this.componentGuidDataGridViewTextBoxColumn.Visible = false;
            // 
            // NameDgvColumn
            // 
            this.NameDgvColumn.DataPropertyName = "Name";
            this.NameDgvColumn.HeaderText = "Наименование";
            this.NameDgvColumn.Name = "NameDgvColumn";
            this.NameDgvColumn.Width = 280;
            // 
            // GroupDgvColumn
            // 
            this.GroupDgvColumn.DataPropertyName = "ComponentGroupGuid";
            this.GroupDgvColumn.DataSource = this.groupBindingSource;
            this.GroupDgvColumn.DisplayMember = "Name";
            this.GroupDgvColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.GroupDgvColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupDgvColumn.HeaderText = "Группа компонентов";
            this.GroupDgvColumn.Name = "GroupDgvColumn";
            this.GroupDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GroupDgvColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GroupDgvColumn.ValueMember = "ComponentGroupGuid";
            this.GroupDgvColumn.Width = 160;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(DataModels.ComponentGroup);
            // 
            // ReferDgvColumn
            // 
            this.ReferDgvColumn.DataPropertyName = "Reference";
            this.ReferDgvColumn.HeaderText = "Референс";
            this.ReferDgvColumn.Name = "ReferDgvColumn";
            this.ReferDgvColumn.Width = 140;
            // 
            // PriceDgvColumn
            // 
            this.PriceDgvColumn.DataPropertyName = "Price";
            this.PriceDgvColumn.HeaderText = "Цена";
            this.PriceDgvColumn.Name = "PriceDgvColumn";
            // 
            // componentBindingSource
            // 
            this.componentBindingSource.DataSource = typeof(DataModels.Component);
            // 
            // ComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 500);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ComponentForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Компоненты  и материалы";
            this.Load += new System.EventHandler(this.ComponentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComponents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewComponents;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.BindingSource componentBindingSource;
        private System.Windows.Forms.Button btnAddComponent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentGuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDgvColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn GroupDgvColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferDgvColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceDgvColumn;
        private System.Windows.Forms.Button btnCreateGroup;
    }
}