namespace QuanLyChanNuoi
{
    partial class frm_CareLOG
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.logIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.careDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carelogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._QuanLyChanNuoi_TranThanhTri_DataSet = new QuanLyChanNuoi._QuanLyChanNuoi_TranThanhTri_DataSet();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_ADD = new System.Windows.Forms.Button();
            this.CareDate_Text = new System.Windows.Forms.TextBox();
            this.LogID_Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Desciption_Text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Animal_Name = new System.Windows.Forms.ComboBox();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._QuanLyChanNuoi_TranThanhTri_DataSet1 = new QuanLyChanNuoi._QuanLyChanNuoi_TranThanhTri_DataSet1();
            this.cmb_Staff_Name = new System.Windows.Forms.ComboBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._QuanLyChanNuoi_TranThanhTri_DataSet2 = new QuanLyChanNuoi._QuanLyChanNuoi_TranThanhTri_DataSet2();
            this.carelogTableAdapter = new QuanLyChanNuoi._QuanLyChanNuoi_TranThanhTri_DataSetTableAdapters.CarelogTableAdapter();
            this.animalTableAdapter = new QuanLyChanNuoi._QuanLyChanNuoi_TranThanhTri_DataSet1TableAdapters.AnimalTableAdapter();
            this.staffTableAdapter = new QuanLyChanNuoi._QuanLyChanNuoi_TranThanhTri_DataSet2TableAdapters.StaffTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carelogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._QuanLyChanNuoi_TranThanhTri_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._QuanLyChanNuoi_TranThanhTri_DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._QuanLyChanNuoi_TranThanhTri_DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logIDDataGridViewTextBoxColumn,
            this.animalIDDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn,
            this.careDateDataGridViewTextBoxColumn,
            this.decriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carelogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(138, 424);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 174);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Staff_CellContentClick);
            // 
            // logIDDataGridViewTextBoxColumn
            // 
            this.logIDDataGridViewTextBoxColumn.DataPropertyName = "LogID";
            this.logIDDataGridViewTextBoxColumn.HeaderText = "LogID";
            this.logIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.logIDDataGridViewTextBoxColumn.Name = "logIDDataGridViewTextBoxColumn";
            this.logIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // animalIDDataGridViewTextBoxColumn
            // 
            this.animalIDDataGridViewTextBoxColumn.DataPropertyName = "AnimalID";
            this.animalIDDataGridViewTextBoxColumn.HeaderText = "AnimalID";
            this.animalIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.animalIDDataGridViewTextBoxColumn.Name = "animalIDDataGridViewTextBoxColumn";
            this.animalIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // careDateDataGridViewTextBoxColumn
            // 
            this.careDateDataGridViewTextBoxColumn.DataPropertyName = "CareDate";
            this.careDateDataGridViewTextBoxColumn.HeaderText = "CareDate";
            this.careDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.careDateDataGridViewTextBoxColumn.Name = "careDateDataGridViewTextBoxColumn";
            this.careDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // decriptionDataGridViewTextBoxColumn
            // 
            this.decriptionDataGridViewTextBoxColumn.DataPropertyName = "Decription";
            this.decriptionDataGridViewTextBoxColumn.HeaderText = "Decription";
            this.decriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.decriptionDataGridViewTextBoxColumn.Name = "decriptionDataGridViewTextBoxColumn";
            this.decriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // carelogBindingSource
            // 
            this.carelogBindingSource.DataMember = "Carelog";
            this.carelogBindingSource.DataSource = this._QuanLyChanNuoi_TranThanhTri_DataSet;
            // 
            // _QuanLyChanNuoi_TranThanhTri_DataSet
            // 
            this._QuanLyChanNuoi_TranThanhTri_DataSet.DataSetName = "_QuanLyChanNuoi_TranThanhTri_DataSet";
            this._QuanLyChanNuoi_TranThanhTri_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_xoa
            // 
            this.button_xoa.Location = new System.Drawing.Point(613, 384);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(75, 23);
            this.button_xoa.TabIndex = 17;
            this.button_xoa.Text = "DEL";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(483, 384);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 18;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_ADD
            // 
            this.button_ADD.Location = new System.Drawing.Point(353, 384);
            this.button_ADD.Name = "button_ADD";
            this.button_ADD.Size = new System.Drawing.Size(75, 23);
            this.button_ADD.TabIndex = 19;
            this.button_ADD.Text = "ADD";
            this.button_ADD.UseVisualStyleBackColor = true;
            this.button_ADD.Click += new System.EventHandler(this.button_ADD_Click);
            // 
            // CareDate_Text
            // 
            this.CareDate_Text.Location = new System.Drawing.Point(238, 228);
            this.CareDate_Text.Name = "CareDate_Text";
            this.CareDate_Text.Size = new System.Drawing.Size(362, 22);
            this.CareDate_Text.TabIndex = 12;
            // 
            // LogID_Text
            // 
            this.LogID_Text.Location = new System.Drawing.Point(238, 78);
            this.LogID_Text.Name = "LogID_Text";
            this.LogID_Text.Size = new System.Drawing.Size(362, 22);
            this.LogID_Text.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "CareDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Staff Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Animal Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "LogID";
            // 
            // Desciption_Text
            // 
            this.Desciption_Text.Location = new System.Drawing.Point(238, 278);
            this.Desciption_Text.Multiline = true;
            this.Desciption_Text.Name = "Desciption_Text";
            this.Desciption_Text.Size = new System.Drawing.Size(362, 69);
            this.Desciption_Text.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Description";
            // 
            // cmb_Animal_Name
            // 
            this.cmb_Animal_Name.DataSource = this.animalBindingSource;
            this.cmb_Animal_Name.DisplayMember = "Name";
            this.cmb_Animal_Name.FormattingEnabled = true;
            this.cmb_Animal_Name.Location = new System.Drawing.Point(238, 126);
            this.cmb_Animal_Name.Name = "cmb_Animal_Name";
            this.cmb_Animal_Name.Size = new System.Drawing.Size(362, 24);
            this.cmb_Animal_Name.TabIndex = 23;
            this.cmb_Animal_Name.ValueMember = "AnimalID";
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this._QuanLyChanNuoi_TranThanhTri_DataSet1;
            // 
            // _QuanLyChanNuoi_TranThanhTri_DataSet1
            // 
            this._QuanLyChanNuoi_TranThanhTri_DataSet1.DataSetName = "_QuanLyChanNuoi_TranThanhTri_DataSet1";
            this._QuanLyChanNuoi_TranThanhTri_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_Staff_Name
            // 
            this.cmb_Staff_Name.DataSource = this.staffBindingSource;
            this.cmb_Staff_Name.DisplayMember = "Fullname";
            this.cmb_Staff_Name.FormattingEnabled = true;
            this.cmb_Staff_Name.Location = new System.Drawing.Point(238, 176);
            this.cmb_Staff_Name.Name = "cmb_Staff_Name";
            this.cmb_Staff_Name.Size = new System.Drawing.Size(362, 24);
            this.cmb_Staff_Name.TabIndex = 24;
            this.cmb_Staff_Name.ValueMember = "StaffID";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this._QuanLyChanNuoi_TranThanhTri_DataSet2;
            // 
            // _QuanLyChanNuoi_TranThanhTri_DataSet2
            // 
            this._QuanLyChanNuoi_TranThanhTri_DataSet2.DataSetName = "_QuanLyChanNuoi_TranThanhTri_DataSet2";
            this._QuanLyChanNuoi_TranThanhTri_DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carelogTableAdapter
            // 
            this.carelogTableAdapter.ClearBeforeFill = true;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(315, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(307, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Thông tin Chăm sóc động vật";
            // 
            // frm_CareLOG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 649);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_Staff_Name);
            this.Controls.Add(this.cmb_Animal_Name);
            this.Controls.Add(this.Desciption_Text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_ADD);
            this.Controls.Add(this.CareDate_Text);
            this.Controls.Add(this.LogID_Text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_CareLOG";
            this.Text = "CareLOG";
            this.Load += new System.EventHandler(this.frm_CareLOG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carelogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._QuanLyChanNuoi_TranThanhTri_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._QuanLyChanNuoi_TranThanhTri_DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._QuanLyChanNuoi_TranThanhTri_DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_ADD;
        private System.Windows.Forms.TextBox CareDate_Text;
        private System.Windows.Forms.TextBox LogID_Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Desciption_Text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Animal_Name;
        private System.Windows.Forms.ComboBox cmb_Staff_Name;
        private _QuanLyChanNuoi_TranThanhTri_DataSet _QuanLyChanNuoi_TranThanhTri_DataSet;
        private System.Windows.Forms.BindingSource carelogBindingSource;
        private _QuanLyChanNuoi_TranThanhTri_DataSetTableAdapters.CarelogTableAdapter carelogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn logIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn careDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decriptionDataGridViewTextBoxColumn;
        private _QuanLyChanNuoi_TranThanhTri_DataSet1 _QuanLyChanNuoi_TranThanhTri_DataSet1;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private _QuanLyChanNuoi_TranThanhTri_DataSet1TableAdapters.AnimalTableAdapter animalTableAdapter;
        private _QuanLyChanNuoi_TranThanhTri_DataSet2 _QuanLyChanNuoi_TranThanhTri_DataSet2;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private _QuanLyChanNuoi_TranThanhTri_DataSet2TableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.Label label6;
    }
}