namespace ProjectExample
{
    partial class treatmentHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(treatmentHistory));
            this.showTreatments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.showTreatments)).BeginInit();
            this.SuspendLayout();
            // 
            // showTreatments
            // 
            this.showTreatments.BackgroundColor = System.Drawing.Color.White;
            this.showTreatments.ColumnHeadersHeight = 29;
            this.showTreatments.Location = new System.Drawing.Point(-3, -1);
            this.showTreatments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showTreatments.Name = "showTreatments";
            this.showTreatments.RowHeadersWidth = 51;
            this.showTreatments.RowTemplate.Height = 24;
            this.showTreatments.Size = new System.Drawing.Size(494, 119);
            this.showTreatments.TabIndex = 18;
            this.showTreatments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showPatients_CellContentClick);
            // 
            // treatmentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 128);
            this.Controls.Add(this.showTreatments);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "treatmentHistory";
            this.Text = "treatmentHistory";
            ((System.ComponentModel.ISupportInitialize)(this.showTreatments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView showTreatments;
    }
}