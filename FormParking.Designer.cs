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
            this.label2 = new System.Windows.Forms.Label();
            this.TakeOut = new System.Windows.Forms.Button();
            this.pictureBoxTakeShep = new System.Windows.Forms.PictureBox();
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Shep
            // 
            this.Shep.Location = new System.Drawing.Point(43, 146);
            this.Shep.Name = "Shep";
            this.Shep.Size = new System.Drawing.Size(75, 23);
            this.Shep.TabIndex = 6;
            this.Shep.Text = "Shep";
            this.Shep.UseVisualStyleBackColor = true;
            this.Shep.Click += new System.EventHandler(this.buttonSetShep_Click);
            // 
            // Avianos
            // 
            this.Avianos.Location = new System.Drawing.Point(43, 187);
            this.Avianos.Name = "Avianos";
            this.Avianos.Size = new System.Drawing.Size(75, 23);
            this.Avianos.TabIndex = 11;
            this.Avianos.Text = "Avianos";
            this.Avianos.UseVisualStyleBackColor = true;
            this.Avianos.Click += new System.EventHandler(this.buttonSetAvianos_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(22, 36);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(96, 20);
            this.maskedTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Место";
            // 
            // TakeOut
            // 
            this.TakeOut.Location = new System.Drawing.Point(34, 62);
            this.TakeOut.Name = "TakeOut";
            this.TakeOut.Size = new System.Drawing.Size(75, 23);
            this.TakeOut.TabIndex = 15;
            this.TakeOut.Text = "Забрать";
            this.TakeOut.UseVisualStyleBackColor = true;
            this.TakeOut.Click += new System.EventHandler(this.buttonTakeShep_Click);
            // 
            // pictureBoxTakeShep
            // 
            this.pictureBoxTakeShep.Location = new System.Drawing.Point(12, 91);
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
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(18, 19);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(120, 121);
            this.listBoxLevels.TabIndex = 0;
            this.listBoxLevels.Click += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TakeOut);
            this.groupBox1.Controls.Add(this.pictureBoxTakeShep);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Location = new System.Drawing.Point(740, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 194);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забрать";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxLevels);
            this.groupBox2.Controls.Add(this.Shep);
            this.groupBox2.Controls.Add(this.Avianos);
            this.groupBox2.Location = new System.Drawing.Point(740, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 237);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Уровни";
            // 
            // FormParking
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Avianosec";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Shep;
        private System.Windows.Forms.Button Avianos;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TakeOut;
        private System.Windows.Forms.PictureBox pictureBoxTakeShep;
        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}