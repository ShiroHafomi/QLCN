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
            this.carelogBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.cmb_Staff_Name = new System.Windows.Forms.ComboBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carelogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 344);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(510, 141);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Staff_CellContentClick);
            // 
            // carelogBindingSource            


            // 
            // _QuanLyChanNuoi_TranThanhTri_DataSet
            // 
            // 
            // button_xoa
            // 
            this.button_xoa.Location = new System.Drawing.Point(383, 303);
            this.button_xoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(67, 28);
            this.button_xoa.TabIndex = 17;
            this.button_xoa.Text = "Delete";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(285, 303);
            this.button_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(67, 28);
            this.button_Update.TabIndex = 18;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_ADD
            // 
            this.button_ADD.Location = new System.Drawing.Point(188, 303);
            this.button_ADD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_ADD.Name = "button_ADD";
            this.button_ADD.Size = new System.Drawing.Size(67, 28);
            this.button_ADD.TabIndex = 19;
            this.button_ADD.Text = "Add";
            this.button_ADD.UseVisualStyleBackColor = true;
            this.button_ADD.Click += new System.EventHandler(this.button_ADD_Click);
            // 
            // CareDate_Text
            // 
            this.CareDate_Text.Location = new System.Drawing.Point(178, 185);
            this.CareDate_Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CareDate_Text.Name = "CareDate_Text";
            this.CareDate_Text.Size = new System.Drawing.Size(272, 20);
            this.CareDate_Text.TabIndex = 12;
            // 
            // LogID_Text
            // 
            this.LogID_Text.Location = new System.Drawing.Point(178, 63);
            this.LogID_Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogID_Text.Name = "LogID_Text";
            this.LogID_Text.Size = new System.Drawing.Size(272, 20);
            this.LogID_Text.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CareDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Staff Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Animal Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "LogID";
            // 
            // Desciption_Text
            // 
            this.Desciption_Text.Location = new System.Drawing.Point(178, 226);
            this.Desciption_Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Desciption_Text.Multiline = true;
            this.Desciption_Text.Name = "Desciption_Text";
            this.Desciption_Text.Size = new System.Drawing.Size(272, 57);
            this.Desciption_Text.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Description";
            // 
            // cmb_Animal_Name
            // 
            this.cmb_Animal_Name.FormattingEnabled = true;
            this.cmb_Animal_Name.Location = new System.Drawing.Point(178, 102);
            this.cmb_Animal_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_Animal_Name.Name = "cmb_Animal_Name";
            this.cmb_Animal_Name.Size = new System.Drawing.Size(272, 21);
            this.cmb_Animal_Name.TabIndex = 23;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";

            // 
            // cmb_Staff_Name
            // 
            this.cmb_Staff_Name.FormattingEnabled = true;
            this.cmb_Staff_Name.Location = new System.Drawing.Point(178, 143);
            this.cmb_Staff_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_Staff_Name.Name = "cmb_Staff_Name";
            this.cmb_Staff_Name.Size = new System.Drawing.Size(272, 21);
            this.cmb_Staff_Name.TabIndex = 24;
            // 
            // 
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(201, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 27);
            this.label6.TabIndex = 61;
            this.label6.Text = "Animal Care Information";
            // 
            // frm_CareLOG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 527);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_CareLOG";
            this.Text = "CareLOG";
            this.Load += new System.EventHandler(this.frm_CareLOG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carelogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource carelogBindingSource;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.Label label6;
    }
}