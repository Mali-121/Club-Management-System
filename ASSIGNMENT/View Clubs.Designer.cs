namespace Assignment
{
    partial class View_Clubs
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
            this.dgvViewClubs = new System.Windows.Forms.DataGridView();
            this.clubIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presidentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vicePresidentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.representativeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registeredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubDBDataSet1 = new Assignment.clubDBDataSet1();
            this.clubInfoTableAdapter = new Assignment.clubDBDataSet1TableAdapters.clubInfoTableAdapter();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUnarchive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewClubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewClubs
            // 
            this.dgvViewClubs.AllowUserToAddRows = false;
            this.dgvViewClubs.AutoGenerateColumns = false;
            this.dgvViewClubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewClubs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clubIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.presidentDataGridViewTextBoxColumn,
            this.vicePresidentDataGridViewTextBoxColumn,
            this.representativeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.registeredDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvViewClubs.DataSource = this.clubInfoBindingSource;
            this.dgvViewClubs.Location = new System.Drawing.Point(39, 48);
            this.dgvViewClubs.Name = "dgvViewClubs";
            this.dgvViewClubs.ReadOnly = true;
            this.dgvViewClubs.RowHeadersWidth = 82;
            this.dgvViewClubs.RowTemplate.Height = 33;
            this.dgvViewClubs.Size = new System.Drawing.Size(1052, 427);
            this.dgvViewClubs.TabIndex = 0;
            // 
            // clubIDDataGridViewTextBoxColumn
            // 
            this.clubIDDataGridViewTextBoxColumn.DataPropertyName = "clubID";
            this.clubIDDataGridViewTextBoxColumn.HeaderText = "clubID";
            this.clubIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.clubIDDataGridViewTextBoxColumn.Name = "clubIDDataGridViewTextBoxColumn";
            this.clubIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clubIDDataGridViewTextBoxColumn.Width = 200;
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
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 200;
            // 
            // clubInfoBindingSource
            // 
            this.clubInfoBindingSource.DataMember = "clubInfo";
            this.clubInfoBindingSource.DataSource = this.clubDBDataSet1;
            // 
            // clubDBDataSet1
            // 
            this.clubDBDataSet1.DataSetName = "clubDBDataSet1";
            this.clubDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clubInfoTableAdapter
            // 
            this.clubInfoTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.Location = new System.Drawing.Point(962, 548);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 56);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.BackColor = System.Drawing.Color.Gray;
            this.btnArchive.Location = new System.Drawing.Point(807, 548);
            this.btnArchive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(128, 56);
            this.btnArchive.TabIndex = 12;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = false;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gray;
            this.btnAdd.Location = new System.Drawing.Point(39, 548);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 56);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add Club";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gray;
            this.btnUpdate.Location = new System.Drawing.Point(194, 548);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(178, 56);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update Details";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUnarchive
            // 
            this.btnUnarchive.BackColor = System.Drawing.Color.Gray;
            this.btnUnarchive.Location = new System.Drawing.Point(656, 548);
            this.btnUnarchive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUnarchive.Name = "btnUnarchive";
            this.btnUnarchive.Size = new System.Drawing.Size(128, 56);
            this.btnUnarchive.TabIndex = 15;
            this.btnUnarchive.Text = "Unarchive";
            this.btnUnarchive.UseVisualStyleBackColor = false;
            this.btnUnarchive.Click += new System.EventHandler(this.btnUnarchive_Click);
            // 
            // View_Clubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 634);
            this.Controls.Add(this.btnUnarchive);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvViewClubs);
            this.Name = "View_Clubs";
            this.Text = "View Clubs";
            this.Load += new System.EventHandler(this.View_Clubs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewClubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewClubs;
        private clubDBDataSet1 clubDBDataSet1;
        private System.Windows.Forms.BindingSource clubInfoBindingSource;
        private clubDBDataSet1TableAdapters.clubInfoTableAdapter clubInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presidentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vicePresidentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn representativeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registeredDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUnarchive;
    }
}