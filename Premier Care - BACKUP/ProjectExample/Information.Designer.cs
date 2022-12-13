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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Staff = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.invoicebtn = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.DataGridView();
            this.drugList = new System.Windows.Forms.ListBox();
            this.Drugs = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.View)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(33)))), ((int)(((byte)(79)))));
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(130, 79);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 55);
            this.button2.TabIndex = 11;
            this.button2.Text = "Staff Available";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(33)))), ((int)(((byte)(79)))));
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(137, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Services";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Staff
            // 
            this.Staff.FormattingEnabled = true;
            this.Staff.Location = new System.Drawing.Point(19, 63);
            this.Staff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(92, 95);
            this.Staff.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 18);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // invoicebtn
            // 
            this.invoicebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(33)))), ((int)(((byte)(79)))));
            this.invoicebtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicebtn.Location = new System.Drawing.Point(11, 163);
            this.invoicebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.invoicebtn.Name = "invoicebtn";
            this.invoicebtn.Size = new System.Drawing.Size(119, 49);
            this.invoicebtn.TabIndex = 12;
            this.invoicebtn.Text = "Invoice";
            this.invoicebtn.UseVisualStyleBackColor = false;
            this.invoicebtn.Click += new System.EventHandler(this.invoicebtn_Click);
            // 
            // View
            // 
            this.View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View.Location = new System.Drawing.Point(-10, 216);
            this.View.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.View.Name = "View";
            this.View.RowHeadersWidth = 51;
            this.View.RowTemplate.Height = 24;
            this.View.Size = new System.Drawing.Size(613, 154);
            this.View.TabIndex = 13;
            // 
            // drugList
            // 
            this.drugList.FormattingEnabled = true;
            this.drugList.Location = new System.Drawing.Point(278, 18);
            this.drugList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.drugList.Name = "drugList";
            this.drugList.Size = new System.Drawing.Size(92, 95);
            this.drugList.TabIndex = 14;
            // 
            // Drugs
            // 
            this.Drugs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(33)))), ((int)(((byte)(79)))));
            this.Drugs.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drugs.Location = new System.Drawing.Point(414, 34);
            this.Drugs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Drugs.Name = "Drugs";
            this.Drugs.Size = new System.Drawing.Size(116, 54);
            this.Drugs.TabIndex = 15;
            this.Drugs.Text = "Patient";
            this.Drugs.UseVisualStyleBackColor = false;
            this.Drugs.Click += new System.EventHandler(this.Drugs_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(278, 117);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(92, 95);
            this.listBox1.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(33)))), ((int)(((byte)(79)))));
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(414, 145);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 50);
            this.button3.TabIndex = 17;
            this.button3.Text = "Drugs";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Drugs);
            this.Controls.Add(this.drugList);
            this.Controls.Add(this.View);
            this.Controls.Add(this.invoicebtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Staff);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Information";
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Staff;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button invoicebtn;
        private System.Windows.Forms.DataGridView View;
        private System.Windows.Forms.ListBox drugList;
        private System.Windows.Forms.Button Drugs;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
    }
}