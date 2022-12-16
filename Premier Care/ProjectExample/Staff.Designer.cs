namespace ProjectExample
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ShowMembers = new System.Windows.Forms.DataGridView();
            this.welcomeText = new System.Windows.Forms.Label();
            this.showDoctors = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.showNurses = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.showXRayTechnicians = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.showLabTechnicians = new System.Windows.Forms.DataGridView();
            this.LabTechnicians = new System.Windows.Forms.Label();
            this.showTherapist = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.showCsr = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.medicineBtn = new System.Windows.Forms.Button();
            this.appointbtn = new System.Windows.Forms.Button();
            this.infobtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.registry = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showNurses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showXRayTechnicians)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showLabTechnicians)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTherapist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCsr)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // ShowMembers
            // 
            this.ShowMembers.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.ShowMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowMembers.ColumnHeadersHeight = 29;
            this.ShowMembers.Location = new System.Drawing.Point(31, 219);
            this.ShowMembers.Name = "ShowMembers";
            this.ShowMembers.RowHeadersWidth = 51;
            this.ShowMembers.RowTemplate.Height = 24;
            this.ShowMembers.Size = new System.Drawing.Size(474, 214);
            this.ShowMembers.TabIndex = 15;
            this.ShowMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText.Location = new System.Drawing.Point(21, 142);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(308, 60);
            this.welcomeText.TabIndex = 16;
            this.welcomeText.Text = "Staff Members";
            // 
            // showDoctors
            // 
            this.showDoctors.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.showDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showDoctors.ColumnHeadersHeight = 29;
            this.showDoctors.Location = new System.Drawing.Point(546, 219);
            this.showDoctors.Name = "showDoctors";
            this.showDoctors.RowHeadersWidth = 51;
            this.showDoctors.RowTemplate.Height = 24;
            this.showDoctors.Size = new System.Drawing.Size(474, 214);
            this.showDoctors.TabIndex = 15;
            this.showDoctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 60);
            this.label1.TabIndex = 16;
            this.label1.Text = "Doctors";
            // 
            // showNurses
            // 
            this.showNurses.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.showNurses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showNurses.ColumnHeadersHeight = 29;
            this.showNurses.Location = new System.Drawing.Point(31, 500);
            this.showNurses.Name = "showNurses";
            this.showNurses.RowHeadersWidth = 51;
            this.showNurses.RowTemplate.Height = 24;
            this.showNurses.Size = new System.Drawing.Size(474, 275);
            this.showNurses.TabIndex = 15;
            this.showNurses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 60);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nurses";
            // 
            // showXRayTechnicians
            // 
            this.showXRayTechnicians.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.showXRayTechnicians.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showXRayTechnicians.ColumnHeadersHeight = 29;
            this.showXRayTechnicians.Location = new System.Drawing.Point(546, 500);
            this.showXRayTechnicians.Name = "showXRayTechnicians";
            this.showXRayTechnicians.RowHeadersWidth = 51;
            this.showXRayTechnicians.RowTemplate.Height = 24;
            this.showXRayTechnicians.Size = new System.Drawing.Size(474, 275);
            this.showXRayTechnicians.TabIndex = 15;
            this.showXRayTechnicians.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(536, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 60);
            this.label3.TabIndex = 16;
            this.label3.Text = "X-RAY Technicians";
            // 
            // showLabTechnicians
            // 
            this.showLabTechnicians.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.showLabTechnicians.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showLabTechnicians.ColumnHeadersHeight = 29;
            this.showLabTechnicians.Location = new System.Drawing.Point(1026, 505);
            this.showLabTechnicians.Name = "showLabTechnicians";
            this.showLabTechnicians.RowHeadersWidth = 51;
            this.showLabTechnicians.RowTemplate.Height = 24;
            this.showLabTechnicians.Size = new System.Drawing.Size(474, 275);
            this.showLabTechnicians.TabIndex = 15;
            this.showLabTechnicians.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LabTechnicians
            // 
            this.LabTechnicians.AutoSize = true;
            this.LabTechnicians.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTechnicians.Location = new System.Drawing.Point(1016, 428);
            this.LabTechnicians.Name = "LabTechnicians";
            this.LabTechnicians.Size = new System.Drawing.Size(325, 60);
            this.LabTechnicians.TabIndex = 16;
            this.LabTechnicians.Text = "Lab Technicians";
            // 
            // showTherapist
            // 
            this.showTherapist.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.showTherapist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showTherapist.ColumnHeadersHeight = 29;
            this.showTherapist.Location = new System.Drawing.Point(1026, 219);
            this.showTherapist.Name = "showTherapist";
            this.showTherapist.RowHeadersWidth = 51;
            this.showTherapist.RowTemplate.Height = 24;
            this.showTherapist.Size = new System.Drawing.Size(474, 214);
            this.showTherapist.TabIndex = 15;
            this.showTherapist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1016, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 60);
            this.label5.TabIndex = 16;
            this.label5.Text = "Therapist";
            // 
            // showCsr
            // 
            this.showCsr.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.showCsr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showCsr.ColumnHeadersHeight = 29;
            this.showCsr.Location = new System.Drawing.Point(21, 699);
            this.showCsr.Name = "showCsr";
            this.showCsr.RowHeadersWidth = 51;
            this.showCsr.RowTemplate.Height = 24;
            this.showCsr.Size = new System.Drawing.Size(474, 275);
            this.showCsr.TabIndex = 15;
            this.showCsr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 622);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 60);
            this.label4.TabIndex = 16;
            this.label4.Text = "CSRs";
            // 
            // medicineBtn
            // 
            this.medicineBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.medicineBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.medicineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.medicineBtn.Image = global::ProjectExample.Properties.Resources._9165684_login_arrow_icon;
            this.medicineBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medicineBtn.Location = new System.Drawing.Point(1221, 11);
            this.medicineBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.medicineBtn.Name = "medicineBtn";
            this.medicineBtn.Size = new System.Drawing.Size(157, 70);
            this.medicineBtn.TabIndex = 21;
            this.medicineBtn.Text = "Medicine";
            this.medicineBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.medicineBtn.UseVisualStyleBackColor = false;
            this.medicineBtn.Click += new System.EventHandler(this.medicineBtn_Click);
            // 
            // appointbtn
            // 
            this.appointbtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.appointbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appointbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.appointbtn.Image = global::ProjectExample.Properties.Resources._4172165_appointment_booking_form_reservation_document_icon;
            this.appointbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appointbtn.Location = new System.Drawing.Point(344, 11);
            this.appointbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointbtn.Name = "appointbtn";
            this.appointbtn.Size = new System.Drawing.Size(173, 70);
            this.appointbtn.TabIndex = 20;
            this.appointbtn.Text = "    Appoitments";
            this.appointbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.appointbtn.UseVisualStyleBackColor = false;
            this.appointbtn.Click += new System.EventHandler(this.appointbtn_Click);
            // 
            // infobtn
            // 
            this.infobtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.infobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.infobtn.Image = global::ProjectExample.Properties.Resources._2202278_detailed_i_info_information_more_icon;
            this.infobtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infobtn.Location = new System.Drawing.Point(523, 14);
            this.infobtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infobtn.Name = "infobtn";
            this.infobtn.Size = new System.Drawing.Size(188, 70);
            this.infobtn.TabIndex = 19;
            this.infobtn.Text = "Staff Members";
            this.infobtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.infobtn.UseVisualStyleBackColor = false;
            this.infobtn.Click += new System.EventHandler(this.infobtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.loginBtn.Image = global::ProjectExample.Properties.Resources._9165684_login_arrow_icon;
            this.loginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginBtn.Location = new System.Drawing.Point(1087, 11);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(128, 70);
            this.loginBtn.TabIndex = 18;
            this.loginBtn.Text = "Logout";
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // registry
            // 
            this.registry.BackColor = System.Drawing.Color.PaleVioletRed;
            this.registry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registry.FlatAppearance.BorderSize = 0;
            this.registry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.registry.Image = global::ProjectExample.Properties.Resources._7830628_login_icon;
            this.registry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registry.Location = new System.Drawing.Point(732, 14);
            this.registry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registry.Name = "registry";
            this.registry.Size = new System.Drawing.Size(176, 70);
            this.registry.TabIndex = 17;
            this.registry.Text = "   Registration";
            this.registry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registry.UseVisualStyleBackColor = false;
            this.registry.Click += new System.EventHandler(this.registry_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.button1.Image = global::ProjectExample.Properties.Resources.person;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(915, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 70);
            this.button1.TabIndex = 22;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1527, 1038);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.medicineBtn);
            this.Controls.Add(this.appointbtn);
            this.Controls.Add(this.infobtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.registry);
            this.Controls.Add(this.LabTechnicians);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.showLabTechnicians);
            this.Controls.Add(this.showXRayTechnicians);
            this.Controls.Add(this.showCsr);
            this.Controls.Add(this.showNurses);
            this.Controls.Add(this.showTherapist);
            this.Controls.Add(this.showDoctors);
            this.Controls.Add(this.ShowMembers);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Staff";
            this.Text = "Staff";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showNurses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showXRayTechnicians)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showLabTechnicians)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTherapist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCsr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView ShowMembers;
        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.DataGridView showDoctors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView showNurses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView showXRayTechnicians;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView showLabTechnicians;
        private System.Windows.Forms.Label LabTechnicians;
        private System.Windows.Forms.DataGridView showTherapist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView showCsr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button medicineBtn;
        private System.Windows.Forms.Button appointbtn;
        private System.Windows.Forms.Button infobtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button registry;
        private System.Windows.Forms.Button button1;
    }
}