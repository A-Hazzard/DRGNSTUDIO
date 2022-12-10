namespace ProjectExample
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.welcomeBackText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputInvoice = new System.Windows.Forms.TextBox();
            this.inputID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sendBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.groupBox1.Controls.Add(this.sendBTN);
            this.groupBox1.Controls.Add(this.cancelbtn);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.welcomeBackText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.inputInvoice);
            this.groupBox1.Controls.Add(this.inputID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-132, -53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1065, 557);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(446, 364);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(313, 55);
            this.cancelbtn.TabIndex = 13;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            // 
            // welcomeBackText
            // 
            this.welcomeBackText.AutoSize = true;
            this.welcomeBackText.Font = new System.Drawing.Font("Segoe UI Historic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeBackText.Location = new System.Drawing.Point(503, 98);
            this.welcomeBackText.Name = "welcomeBackText";
            this.welcomeBackText.Size = new System.Drawing.Size(196, 62);
            this.welcomeBackText.TabIndex = 10;
            this.welcomeBackText.Text = "Invoices";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Invoice";
            // 
            // inputInvoice
            // 
            this.inputInvoice.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputInvoice.Location = new System.Drawing.Point(446, 232);
            this.inputInvoice.Name = "inputInvoice";
            this.inputInvoice.Size = new System.Drawing.Size(313, 28);
            this.inputInvoice.TabIndex = 8;
            // 
            // inputID
            // 
            this.inputID.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputID.Location = new System.Drawing.Point(446, 175);
            this.inputID.Name = "inputID";
            this.inputID.Size = new System.Drawing.Size(313, 28);
            this.inputID.TabIndex = 7;
            this.inputID.TextChanged += new System.EventHandler(this.inputID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Patient ID";
            // 
            // sendBTN
            // 
            this.sendBTN.BackColor = System.Drawing.Color.PaleVioletRed;
            this.sendBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBTN.Location = new System.Drawing.Point(446, 291);
            this.sendBTN.Name = "sendBTN";
            this.sendBTN.Size = new System.Drawing.Size(313, 55);
            this.sendBTN.TabIndex = 14;
            this.sendBTN.Text = "Send";
            this.sendBTN.UseVisualStyleBackColor = false;
            this.sendBTN.Click += new System.EventHandler(this.sendBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 504);
            this.Controls.Add(this.groupBox1);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcomeBackText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputInvoice;
        private System.Windows.Forms.TextBox inputID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendBTN;
    }
}