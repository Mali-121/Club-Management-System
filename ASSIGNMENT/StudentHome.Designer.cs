namespace Assignment
{
    partial class StudentHome
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presidentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vicePresidentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.representativeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registeredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clubDBDataSet5 = new Assignment.clubDBDataSet5();
            this.clubInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubDBDataSet2 = new Assignment.clubDBDataSet2();
            this.clubInfoTableAdapter = new Assignment.clubDBDataSet2TableAdapters.clubInfoTableAdapter();
            this.clubInfoTableAdapter1 = new Assignment.clubDBDataSet5TableAdapters.clubInfoTableAdapter();
            this.clubDBDataSet6 = new Assignment.clubDBDataSet6();
            this.clubInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clubInfoTableAdapter2 = new Assignment.clubDBDataSet6TableAdapters.clubInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubInfoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.Location = new System.Drawing.Point(770, 466);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 56);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblIdentity
            // 
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentity.Location = new System.Drawing.Point(106, 45);
            this.lblIdentity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(0, 51);
            this.lblIdentity.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.presidentDataGridViewTextBoxColumn,
            this.vicePresidentDataGridViewTextBoxColumn,
            this.representativeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.registeredDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clubInfoBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(51, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(846, 297);
            this.dataGridView1.TabIndex = 14;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // presidentDataGridViewTextBoxColumn
            // 
            this.presidentDataGridViewTextBoxColumn.DataPropertyName = "president";
            this.presidentDataGridViewTextBoxColumn.HeaderText = "president";
            this.presidentDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.presidentDataGridViewTextBoxColumn.Name = "presidentDataGridViewTextBoxColumn";
            this.presidentDataGridViewTextBoxColumn.ReadOnly = true;
            this.presidentDataGridViewTextBoxColumn.Width = 200;
            // 
            // vicePresidentDataGridViewTextBoxColumn
            // 
            this.vicePresidentDataGridViewTextBoxColumn.DataPropertyName = "vicePresident";
            this.vicePresidentDataGridViewTextBoxColumn.HeaderText = "vicePresident";
            this.vicePresidentDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.vicePresidentDataGridViewTextBoxColumn.Name = "vicePresidentDataGridViewTextBoxColumn";
            this.vicePresidentDataGridViewTextBoxColumn.ReadOnly = true;
            this.vicePresidentDataGridViewTextBoxColumn.Width = 200;
            // 
            // representativeDataGridViewTextBoxColumn
            // 
            this.representativeDataGridViewTextBoxColumn.DataPropertyName = "representative";
            this.representativeDataGridViewTextBoxColumn.HeaderText = "representative";
            this.representativeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.representativeDataGridViewTextBoxColumn.Name = "representativeDataGridViewTextBoxColumn";
            this.representativeDataGridViewTextBoxColumn.ReadOnly = true;
            this.representativeDataGridViewTextBoxColumn.Width = 200;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // registeredDateDataGridViewTextBoxColumn
            // 
            this.registeredDateDataGridViewTextBoxColumn.DataPropertyName = "registeredDate";
            this.registeredDateDataGridViewTextBoxColumn.HeaderText = "registeredDate";
            this.registeredDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.registeredDateDataGridViewTextBoxColumn.Name = "registeredDateDataGridViewTextBoxColumn";
            this.registeredDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.registeredDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // clubInfoBindingSource1
            // 
            this.clubInfoBindingSource1.DataMember = "clubInfo";
            this.clubInfoBindingSource1.DataSource = this.clubDBDataSet5;
            // 
            // clubDBDataSet5
            // 
            this.clubDBDataSet5.DataSetName = "clubDBDataSet5";
            this.clubDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clubInfoBindingSource
            // 
            this.clubInfoBindingSource.DataMember = "clubInfo";
            this.clubInfoBindingSource.DataSource = this.clubDBDataSet2;
            // 
            // clubDBDataSet2
            // 
            this.clubDBDataSet2.DataSetName = "clubDBDataSet2";
            this.clubDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clubInfoTableAdapter
            // 
            this.clubInfoTableAdapter.ClearBeforeFill = true;
            // 
            // clubInfoTableAdapter1
            // 
            this.clubInfoTableAdapter1.ClearBeforeFill = true;
            // 
            // clubDBDataSet6
            // 
            this.clubDBDataSet6.DataSetName = "clubDBDataSet6";
            this.clubDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clubInfoBindingSource2
            // 
            this.clubInfoBindingSource2.DataMember = "clubInfo";
            this.clubInfoBindingSource2.DataSource = this.clubDBDataSet6;
            // 
            // clubInfoTableAdapter2
            // 
            this.clubInfoTableAdapter2.ClearBeforeFill = true;
            // 
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 545);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblIdentity);
            this.Controls.Add(this.btnCancel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentHome";
            this.Text = "StudentHome";
            this.Load += new System.EventHandler(this.StudentHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubInfoBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private clubDBDataSet2 clubDBDataSet2;
        private System.Windows.Forms.BindingSource clubInfoBindingSource;
        private clubDBDataSet2TableAdapters.clubInfoTableAdapter clubInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presidentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vicePresidentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn representativeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registeredDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private clubDBDataSet5 clubDBDataSet5;
        private System.Windows.Forms.BindingSource clubInfoBindingSource1;
        private clubDBDataSet5TableAdapters.clubInfoTableAdapter clubInfoTableAdapter1;
        private clubDBDataSet6 clubDBDataSet6;
        private System.Windows.Forms.BindingSource clubInfoBindingSource2;
        private clubDBDataSet6TableAdapters.clubInfoTableAdapter clubInfoTableAdapter2;
    }
}