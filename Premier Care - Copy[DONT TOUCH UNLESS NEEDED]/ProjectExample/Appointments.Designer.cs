namespace ProjectExample
{
    partial class Appointments
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.insertCSR = new System.Windows.Forms.TextBox();
            this.insertStaff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Show = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.insertPatNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.insertParticulars = new System.Windows.Forms.TextBox();
            this.insertTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.createappbtn = new System.Windows.Forms.Button();
            this.loadappbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Show)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.insertCSR);
            this.groupBox1.Controls.Add(this.insertStaff);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Show);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.insertPatNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.insertParticulars);
            this.groupBox1.Controls.Add(this.insertTime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(644, 366);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Make an appointment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(460, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "CSR:";
            // 
            // insertCSR
            // 
            this.insertCSR.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertCSR.Location = new System.Drawing.Point(508, 48);
            this.insertCSR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.insertCSR.Name = "insertCSR";
            this.insertCSR.Size = new System.Drawing.Size(114, 24);
            this.insertCSR.TabIndex = 32;
            // 
            // insertStaff
            // 
            this.insertStaff.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertStaff.Location = new System.Drawing.Point(508, 105);
            this.insertStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.insertStaff.Name = "insertStaff";
            this.insertStaff.Size = new System.Drawing.Size(114, 24);
            this.insertStaff.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Staff#:";
            // 
            // Show
            // 
            this.Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Show.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Show.Location = new System.Drawing.Point(2, 188);
            this.Show.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Show.Name = "Show";
            this.Show.RowHeadersWidth = 51;
            this.Show.RowTemplate.Height = 24;
            this.Show.Size = new System.Drawing.Size(640, 176);
            this.Show.TabIndex = 29;
            this.Show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Show_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Patient Number:";
            // 
            // insertPatNum
            // 
            this.insertPatNum.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertPatNum.Location = new System.Drawing.Point(123, 50);
            this.insertPatNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.insertPatNum.Name = "insertPatNum";
            this.insertPatNum.Size = new System.Drawing.Size(104, 24);
            this.insertPatNum.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Time:";
            // 
            // insertParticulars
            // 
            this.insertParticulars.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertParticulars.Location = new System.Drawing.Point(81, 115);
            this.insertParticulars.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.insertParticulars.Name = "insertParticulars";
            this.insertParticulars.Size = new System.Drawing.Size(233, 24);
            this.insertParticulars.TabIndex = 28;
            // 
            // insertTime
            // 
            this.insertTime.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertTime.Location = new System.Drawing.Point(329, 49);
            this.insertTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.insertTime.Name = "insertTime";
            this.insertTime.Size = new System.Drawing.Size(114, 24);
            this.insertTime.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Reason:";
            // 
            // createappbtn
            // 
            this.createappbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(33)))), ((int)(((byte)(79)))));
            this.createappbtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createappbtn.Location = new System.Drawing.Point(2, 25);
            this.createappbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createappbtn.Name = "createappbtn";
            this.createappbtn.Size = new System.Drawing.Size(128, 74);
            this.createappbtn.TabIndex = 33;
            this.createappbtn.Text = "Create Appointment";
            this.createappbtn.UseVisualStyleBackColor = false;
            this.createappbtn.Click += new System.EventHandler(this.createappbtn_Click);
            // 
            // loadappbtn
            // 
            this.loadappbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(33)))), ((int)(((byte)(79)))));
            this.loadappbtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadappbtn.Location = new System.Drawing.Point(2, 152);
            this.loadappbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadappbtn.Name = "loadappbtn";
            this.loadappbtn.Size = new System.Drawing.Size(126, 68);
            this.loadappbtn.TabIndex = 32;
            this.loadappbtn.Text = "Load Appointments";
            this.loadappbtn.UseVisualStyleBackColor = false;
            this.loadappbtn.Click += new System.EventHandler(this.loadappbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.createappbtn);
            this.panel1.Controls.Add(this.loadappbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(648, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 366);
            this.panel1.TabIndex = 35;
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Appointments";
            this.Text = "Appointments";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Show)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox insertCSR;
        private System.Windows.Forms.TextBox insertStaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox insertPatNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox insertParticulars;
        private System.Windows.Forms.TextBox insertTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button createappbtn;
        private System.Windows.Forms.Button loadappbtn;
        private System.Windows.Forms.Panel panel1;
    }
}