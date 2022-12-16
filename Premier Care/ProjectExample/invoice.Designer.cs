namespace ProjectExample
{
    partial class invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invoice));
            this.welcomeBackText = new System.Windows.Forms.Label();
            this.showInvoices = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.showInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeBackText
            // 
            this.welcomeBackText.AutoSize = true;
            this.welcomeBackText.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeBackText.Location = new System.Drawing.Point(277, 36);
            this.welcomeBackText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeBackText.Name = "welcomeBackText";
            this.welcomeBackText.Size = new System.Drawing.Size(159, 50);
            this.welcomeBackText.TabIndex = 13;
            this.welcomeBackText.Text = "Invoices";
            // 
            // showInvoices
            // 
            this.showInvoices.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.showInvoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showInvoices.ColumnHeadersHeight = 29;
            this.showInvoices.Location = new System.Drawing.Point(146, 119);
            this.showInvoices.Margin = new System.Windows.Forms.Padding(2);
            this.showInvoices.Name = "showInvoices";
            this.showInvoices.RowHeadersWidth = 51;
            this.showInvoices.RowTemplate.Height = 24;
            this.showInvoices.Size = new System.Drawing.Size(453, 119);
            this.showInvoices.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectExample.Properties.Resources.download__2_;
            this.pictureBox2.Location = new System.Drawing.Point(111, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(514, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.BackgroundImage = global::ProjectExample.Properties.Resources.HD_wallpaper_blurred_pink_background_ultra_aero_colorful_pink_background_blurred_simple_blurry_minimalism_cloth_hotpink;
            this.ClientSize = new System.Drawing.Size(688, 401);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.showInvoices);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.welcomeBackText);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcomeBackText;
        private System.Windows.Forms.DataGridView showInvoices;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}