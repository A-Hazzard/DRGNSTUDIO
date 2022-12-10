namespace ProjectExample
{
    partial class Information
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
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Drugs = new System.Windows.Forms.Button();
            this.drugList = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Staff = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(33)))), ((int)(((byte)(79)))));
            this.button3.Location = new System.Drawing.Point(557, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 55);
            this.button3.TabIndex = 27;
            this.button3.Text = "Drugs";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(376, 134);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 116);
            this.listBox1.TabIndex = 26;
            // 
            // Drugs
            // 
            this.Drugs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(33)))), ((int)(((byte)(79)))));
            this.Drugs.Location = new System.Drawing.Point(557, 32);
            this.Drugs.Name = "Drugs";
            this.Drugs.Size = new System.Drawing.Size(154, 55);
            this.Drugs.TabIndex = 25;
            this.Drugs.Text = "Patient";
            this.Drugs.UseVisualStyleBackColor = false;
            this.Drugs.Click += new System.EventHandler(this.Drugs_Click);
            // 
            // drugList
            // 
            this.drugList.FormattingEnabled = true;
            this.drugList.ItemHeight = 16;
            this.drugList.Location = new System.Drawing.Point(376, 12);
            this.drugList.Name = "drugList";
            this.drugList.Size = new System.Drawing.Size(121, 116);
            this.drugList.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(33)))), ((int)(((byte)(79)))));
            this.button2.Location = new System.Drawing.Point(179, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 61);
            this.button2.TabIndex = 21;
            this.button2.Text = "Staff Available";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(33)))), ((int)(((byte)(79)))));
            this.button1.Location = new System.Drawing.Point(188, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Services";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Staff
            // 
            this.Staff.FormattingEnabled = true;
            this.Staff.ItemHeight = 16;
            this.Staff.Location = new System.Drawing.Point(30, 68);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(121, 116);
            this.Staff.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Drugs);
            this.Controls.Add(this.drugList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Staff);
            this.Controls.Add(this.comboBox1);
            this.Name = "Information";
            this.Text = "Information";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Drugs;
        private System.Windows.Forms.ListBox drugList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Staff;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}