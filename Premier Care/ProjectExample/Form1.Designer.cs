namespace ProjectExample
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.medicineBtn = new System.Windows.Forms.Button();
            this.appointbtn = new System.Windows.Forms.Button();
            this.patientDetails = new System.Windows.Forms.Button();
            this.infobtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registry = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.medicineBtn);
            this.panel1.Controls.Add(this.appointbtn);
            this.panel1.Controls.Add(this.patientDetails);
            this.panel1.Controls.Add(this.infobtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.registry);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1462, 567);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(645, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 54);
            this.label2.TabIndex = 5;
            this.label2.Text = "Premier Care Clinic";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(725, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 74);
            this.label1.TabIndex = 4;
            this.label1.Text = "When you need answers,\r\nyou know where to go.\r\n";
            // 
            // medicineBtn
            // 
            this.medicineBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.medicineBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.medicineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineBtn.Image = global::ProjectExample.Properties.Resources._9165684_login_arrow_icon;
            this.medicineBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medicineBtn.Location = new System.Drawing.Point(1252, 13);
            this.medicineBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.medicineBtn.Name = "medicineBtn";
            this.medicineBtn.Size = new System.Drawing.Size(158, 70);
            this.medicineBtn.TabIndex = 9;
            this.medicineBtn.Text = "Medicine";
            this.medicineBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.medicineBtn.UseVisualStyleBackColor = false;
            this.medicineBtn.Click += new System.EventHandler(this.medicineBtn_Click);
            // 
            // appointbtn
            // 
            this.appointbtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.appointbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appointbtn.Image = global::ProjectExample.Properties.Resources._4172165_appointment_booking_form_reservation_document_icon;
            this.appointbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appointbtn.Location = new System.Drawing.Point(306, 11);
            this.appointbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointbtn.Name = "appointbtn";
            this.appointbtn.Size = new System.Drawing.Size(173, 70);
            this.appointbtn.TabIndex = 8;
            this.appointbtn.Text = "    Appoitments";
            this.appointbtn.UseVisualStyleBackColor = false;
            this.appointbtn.Click += new System.EventHandler(this.appointbtn_Click);
            // 
            // patientDetails
            // 
            this.patientDetails.BackColor = System.Drawing.Color.PaleVioletRed;
            this.patientDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientDetails.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDetails.Image = global::ProjectExample.Properties.Resources._6079702_bed_clinic_healthcare_hospital_patient_icon;
            this.patientDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientDetails.Location = new System.Drawing.Point(485, 13);
            this.patientDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientDetails.Name = "patientDetails";
            this.patientDetails.Size = new System.Drawing.Size(221, 70);
            this.patientDetails.TabIndex = 7;
            this.patientDetails.Text = "     Patient Details";
            this.patientDetails.UseVisualStyleBackColor = false;
            this.patientDetails.Click += new System.EventHandler(this.patientDetails_Click);
            // 
            // infobtn
            // 
            this.infobtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.infobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infobtn.Image = global::ProjectExample.Properties.Resources._2202278_detailed_i_info_information_more_icon;
            this.infobtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infobtn.Location = new System.Drawing.Point(712, 13);
            this.infobtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infobtn.Name = "infobtn";
            this.infobtn.Size = new System.Drawing.Size(188, 70);
            this.infobtn.TabIndex = 6;
            this.infobtn.Text = "Staff Members";
            this.infobtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.infobtn.UseVisualStyleBackColor = false;
            this.infobtn.Click += new System.EventHandler(this.infobtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Image = global::ProjectExample.Properties.Resources._9165684_login_arrow_icon;
            this.loginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginBtn.Location = new System.Drawing.Point(1088, 13);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(158, 70);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Logout";
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 103);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1462, 464);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // registry
            // 
            this.registry.BackColor = System.Drawing.Color.PaleVioletRed;
            this.registry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registry.FlatAppearance.BorderSize = 0;
            this.registry.Image = global::ProjectExample.Properties.Resources._7830628_login_icon;
            this.registry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registry.Location = new System.Drawing.Point(906, 13);
            this.registry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registry.Name = "registry";
            this.registry.Size = new System.Drawing.Size(176, 70);
            this.registry.TabIndex = 0;
            this.registry.Text = "   Registration";
            this.registry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registry.UseVisualStyleBackColor = false;
            this.registry.Click += new System.EventHandler(this.registry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 567);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button registry;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button infobtn;
        private System.Windows.Forms.Button patientDetails;
        private System.Windows.Forms.Button appointbtn;
        private System.Windows.Forms.Button medicineBtn;
    }
}

