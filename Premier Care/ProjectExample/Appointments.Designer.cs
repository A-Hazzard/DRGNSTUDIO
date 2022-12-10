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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Show)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.groupBox1.Controls.Add(this.insertStaff);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Show);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.insertPatNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.insertParticulars);
            this.groupBox1.Controls.Add(this.insertTime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(-119, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(975, 412);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // insertStaff
            // 
            this.insertStaff.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertStaff.Location = new System.Drawing.Point(607, 134);
            this.insertStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertStaff.Name = "insertStaff";
            this.insertStaff.Size = new System.Drawing.Size(151, 28);
            this.insertStaff.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(543, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Staff#:";
            // 
            // Show
            // 
            this.Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Show.Location = new System.Drawing.Point(131, 189);
            this.Show.Name = "Show";
            this.Show.RowHeadersWidth = 51;
            this.Show.RowTemplate.Height = 24;
            this.Show.Size = new System.Drawing.Size(821, 217);
            this.Show.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Patient Number:";
            // 
            // insertPatNum
            // 
            this.insertPatNum.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertPatNum.Location = new System.Drawing.Point(288, 70);
            this.insertPatNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertPatNum.Name = "insertPatNum";
            this.insertPatNum.Size = new System.Drawing.Size(137, 28);
            this.insertPatNum.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Time:";
            // 
            // insertParticulars
            // 
            this.insertParticulars.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertParticulars.Location = new System.Drawing.Point(228, 134);
            this.insertParticulars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertParticulars.Name = "insertParticulars";
            this.insertParticulars.Size = new System.Drawing.Size(309, 28);
            this.insertParticulars.TabIndex = 28;
            // 
            // insertTime
            // 
            this.insertTime.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertTime.Location = new System.Drawing.Point(543, 67);
            this.insertTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertTime.Name = "insertTime";
            this.insertTime.Size = new System.Drawing.Size(151, 28);
            this.insertTime.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(154, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Reason:";
            // 
            // createappbtn
            // 
            this.createappbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(33)))), ((int)(((byte)(79)))));
            this.createappbtn.Location = new System.Drawing.Point(862, 117);
            this.createappbtn.Name = "createappbtn";
            this.createappbtn.Size = new System.Drawing.Size(153, 60);
            this.createappbtn.TabIndex = 36;
            this.createappbtn.Text = "Create Appointment";
            this.createappbtn.UseVisualStyleBackColor = false;
            this.createappbtn.Click += new System.EventHandler(this.createappbtn_Click);
            // 
            // loadappbtn
            // 
            this.loadappbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(33)))), ((int)(((byte)(79)))));
            this.loadappbtn.Location = new System.Drawing.Point(862, 19);
            this.loadappbtn.Name = "loadappbtn";
            this.loadappbtn.Size = new System.Drawing.Size(153, 59);
            this.loadappbtn.TabIndex = 35;
            this.loadappbtn.Text = "Load Appointments";
            this.loadappbtn.UseVisualStyleBackColor = false;
            this.loadappbtn.Click += new System.EventHandler(this.loadappbtn_Click);
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.createappbtn);
            this.Controls.Add(this.loadappbtn);
            this.Name = "Appointments";
            this.Text = "Appointments";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Show)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}