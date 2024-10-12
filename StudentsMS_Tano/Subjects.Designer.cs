namespace StudentsMS_Tano
{
    partial class Subjects
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iddtxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.subjectnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBStudentMS_TanoDataSet = new StudentsMS_Tano.DBStudentMS_TanoDataSet();
            this.tblSubjectTableAdapter = new StudentsMS_Tano.DBStudentMS_TanoDataSetTableAdapters.tblSubjectTableAdapter();
            this.validd = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBStudentMS_TanoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.validd);
            this.panel1.Controls.Add(this.iddtxt);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(3, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 236);
            this.panel1.TabIndex = 0;
            // 
            // iddtxt
            // 
            this.iddtxt.Location = new System.Drawing.Point(19, 210);
            this.iddtxt.Name = "iddtxt";
            this.iddtxt.Size = new System.Drawing.Size(62, 20);
            this.iddtxt.TabIndex = 2;
            this.iddtxt.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(290, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectnoDataGridViewTextBoxColumn,
            this.subjectnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblSubjectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(346, 167);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // subjectnoDataGridViewTextBoxColumn
            // 
            this.subjectnoDataGridViewTextBoxColumn.DataPropertyName = "subject_no";
            this.subjectnoDataGridViewTextBoxColumn.HeaderText = "subject_no";
            this.subjectnoDataGridViewTextBoxColumn.Name = "subjectnoDataGridViewTextBoxColumn";
            this.subjectnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectnoDataGridViewTextBoxColumn.Visible = false;
            // 
            // subjectnameDataGridViewTextBoxColumn
            // 
            this.subjectnameDataGridViewTextBoxColumn.DataPropertyName = "subject_name";
            this.subjectnameDataGridViewTextBoxColumn.HeaderText = "Subject Name";
            this.subjectnameDataGridViewTextBoxColumn.Name = "subjectnameDataGridViewTextBoxColumn";
            // 
            // tblSubjectBindingSource
            // 
            this.tblSubjectBindingSource.DataMember = "tblSubject";
            this.tblSubjectBindingSource.DataSource = this.dBStudentMS_TanoDataSet;
            // 
            // dBStudentMS_TanoDataSet
            // 
            this.dBStudentMS_TanoDataSet.DataSetName = "DBStudentMS_TanoDataSet";
            this.dBStudentMS_TanoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSubjectTableAdapter
            // 
            this.tblSubjectTableAdapter.ClearBeforeFill = true;
            // 
            // validd
            // 
            this.validd.Location = new System.Drawing.Point(87, 210);
            this.validd.Name = "validd";
            this.validd.Size = new System.Drawing.Size(62, 20);
            this.validd.TabIndex = 3;
            this.validd.Visible = false;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(390, 285);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Subjects";
            this.Text = "Subjects";
            this.Load += new System.EventHandler(this.Subjects_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBStudentMS_TanoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBStudentMS_TanoDataSet dBStudentMS_TanoDataSet;
        private System.Windows.Forms.BindingSource tblSubjectBindingSource;
        private DBStudentMS_TanoDataSetTableAdapters.tblSubjectTableAdapter tblSubjectTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox iddtxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox validd;
    }
}