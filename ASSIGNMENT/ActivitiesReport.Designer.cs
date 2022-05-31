namespace Assignment
{
    partial class ActivitiesReport
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
            this.dgvActivityReport = new System.Windows.Forms.DataGridView();
            this.activityIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achievementsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubDBDataSet4 = new Assignment.clubDBDataSet4();
            this.activityTableAdapter = new Assignment.clubDBDataSet4TableAdapters.activityTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDBDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActivityReport
            // 
            this.dgvActivityReport.AutoGenerateColumns = false;
            this.dgvActivityReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivityReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activityIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.achievementsDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.clubIDDataGridViewTextBoxColumn});
            this.dgvActivityReport.DataSource = this.activityBindingSource;
            this.dgvActivityReport.Location = new System.Drawing.Point(32, 118);
            this.dgvActivityReport.Name = "dgvActivityReport";
            this.dgvActivityReport.RowHeadersWidth = 51;
            this.dgvActivityReport.RowTemplate.Height = 24;
            this.dgvActivityReport.Size = new System.Drawing.Size(737, 342);
            this.dgvActivityReport.TabIndex = 0;
            // 
            // activityIdDataGridViewTextBoxColumn
            // 
            this.activityIdDataGridViewTextBoxColumn.DataPropertyName = "activityId";
            this.activityIdDataGridViewTextBoxColumn.HeaderText = "activityId";
            this.activityIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.activityIdDataGridViewTextBoxColumn.Name = "activityIdDataGridViewTextBoxColumn";
            this.activityIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.activityIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // achievementsDataGridViewTextBoxColumn
            // 
            this.achievementsDataGridViewTextBoxColumn.DataPropertyName = "achievements";
            this.achievementsDataGridViewTextBoxColumn.HeaderText = "achievements";
            this.achievementsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.achievementsDataGridViewTextBoxColumn.Name = "achievementsDataGridViewTextBoxColumn";
            this.achievementsDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // clubIDDataGridViewTextBoxColumn
            // 
            this.clubIDDataGridViewTextBoxColumn.DataPropertyName = "clubID";
            this.clubIDDataGridViewTextBoxColumn.HeaderText = "clubID";
            this.clubIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clubIDDataGridViewTextBoxColumn.Name = "clubIDDataGridViewTextBoxColumn";
            this.clubIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataMember = "activity";
            this.activityBindingSource.DataSource = this.clubDBDataSet4;
            // 
            // clubDBDataSet4
            // 
            this.clubDBDataSet4.DataSetName = "clubDBDataSet4";
            this.clubDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activityTableAdapter
            // 
            this.activityTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Format: month day year";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDateTime
            // 
            this.txtDateTime.Location = new System.Drawing.Point(183, 49);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(179, 22);
            this.txtDateTime.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Insert date:";
            // 
            // ActivitiesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 506);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvActivityReport);
            this.Name = "ActivitiesReport";
            this.Text = "ActivitiesReport";
            this.Load += new System.EventHandler(this.ActivitiesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDBDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActivityReport;
        private clubDBDataSet4 clubDBDataSet4;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private clubDBDataSet4TableAdapters.activityTableAdapter activityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn achievementsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.Label label3;
    }
}