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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registry = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.infobtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.patientDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-12, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1145, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // registry
            // 
            this.registry.BackColor = System.Drawing.Color.PaleVioletRed;
            this.registry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registry.Location = new System.Drawing.Point(796, 3);
            this.registry.Name = "registry";
            this.registry.Size = new System.Drawing.Size(166, 51);
            this.registry.TabIndex = 0;
            this.registry.Text = "Registration";
            this.registry.UseVisualStyleBackColor = false;
            this.registry.Click += new System.EventHandler(this.registry_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 450);
            this.panel1.TabIndex = 0;
            // 
            // infobtn
            // 
            this.infobtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.infobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infobtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infobtn.Location = new System.Drawing.Point(452, 3);
            this.infobtn.Name = "infobtn";
            this.infobtn.Size = new System.Drawing.Size(166, 51);
            this.infobtn.TabIndex = 6;
            this.infobtn.Text = "More Info";
            this.infobtn.UseVisualStyleBackColor = false;
            this.infobtn.Click += new System.EventHandler(this.infobtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 62);
            this.label2.TabIndex = 5;
            this.label2.Text = "Premier Care Clinic";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 74);
            this.label1.TabIndex = 4;
            this.label1.Text = "When you need answers,\r\nyou know where to go.\r\n";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginBtn.Location = new System.Drawing.Point(624, 3);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(166, 51);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // patientDetails
            // 
            this.patientDetails.BackColor = System.Drawing.Color.PaleVioletRed;
            this.patientDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientDetails.Location = new System.Drawing.Point(280, 3);
            this.patientDetails.Name = "patientDetails";
            this.patientDetails.Size = new System.Drawing.Size(166, 51);
            this.patientDetails.TabIndex = 7;
            this.patientDetails.Text = "Patient Details";
            this.patientDetails.UseVisualStyleBackColor = false;
            this.patientDetails.Click += new System.EventHandler(this.patientDetails_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "x";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
    }
}

