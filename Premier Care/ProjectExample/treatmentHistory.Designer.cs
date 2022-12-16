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
            this.showTreatments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.showTreatments)).BeginInit();
            this.SuspendLayout();
            // 
            // showTreatments
            // 
            this.showTreatments.BackgroundColor = System.Drawing.Color.White;
            this.showTreatments.ColumnHeadersHeight = 29;
            this.showTreatments.Location = new System.Drawing.Point(-4, -1);
            this.showTreatments.Name = "showTreatments";
            this.showTreatments.RowHeadersWidth = 51;
            this.showTreatments.RowTemplate.Height = 24;
            this.showTreatments.Size = new System.Drawing.Size(658, 146);
            this.showTreatments.TabIndex = 18;
            this.showTreatments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showPatients_CellContentClick);
            // 
            // treatmentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 157);
            this.Controls.Add(this.showTreatments);
            this.Name = "treatmentHistory";
            this.Text = "treatmentHistory";
            ((System.ComponentModel.ISupportInitialize)(this.showTreatments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView showTreatments;
    }
}