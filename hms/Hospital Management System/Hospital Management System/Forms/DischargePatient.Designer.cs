namespace Hospital_Management_System.Forms
{
    partial class DischargePatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DischargePatient));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAdmitPatient = new System.Windows.Forms.ComboBox();
            this.btnDischarge = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admitted Patient";
            // 
            // cmbAdmitPatient
            // 
            this.cmbAdmitPatient.FormattingEnabled = true;
            this.cmbAdmitPatient.Location = new System.Drawing.Point(192, 96);
            this.cmbAdmitPatient.Name = "cmbAdmitPatient";
            this.cmbAdmitPatient.Size = new System.Drawing.Size(189, 21);
            this.cmbAdmitPatient.TabIndex = 1;
            // 
            // btnDischarge
            // 
            this.btnDischarge.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDischarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDischarge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDischarge.ForeColor = System.Drawing.Color.White;
            this.btnDischarge.Location = new System.Drawing.Point(124, 165);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.Size = new System.Drawing.Size(247, 41);
            this.btnDischarge.TabIndex = 2;
            this.btnDischarge.Text = "Discharge Patient";
            this.btnDischarge.UseVisualStyleBackColor = false;
            this.btnDischarge.Click += new System.EventHandler(this.btnDischarge_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(38, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 37);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Discharge Patients";
            // 
            // DischargePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 419);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnDischarge);
            this.Controls.Add(this.cmbAdmitPatient);
            this.Controls.Add(this.label1);
            this.Name = "DischargePatient";
            this.Text = "DischargePatient";
            this.Load += new System.EventHandler(this.DischargePatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAdmitPatient;
        private System.Windows.Forms.Button btnDischarge;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
    }
}