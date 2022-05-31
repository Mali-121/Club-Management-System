namespace Assignment
{
    partial class ClubDetail
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
            this.lblCName = new System.Windows.Forms.Label();
            this.grpDscptn = new System.Windows.Forms.GroupBox();
            this.lblDscptn = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubDBDataSet = new Assignment.clubDBDataSet();
            this.activityTableAdapter = new Assignment.clubDBDataSetTableAdapters.activityTableAdapter();
            this.grpDscptn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCName.Location = new System.Drawing.Point(54, 77);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(0, 37);
            this.lblCName.TabIndex = 0;
            // 
            // grpDscptn
            // 
            this.grpDscptn.Controls.Add(this.lblDscptn);
            this.grpDscptn.Location = new System.Drawing.Point(50, 145);
            this.grpDscptn.Name = "grpDscptn";
            this.grpDscptn.Size = new System.Drawing.Size(854, 105);
            this.grpDscptn.TabIndex = 1;
            this.grpDscptn.TabStop = false;
            this.grpDscptn.Text = "Club Description";
            // 
            // lblDscptn
            // 
            this.lblDscptn.AutoSize = true;
            this.lblDscptn.Location = new System.Drawing.Point(22, 42);
            this.lblDscptn.Name = "lblDscptn";
            this.lblDscptn.Size = new System.Drawing.Size(0, 25);
            this.lblDscptn.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(786, 273);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(118, 36);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(786, 584);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvActivities
            // 
            this.dgvActivities.AllowUserToAddRows = false;
            this.dgvActivities.AllowUserToDeleteRows = false;
            this.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivities.Location = new System.Drawing.Point(50, 342);
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.ReadOnly = true;
            this.dgvActivities.RowHeadersWidth = 82;
            this.dgvActivities.RowTemplate.Height = 33;
            this.dgvActivities.Size = new System.Drawing.Size(854, 220);
            this.dgvActivities.TabIndex = 4;
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataMember = "activity";
            this.activityBindingSource.DataSource = this.clubDBDataSet;
            // 
            // clubDBDataSet
            // 
            this.clubDBDataSet.DataSetName = "clubDBDataSet";
            this.clubDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activityTableAdapter
            // 
            this.activityTableAdapter.ClearBeforeFill = true;
            // 
            // ClubDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 652);
            this.Controls.Add(this.dgvActivities);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.grpDscptn);
            this.Controls.Add(this.lblCName);
            this.Name = "ClubDetail";
            this.Text = "Club Details";
            this.Load += new System.EventHandler(this.Club_detail_Load);
            this.grpDscptn.ResumeLayout(false);
            this.grpDscptn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.GroupBox grpDscptn;
        private System.Windows.Forms.Label lblDscptn;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvActivities;
        private clubDBDataSet clubDBDataSet;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private clubDBDataSetTableAdapters.activityTableAdapter activityTableAdapter;
    }
}

