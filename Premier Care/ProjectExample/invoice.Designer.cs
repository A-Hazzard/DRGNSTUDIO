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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.welcomeBackText = new System.Windows.Forms.Label();
            this.showInvoices = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // welcomeBackText
            // 
            this.welcomeBackText.AutoSize = true;
            this.welcomeBackText.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeBackText.Location = new System.Drawing.Point(369, 44);
            this.welcomeBackText.Name = "welcomeBackText";
            this.welcomeBackText.Size = new System.Drawing.Size(199, 62);
            this.welcomeBackText.TabIndex = 13;
            this.welcomeBackText.Text = "Invoices";
            // 
            // showInvoices
            // 
            this.showInvoices.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.showInvoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showInvoices.ColumnHeadersHeight = 29;
            this.showInvoices.Location = new System.Drawing.Point(150, 173);
            this.showInvoices.Name = "showInvoices";
            this.showInvoices.RowHeadersWidth = 51;
            this.showInvoices.RowTemplate.Height = 24;
            this.showInvoices.Size = new System.Drawing.Size(604, 146);
            this.showInvoices.TabIndex = 17;
            // 
            // invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(917, 493);
            this.Controls.Add(this.showInvoices);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.welcomeBackText);
            this.Name = "invoice";
            this.Text = "invoice";
            this.Load += new System.EventHandler(this.invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcomeBackText;
        private System.Windows.Forms.DataGridView showInvoices;
    }
}