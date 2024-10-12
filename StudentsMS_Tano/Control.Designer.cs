namespace StudentsMS_Tano
{
    partial class Control
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
            this.idd = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tblAssignedSubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBStudentMS_TanoDataSet2 = new StudentsMS_Tano.DBStudentMS_TanoDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tblCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBStudentMS_TanoDataSet1 = new StudentsMS_Tano.DBStudentMS_TanoDataSet1();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tblCourseTableAdapter = new StudentsMS_Tano.DBStudentMS_TanoDataSet1TableAdapters.tblCourseTableAdapter();
            this.tblAssignedSubjectTableAdapter = new StudentsMS_Tano.DBStudentMS_TanoDataSet2TableAdapters.tblAssignedSubjectTableAdapter();
            this.dBStudentMS_TanoDataSet3 = new StudentsMS_Tano.DBStudentMS_TanoDataSet3();
            this.tblSubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSubjectTableAdapter = new StudentsMS_Tano.DBStudentMS_TanoDataSet3TableAdapters.tblSubjectTableAdapter();
            this.subjects = new System.Windows.Forms.DataGridView();
            this.validatee = new System.Windows.Forms.TextBox();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAssignedSubjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBStudentMS_TanoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBStudentMS_TanoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBStudentMS_TanoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.validatee);
            this.panel1.Controls.Add(this.subjects);
            this.panel1.Controls.Add(this.idd);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(3, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 466);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // idd
            // 
            this.idd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idd.Location = new System.Drawing.Point(22, 431);
            this.idd.Name = "idd";
            this.idd.Size = new System.Drawing.Size(43, 26);
            this.idd.TabIndex = 15;
            this.idd.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(211, 434);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(292, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tblAssignedSubjectBindingSource
            // 
            this.tblAssignedSubjectBindingSource.DataMember = "tblAssignedSubject";
            this.tblAssignedSubjectBindingSource.DataSource = this.dBStudentMS_TanoDataSet2;
            // 
            // dBStudentMS_TanoDataSet2
            // 
            this.dBStudentMS_TanoDataSet2.DataSetName = "DBStudentMS_TanoDataSet2";
            this.dBStudentMS_TanoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(292, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Subjects";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Birth Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Middle Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tblCourseBindingSource;
            this.comboBox1.DisplayMember = "course_name";
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 26);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "course_id";
            // 
            // tblCourseBindingSource
            // 
            this.tblCourseBindingSource.DataMember = "tblCourse";
            this.tblCourseBindingSource.DataSource = this.dBStudentMS_TanoDataSet1;
            // 
            // dBStudentMS_TanoDataSet1
            // 
            this.dBStudentMS_TanoDataSet1.DataSetName = "DBStudentMS_TanoDataSet1";
            this.dBStudentMS_TanoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 138);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(117, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 26);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(117, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(117, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 26);
            this.textBox1.TabIndex = 0;
            // 
            // tblCourseTableAdapter
            // 
            this.tblCourseTableAdapter.ClearBeforeFill = true;
            // 
            // tblAssignedSubjectTableAdapter
            // 
            this.tblAssignedSubjectTableAdapter.ClearBeforeFill = true;
            // 
            // dBStudentMS_TanoDataSet3
            // 
            this.dBStudentMS_TanoDataSet3.DataSetName = "DBStudentMS_TanoDataSet3";
            this.dBStudentMS_TanoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSubjectBindingSource
            // 
            this.tblSubjectBindingSource.DataMember = "tblSubject";
            this.tblSubjectBindingSource.DataSource = this.dBStudentMS_TanoDataSet3;
            // 
            // tblSubjectTableAdapter
            // 
            this.tblSubjectTableAdapter.ClearBeforeFill = true;
            // 
            // subjects
            // 
            this.subjects.AllowUserToAddRows = false;
            this.subjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.subjects.BackgroundColor = System.Drawing.Color.LightBlue;
            this.subjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.Subject_Name});
            this.subjects.Location = new System.Drawing.Point(22, 236);
            this.subjects.Name = "subjects";
            this.subjects.RowHeadersVisible = false;
            this.subjects.Size = new System.Drawing.Size(345, 189);
            this.subjects.TabIndex = 16;
            this.subjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjects_CellContentClick);
            // 
            // validatee
            // 
            this.validatee.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validatee.Location = new System.Drawing.Point(71, 431);
            this.validatee.Name = "validatee";
            this.validatee.Size = new System.Drawing.Size(43, 26);
            this.validatee.TabIndex = 17;
            this.validatee.Visible = false;
            // 
            // no
            // 
            this.no.HeaderText = "no";
            this.no.Name = "no";
            this.no.Visible = false;
            // 
            // Subject_Name
            // 
            this.Subject_Name.HeaderText = "Subject Name";
            this.Subject_Name.Name = "Subject_Name";
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(393, 529);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Control";
            this.Text = "Control";
            this.Load += new System.EventHandler(this.Control_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAssignedSubjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBStudentMS_TanoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBStudentMS_TanoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBStudentMS_TanoDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DBStudentMS_TanoDataSet1 dBStudentMS_TanoDataSet1;
        private System.Windows.Forms.BindingSource tblCourseBindingSource;
        private DBStudentMS_TanoDataSet1TableAdapters.tblCourseTableAdapter tblCourseTableAdapter;
        private DBStudentMS_TanoDataSet2 dBStudentMS_TanoDataSet2;
        private System.Windows.Forms.BindingSource tblAssignedSubjectBindingSource;
        private DBStudentMS_TanoDataSet2TableAdapters.tblAssignedSubjectTableAdapter tblAssignedSubjectTableAdapter;
        private System.Windows.Forms.TextBox idd;
        private DBStudentMS_TanoDataSet3 dBStudentMS_TanoDataSet3;
        private System.Windows.Forms.BindingSource tblSubjectBindingSource;
        private DBStudentMS_TanoDataSet3TableAdapters.tblSubjectTableAdapter tblSubjectTableAdapter;
        private System.Windows.Forms.DataGridView subjects;
        private System.Windows.Forms.TextBox validatee;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject_Name;
    }
}