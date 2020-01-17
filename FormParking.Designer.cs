namespace WindowsFormsAppAvianos
{
    partial class FormParking
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
            this.Shep = new System.Windows.Forms.Button();
            this.Avianos = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TakeOut = new System.Windows.Forms.Button();
            this.pictureBoxTakeShep = new System.Windows.Forms.PictureBox();
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.SuspendLayout();
            // 
            // Shep
            // 
            this.Shep.Location = new System.Drawing.Point(809, 0);
            this.Shep.Name = "Shep";
            this.Shep.Size = new System.Drawing.Size(75, 23);
            this.Shep.TabIndex = 6;
            this.Shep.Text = "Shep";
            this.Shep.UseVisualStyleBackColor = true;
            this.Shep.Click += new System.EventHandler(this.buttonSetShep_Click);
            // 
            // Avianos
            // 
            this.Avianos.Location = new System.Drawing.Point(809, 29);
            this.Avianos.Name = "Avianos";
            this.Avianos.Size = new System.Drawing.Size(75, 23);
            this.Avianos.TabIndex = 11;
            this.Avianos.Text = "Avianos";
            this.Avianos.UseVisualStyleBackColor = true;
            this.Avianos.Click += new System.EventHandler(this.buttonSetAvianos_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(753, 290);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(96, 20);
            this.maskedTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(750, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Заберите судно";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(750, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Место";
            // 
            // TakeOut
            // 
            this.TakeOut.Location = new System.Drawing.Point(753, 316);
            this.TakeOut.Name = "TakeOut";
            this.TakeOut.Size = new System.Drawing.Size(75, 23);
            this.TakeOut.TabIndex = 15;
            this.TakeOut.Text = "Забрать";
            this.TakeOut.UseVisualStyleBackColor = true;
            this.TakeOut.Click += new System.EventHandler(this.buttonTakeShep_Click);
            // 
            // pictureBoxTakeShep
            // 
            this.pictureBoxTakeShep.Location = new System.Drawing.Point(746, 358);
            this.pictureBoxTakeShep.Name = "pictureBoxTakeShep";
            this.pictureBoxTakeShep.Size = new System.Drawing.Size(126, 91);
            this.pictureBoxTakeShep.TabIndex = 16;
            this.pictureBoxTakeShep.TabStop = false;
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 2);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(734, 459);
            this.pictureBoxParking.TabIndex = 17;
            this.pictureBoxParking.TabStop = false;
            // 
            // FormParking
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.pictureBoxTakeShep);
            this.Controls.Add(this.TakeOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.Avianos);
            this.Controls.Add(this.Shep);
            this.Name = "FormParking";
            this.Text = "Avianosec";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Shep;
        private System.Windows.Forms.Button Avianos;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TakeOut;
        private System.Windows.Forms.PictureBox pictureBoxTakeShep;
        private System.Windows.Forms.PictureBox pictureBoxParking;
    }
}