namespace Ascored
{
    partial class ProductComponentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddAssembly = new System.Windows.Forms.Button();
            this.btnAddComponent = new System.Windows.Forms.Button();
            this.dataGridViewComponents = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productComponentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productComponentGuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productGuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentGuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComponents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productComponentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnAddAssembly);
            this.groupBox1.Controls.Add(this.btnAddComponent);
            this.groupBox1.Controls.Add(this.dataGridViewComponents);
            this.groupBox1.Location = new System.Drawing.Point(13, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 431);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список оборудования и материалов";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Найти:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(438, 394);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(277, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddAssembly
            // 
            this.btnAddAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAssembly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAssembly.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddAssembly.FlatAppearance.BorderSize = 0;
            this.btnAddAssembly.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAddAssembly.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddAssembly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAssembly.Image = global::Ascored.Properties.Resources.create16;
            this.btnAddAssembly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAssembly.Location = new System.Drawing.Point(175, 390);
            this.btnAddAssembly.Name = "btnAddAssembly";
            this.btnAddAssembly.Size = new System.Drawing.Size(117, 26);
            this.btnAddAssembly.TabIndex = 2;
            this.btnAddAssembly.Text = " Добавить узел";
            this.btnAddAssembly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddAssembly.UseVisualStyleBackColor = true;
            this.btnAddAssembly.Click += new System.EventHandler(this.btnAddAssembly_Click);
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
            this.btnAddComponent.Image = global::Ascored.Properties.Resources.add16;
            this.btnAddComponent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddComponent.Location = new System.Drawing.Point(15, 391);
            this.btnAddComponent.Name = "btnAddComponent";
            this.btnAddComponent.Size = new System.Drawing.Size(154, 26);
            this.btnAddComponent.TabIndex = 2;
            this.btnAddComponent.Text = " Добавить компонент";
            this.btnAddComponent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddComponent.UseVisualStyleBackColor = true;
            this.btnAddComponent.Click += new System.EventHandler(this.btnAddComponent_Click);
            // 
            // dataGridViewComponents
            // 
            this.dataGridViewComponents.AllowUserToAddRows = false;
            this.dataGridViewComponents.AutoGenerateColumns = false;
            this.dataGridViewComponents.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComponents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewComponents.ColumnHeadersHeight = 27;
            this.dataGridViewComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewComponents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productComponentGuidDataGridViewTextBoxColumn,
            this.productGuidDataGridViewTextBoxColumn,
            this.componentGuidDataGridViewTextBoxColumn,
            this.ComponentGroup,
            this.Reference,
            this.componentCountDataGridViewTextBoxColumn});
            this.dataGridViewComponents.DataSource = this.productComponentBindingSource;
            this.dataGridViewComponents.EnableHeadersVisualStyles = false;
            this.dataGridViewComponents.Location = new System.Drawing.Point(15, 20);
            this.dataGridViewComponents.Name = "dataGridViewComponents";
            this.dataGridViewComponents.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewComponents.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewComponents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewComponents.Size = new System.Drawing.Size(700, 359);
            this.dataGridViewComponents.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Наименование продукта:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(181, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(574, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата модификации:";
            // 
            // productComponentBindingSource
            // 
            this.productComponentBindingSource.DataSource = typeof(DataModels.ProductComponent);
            // 
            // productComponentGuidDataGridViewTextBoxColumn
            // 
            this.productComponentGuidDataGridViewTextBoxColumn.DataPropertyName = "ProductComponentGuid";
            this.productComponentGuidDataGridViewTextBoxColumn.HeaderText = "ProductComponentGuid";
            this.productComponentGuidDataGridViewTextBoxColumn.Name = "productComponentGuidDataGridViewTextBoxColumn";
            this.productComponentGuidDataGridViewTextBoxColumn.Visible = false;
            // 
            // productGuidDataGridViewTextBoxColumn
            // 
            this.productGuidDataGridViewTextBoxColumn.DataPropertyName = "ProductGuid";
            this.productGuidDataGridViewTextBoxColumn.HeaderText = "ProductGuid";
            this.productGuidDataGridViewTextBoxColumn.Name = "productGuidDataGridViewTextBoxColumn";
            this.productGuidDataGridViewTextBoxColumn.Visible = false;
            // 
            // componentGuidDataGridViewTextBoxColumn
            // 
            this.componentGuidDataGridViewTextBoxColumn.DataPropertyName = "ComponentGuid";
            this.componentGuidDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.componentGuidDataGridViewTextBoxColumn.Name = "componentGuidDataGridViewTextBoxColumn";
            this.componentGuidDataGridViewTextBoxColumn.Width = 330;
            // 
            // ComponentGroup
            // 
            this.ComponentGroup.HeaderText = "Группа компонентов";
            this.ComponentGroup.Name = "ComponentGroup";
            this.ComponentGroup.Width = 150;
            // 
            // Reference
            // 
            this.Reference.HeaderText = "Референс";
            this.Reference.Name = "Reference";
            this.Reference.Width = 120;
            // 
            // componentCountDataGridViewTextBoxColumn
            // 
            this.componentCountDataGridViewTextBoxColumn.DataPropertyName = "ComponentCount";
            this.componentCountDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.componentCountDataGridViewTextBoxColumn.Name = "componentCountDataGridViewTextBoxColumn";
            this.componentCountDataGridViewTextBoxColumn.Width = 80;
            // 
            // componentBindingSource
            // 
            this.componentBindingSource.DataSource = typeof(DataModels.Component);
            // 
            // ProductComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 502);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductComponentForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Состав оборудования продукта";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComponents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productComponentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddComponent;
        private System.Windows.Forms.DataGridView dataGridViewComponents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddAssembly;
        private System.Windows.Forms.BindingSource productComponentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productComponentGuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productGuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentGuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource componentBindingSource;
    }
}