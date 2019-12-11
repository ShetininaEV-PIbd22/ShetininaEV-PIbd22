namespace WindowsFormAvianos
{
    partial class FormParking
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.Shep = new System.Windows.Forms.Button();
            this.Avianos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TakeOut = new System.Windows.Forms.Button();
            this.pictureBoxTakeShep = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShep)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(667, 452);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // Shep
            // 
            this.Shep.Location = new System.Drawing.Point(724, 0);
            this.Shep.Name = "Shep";
            this.Shep.Size = new System.Drawing.Size(75, 23);
            this.Shep.TabIndex = 1;
            this.Shep.Text = "Shep";
            this.Shep.UseVisualStyleBackColor = true;
            this.Shep.Click += new System.EventHandler(this.buttonSetCar_Click);
            // 
            // Avianos
            // 
            this.Avianos.Location = new System.Drawing.Point(724, 29);
            this.Avianos.Name = "Avianos";
            this.Avianos.Size = new System.Drawing.Size(75, 23);
            this.Avianos.TabIndex = 2;
            this.Avianos.Text = "Avianos";
            this.Avianos.UseVisualStyleBackColor = true;
            this.Avianos.Click += new System.EventHandler(this.buttonSetSportCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(673, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Заберите судно";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(685, 283);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(88, 20);
            this.maskedTextBox.TabIndex = 4;
            // 
            // TakeOut
            // 
            this.TakeOut.Location = new System.Drawing.Point(698, 319);
            this.TakeOut.Name = "TakeOut";
            this.TakeOut.Size = new System.Drawing.Size(75, 23);
            this.TakeOut.TabIndex = 5;
            this.TakeOut.Text = "Забрать";
            this.TakeOut.UseVisualStyleBackColor = true;
            this.TakeOut.Click += new System.EventHandler(this.buttonTakeCar_Click);
            // 
            // pictureBoxTakeShep
            // 
            this.pictureBoxTakeShep.Location = new System.Drawing.Point(673, 348);
            this.pictureBoxTakeShep.Name = "pictureBoxTakeShep";
            this.pictureBoxTakeShep.Size = new System.Drawing.Size(126, 90);
            this.pictureBoxTakeShep.TabIndex = 6;
            this.pictureBoxTakeShep.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Место";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxTakeShep);
            this.Controls.Add(this.TakeOut);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Avianos);
            this.Controls.Add(this.Shep);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Avianosech";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button Shep;
        private System.Windows.Forms.Button Avianos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Button TakeOut;
        private System.Windows.Forms.PictureBox pictureBoxTakeShep;
        private System.Windows.Forms.Label label2;
    }
}

