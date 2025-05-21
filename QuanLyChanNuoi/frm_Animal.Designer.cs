namespace QuanLyChanNuoi
{
    partial class frm_Animal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AnimalID_Text = new System.Windows.Forms.TextBox();
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.Species_Text = new System.Windows.Forms.TextBox();
            this.Breed = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.TextBox();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.animalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyChanNuoi1DataSet = new QuanLyChanNuoi.QuanLyChanNuoi1DataSet();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.animalTableAdapter = new QuanLyChanNuoi.QuanLyChanNuoi1DataSetTableAdapters.AnimalTableAdapter();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.cmb_PenID = new System.Windows.Forms.ComboBox();
            this.penBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyChanNuoi1DataSet1 = new QuanLyChanNuoi.QuanLyChanNuoi1DataSet1();
            this.penTableAdapter = new QuanLyChanNuoi.QuanLyChanNuoi1DataSet1TableAdapters.PenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyChanNuoi1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyChanNuoi1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AnimalID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Species";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Breed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Weight";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "PenID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 301);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 7;
            // 
            // AnimalID_Text
            // 
            this.AnimalID_Text.Location = new System.Drawing.Point(140, 16);
            this.AnimalID_Text.Margin = new System.Windows.Forms.Padding(2);
            this.AnimalID_Text.Name = "AnimalID_Text";
            this.AnimalID_Text.Size = new System.Drawing.Size(151, 20);
            this.AnimalID_Text.TabIndex = 8;
            // 
            // Name_Text
            // 
            this.Name_Text.Location = new System.Drawing.Point(140, 45);
            this.Name_Text.Margin = new System.Windows.Forms.Padding(2);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(151, 20);
            this.Name_Text.TabIndex = 9;
            // 
            // Species_Text
            // 
            this.Species_Text.Location = new System.Drawing.Point(140, 80);
            this.Species_Text.Margin = new System.Windows.Forms.Padding(2);
            this.Species_Text.Name = "Species_Text";
            this.Species_Text.Size = new System.Drawing.Size(151, 20);
            this.Species_Text.TabIndex = 10;
            // 
            // Breed
            // 
            this.Breed.Location = new System.Drawing.Point(140, 115);
            this.Breed.Margin = new System.Windows.Forms.Padding(2);
            this.Breed.Name = "Breed";
            this.Breed.Size = new System.Drawing.Size(151, 20);
            this.Breed.TabIndex = 11;
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(430, 51);
            this.Weight.Margin = new System.Windows.Forms.Padding(2);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(151, 20);
            this.Weight.TabIndex = 12;
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Location = new System.Drawing.Point(430, 16);
            this.radioButton_Male.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(48, 17);
            this.radioButton_Male.TabIndex = 14;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Male";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            this.radioButton_Male.CheckedChanged += new System.EventHandler(this.radioButton_Male_CheckedChanged);
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Location = new System.Drawing.Point(530, 16);
            this.radioButton_Female.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(59, 17);
            this.radioButton_Female.TabIndex = 15;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "Female";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.animalIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.speciesDataGridViewTextBoxColumn,
            this.breedDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.penIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.animalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 254);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(582, 102);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // animalIDDataGridViewTextBoxColumn
            // 
            this.animalIDDataGridViewTextBoxColumn.DataPropertyName = "AnimalID";
            this.animalIDDataGridViewTextBoxColumn.HeaderText = "AnimalID";
            this.animalIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.animalIDDataGridViewTextBoxColumn.Name = "animalIDDataGridViewTextBoxColumn";
            this.animalIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.animalIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // speciesDataGridViewTextBoxColumn
            // 
            this.speciesDataGridViewTextBoxColumn.DataPropertyName = "Species";
            this.speciesDataGridViewTextBoxColumn.HeaderText = "Species";
            this.speciesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.speciesDataGridViewTextBoxColumn.Name = "speciesDataGridViewTextBoxColumn";
            this.speciesDataGridViewTextBoxColumn.Width = 125;
            // 
            // breedDataGridViewTextBoxColumn
            // 
            this.breedDataGridViewTextBoxColumn.DataPropertyName = "Breed";
            this.breedDataGridViewTextBoxColumn.HeaderText = "Breed";
            this.breedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.breedDataGridViewTextBoxColumn.Name = "breedDataGridViewTextBoxColumn";
            this.breedDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.Width = 125;
            // 
            // penIDDataGridViewTextBoxColumn
            // 
            this.penIDDataGridViewTextBoxColumn.DataPropertyName = "PenID";
            this.penIDDataGridViewTextBoxColumn.HeaderText = "PenID";
            this.penIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.penIDDataGridViewTextBoxColumn.Name = "penIDDataGridViewTextBoxColumn";
            this.penIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this.quanLyChanNuoi1DataSet;
            // 
            // quanLyChanNuoi1DataSet
            // 
            this.quanLyChanNuoi1DataSet.DataSetName = "QuanLyChanNuoi1DataSet";
            this.quanLyChanNuoi1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(140, 171);
            this.button_Add.Margin = new System.Windows.Forms.Padding(2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(56, 19);
            this.button_Add.TabIndex = 17;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(234, 171);
            this.button_update.Margin = new System.Windows.Forms.Padding(2);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(56, 19);
            this.button_update.TabIndex = 18;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(317, 171);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(56, 19);
            this.button_Delete.TabIndex = 19;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(404, 171);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(56, 19);
            this.btn_Menu.TabIndex = 20;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            // 
            // cmb_PenID
            // 
            this.cmb_PenID.DataSource = this.penBindingSource;
            this.cmb_PenID.DisplayMember = "PenID";
            this.cmb_PenID.FormattingEnabled = true;
            this.cmb_PenID.Location = new System.Drawing.Point(430, 86);
            this.cmb_PenID.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_PenID.Name = "cmb_PenID";
            this.cmb_PenID.Size = new System.Drawing.Size(151, 21);
            this.cmb_PenID.TabIndex = 21;
            this.cmb_PenID.ValueMember = "PenID";
            // 
            // penBindingSource
            // 
            this.penBindingSource.DataMember = "Pen";
            this.penBindingSource.DataSource = this.quanLyChanNuoi1DataSet1;
            // 
            // quanLyChanNuoi1DataSet1
            // 
            this.quanLyChanNuoi1DataSet1.DataSetName = "QuanLyChanNuoi1DataSet1";
            this.quanLyChanNuoi1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // penTableAdapter
            // 
            this.penTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cmb_PenID);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButton_Female);
            this.Controls.Add(this.radioButton_Male);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.Breed);
            this.Controls.Add(this.Species_Text);
            this.Controls.Add(this.Name_Text);
            this.Controls.Add(this.AnimalID_Text);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Animal";
            this.Text = "Animal";
            this.Load += new System.EventHandler(this.frm_Animal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyChanNuoi1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyChanNuoi1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AnimalID_Text;
        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.TextBox Species_Text;
        private System.Windows.Forms.TextBox Breed;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuanLyChanNuoi1DataSet quanLyChanNuoi1DataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private QuanLyChanNuoi1DataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.ComboBox cmb_PenID;
        private QuanLyChanNuoi1DataSet1 quanLyChanNuoi1DataSet1;
        private System.Windows.Forms.BindingSource penBindingSource;
        private QuanLyChanNuoi1DataSet1TableAdapters.PenTableAdapter penTableAdapter;
    }
}

