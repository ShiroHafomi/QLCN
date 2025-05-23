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
            this.Amount_Text = new System.Windows.Forms.TextBox();
            this.button_Menu = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.ScheduleID_Text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DT_FeedTime = new System.Windows.Forms.DateTimePicker();
            this.cmb_animalName = new System.Windows.Forms.ComboBox();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_FeedName = new System.Windows.Forms.ComboBox();
            this.feedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.feedingScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedingScheduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Amount_Text
            // 
            this.Amount_Text.Location = new System.Drawing.Point(500, 130);
            this.Amount_Text.Margin = new System.Windows.Forms.Padding(2);
            this.Amount_Text.Name = "Amount_Text";
            this.Amount_Text.Size = new System.Drawing.Size(151, 20);
            this.Amount_Text.TabIndex = 54;
            // 
            // button_Menu
            // 
            this.button_Menu.Location = new System.Drawing.Point(465, 212);
            this.button_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(56, 19);
            this.button_Menu.TabIndex = 53;
            this.button_Menu.Text = "Menu";
            this.button_Menu.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(378, 212);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(56, 19);
            this.button_Delete.TabIndex = 52;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(295, 212);
            this.button_Update.Margin = new System.Windows.Forms.Padding(2);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(56, 19);
            this.button_Update.TabIndex = 51;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(201, 212);
            this.button_Add.Margin = new System.Windows.Forms.Padding(2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(56, 19);
            this.button_Add.TabIndex = 50;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // ScheduleID_Text
            // 
            this.ScheduleID_Text.Location = new System.Drawing.Point(200, 78);
            this.ScheduleID_Text.Margin = new System.Windows.Forms.Padding(2);
            this.ScheduleID_Text.Name = "ScheduleID_Text";
            this.ScheduleID_Text.Size = new System.Drawing.Size(151, 20);
            this.ScheduleID_Text.TabIndex = 46;
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
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Feed name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Animal name";
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
            // DT_FeedTime
            // 
            this.DT_FeedTime.CustomFormat = "MM/dd/yyyy";
            this.DT_FeedTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DT_FeedTime.Location = new System.Drawing.Point(500, 94);
            this.DT_FeedTime.Name = "DT_FeedTime";
            this.DT_FeedTime.Size = new System.Drawing.Size(151, 20);
            this.DT_FeedTime.TabIndex = 55;
            // 
            // cmb_animalName
            // 
            this.cmb_animalName.FormattingEnabled = true;
            this.cmb_animalName.Location = new System.Drawing.Point(200, 113);
            this.cmb_animalName.Name = "cmb_animalName";
            this.cmb_animalName.Size = new System.Drawing.Size(150, 21);
            this.cmb_animalName.TabIndex = 56;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            // 
            // _QuanLyChanNuoi_Minn_DataSet1
            // 
            // 
            // cmb_FeedName
            // 
            this.cmb_FeedName.FormattingEnabled = true;
            this.cmb_FeedName.Location = new System.Drawing.Point(200, 146);
            this.cmb_FeedName.Name = "cmb_FeedName";
            this.cmb_FeedName.Size = new System.Drawing.Size(150, 21);
            this.cmb_FeedName.TabIndex = 57;
            // 
            // feedBindingSource
            // 
            this.feedBindingSource.DataMember = "Feed";
            // 
            // _QuanLyChanNuoi_Minn_DataSet2
            // 
            // 
            // animalTableAdapter
            // 
            // 
            // feedTableAdapter
            // 
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(112, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 73);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // feedingScheduleBindingSource
            // 
            this.feedingScheduleBindingSource.DataMember = "FeedingSchedule";
            // 
            // _QuanLyChanNuoi_Minn_DataSet3
            // 
            // 
            // feedingScheduleTableAdapter
            // 
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
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_FeedName);
            this.Controls.Add(this.cmb_animalName);
            this.Controls.Add(this.DT_FeedTime);
            this.Controls.Add(this.Amount_Text);
            this.Controls.Add(this.button_Menu);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.ScheduleID_Text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_FeedingSchedule";
            this.Text = "frm_FeedingSchedule";
            this.Load += new System.EventHandler(this.frm_FeedingSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedingScheduleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Amount_Text;
        private System.Windows.Forms.Button button_Menu;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox ScheduleID_Text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DT_FeedTime;
        private System.Windows.Forms.ComboBox cmb_animalName;
        private System.Windows.Forms.ComboBox cmb_FeedName;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private System.Windows.Forms.BindingSource feedBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource feedingScheduleBindingSource;
        private System.Windows.Forms.Label label4;
    }
}