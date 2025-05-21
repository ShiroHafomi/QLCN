namespace QuanLyChanNuoi
{
    partial class frm_FeedingSchedule
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
            this.Unit_Text = new System.Windows.Forms.TextBox();
            this.button_Menu = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.FeedID_Text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this._QuanLyChanNuoi_Minn_DataSet1 = new QuanLyChanNuoi._QuanLyChanNuoi_Minn_DataSet1();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new QuanLyChanNuoi._QuanLyChanNuoi_Minn_DataSet1TableAdapters.AnimalTableAdapter();
            this._QuanLyChanNuoi_Minn_DataSet2 = new QuanLyChanNuoi._QuanLyChanNuoi_Minn_DataSet2();
            this.feedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedTableAdapter = new QuanLyChanNuoi._QuanLyChanNuoi_Minn_DataSet2TableAdapters.FeedTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._QuanLyChanNuoi_Minn_DataSet3 = new QuanLyChanNuoi._QuanLyChanNuoi_Minn_DataSet3();
            this.feedingScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedingScheduleTableAdapter = new QuanLyChanNuoi._QuanLyChanNuoi_Minn_DataSet3TableAdapters.FeedingScheduleTableAdapter();
            this.scheduleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._QuanLyChanNuoi_Minn_DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._QuanLyChanNuoi_Minn_DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._QuanLyChanNuoi_Minn_DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedingScheduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Unit_Text
            // 
            this.Unit_Text.Location = new System.Drawing.Point(500, 130);
            this.Unit_Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Unit_Text.Name = "Unit_Text";
            this.Unit_Text.Size = new System.Drawing.Size(151, 20);
            this.Unit_Text.TabIndex = 54;
            // 
            // button_Menu
            // 
            this.button_Menu.Location = new System.Drawing.Point(465, 212);
            this.button_Menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(56, 19);
            this.button_Menu.TabIndex = 53;
            this.button_Menu.Text = "Menu";
            this.button_Menu.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(378, 212);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(56, 19);
            this.button_Delete.TabIndex = 52;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(295, 212);
            this.button_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(56, 19);
            this.button_Update.TabIndex = 51;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(201, 212);
            this.button_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(56, 19);
            this.button_Add.TabIndex = 50;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            // 
            // FeedID_Text
            // 
            this.FeedID_Text.Location = new System.Drawing.Point(200, 78);
            this.FeedID_Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FeedID_Text.Name = "FeedID_Text";
            this.FeedID_Text.Size = new System.Drawing.Size(151, 20);
            this.FeedID_Text.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Feed Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Feed ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Animal ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Schedule ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(500, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 55;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.animalBindingSource;
            this.comboBox1.DisplayMember = "AnimalID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(200, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 56;
            this.comboBox1.ValueMember = "Name";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.feedBindingSource;
            this.comboBox2.DisplayMember = "FeedID";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(200, 146);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 21);
            this.comboBox2.TabIndex = 57;
            this.comboBox2.ValueMember = "FeedName";
            // 
            // _QuanLyChanNuoi_Minn_DataSet1
            // 
            this._QuanLyChanNuoi_Minn_DataSet1.DataSetName = "_QuanLyChanNuoi_Minn_DataSet1";
            this._QuanLyChanNuoi_Minn_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this._QuanLyChanNuoi_Minn_DataSet1;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // _QuanLyChanNuoi_Minn_DataSet2
            // 
            this._QuanLyChanNuoi_Minn_DataSet2.DataSetName = "_QuanLyChanNuoi_Minn_DataSet2";
            this._QuanLyChanNuoi_Minn_DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedBindingSource
            // 
            this.feedBindingSource.DataMember = "Feed";
            this.feedBindingSource.DataSource = this._QuanLyChanNuoi_Minn_DataSet2;
            // 
            // feedTableAdapter
            // 
            this.feedTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scheduleIDDataGridViewTextBoxColumn,
            this.animalIDDataGridViewTextBoxColumn,
            this.feedIDDataGridViewTextBoxColumn,
            this.feedTimeDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.feedingScheduleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(112, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 74);
            this.dataGridView1.TabIndex = 58;
            // 
            // _QuanLyChanNuoi_Minn_DataSet3
            // 
            this._QuanLyChanNuoi_Minn_DataSet3.DataSetName = "_QuanLyChanNuoi_Minn_DataSet3";
            this._QuanLyChanNuoi_Minn_DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedingScheduleBindingSource
            // 
            this.feedingScheduleBindingSource.DataMember = "FeedingSchedule";
            this.feedingScheduleBindingSource.DataSource = this._QuanLyChanNuoi_Minn_DataSet3;
            // 
            // feedingScheduleTableAdapter
            // 
            this.feedingScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // scheduleIDDataGridViewTextBoxColumn
            // 
            this.scheduleIDDataGridViewTextBoxColumn.DataPropertyName = "ScheduleID";
            this.scheduleIDDataGridViewTextBoxColumn.HeaderText = "ScheduleID";
            this.scheduleIDDataGridViewTextBoxColumn.Name = "scheduleIDDataGridViewTextBoxColumn";
            this.scheduleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animalIDDataGridViewTextBoxColumn
            // 
            this.animalIDDataGridViewTextBoxColumn.DataPropertyName = "AnimalID";
            this.animalIDDataGridViewTextBoxColumn.HeaderText = "AnimalID";
            this.animalIDDataGridViewTextBoxColumn.Name = "animalIDDataGridViewTextBoxColumn";
            // 
            // feedIDDataGridViewTextBoxColumn
            // 
            this.feedIDDataGridViewTextBoxColumn.DataPropertyName = "FeedID";
            this.feedIDDataGridViewTextBoxColumn.HeaderText = "FeedID";
            this.feedIDDataGridViewTextBoxColumn.Name = "feedIDDataGridViewTextBoxColumn";
            // 
            // feedTimeDataGridViewTextBoxColumn
            // 
            this.feedTimeDataGridViewTextBoxColumn.DataPropertyName = "FeedTime";
            this.feedTimeDataGridViewTextBoxColumn.HeaderText = "FeedTime";
            this.feedTimeDataGridViewTextBoxColumn.Name = "feedTimeDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(290, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 27);
            this.label4.TabIndex = 59;
            this.label4.Text = "Feeding Schedule";
            // 
            // frm_FeedingSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Unit_Text);
            this.Controls.Add(this.button_Menu);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.FeedID_Text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_FeedingSchedule";
            this.Text = "frm_FeedingSchedule";
            this.Load += new System.EventHandler(this.frm_FeedingSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this._QuanLyChanNuoi_Minn_DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._QuanLyChanNuoi_Minn_DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._QuanLyChanNuoi_Minn_DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedingScheduleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Unit_Text;
        private System.Windows.Forms.Button button_Menu;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox FeedID_Text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private _QuanLyChanNuoi_Minn_DataSet1 _QuanLyChanNuoi_Minn_DataSet1;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private _QuanLyChanNuoi_Minn_DataSet1TableAdapters.AnimalTableAdapter animalTableAdapter;
        private _QuanLyChanNuoi_Minn_DataSet2 _QuanLyChanNuoi_Minn_DataSet2;
        private System.Windows.Forms.BindingSource feedBindingSource;
        private _QuanLyChanNuoi_Minn_DataSet2TableAdapters.FeedTableAdapter feedTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _QuanLyChanNuoi_Minn_DataSet3 _QuanLyChanNuoi_Minn_DataSet3;
        private System.Windows.Forms.BindingSource feedingScheduleBindingSource;
        private _QuanLyChanNuoi_Minn_DataSet3TableAdapters.FeedingScheduleTableAdapter feedingScheduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
    }
}