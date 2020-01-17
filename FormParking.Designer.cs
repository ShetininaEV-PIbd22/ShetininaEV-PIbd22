namespace WindowsFormsAppAvianos
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
            this.pictureBoxAvianos = new System.Windows.Forms.PictureBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TakeOut = new System.Windows.Forms.Button();
            this.pictureBoxTakeShep = new System.Windows.Forms.PictureBox();
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvianos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAvianos
            // 
            this.pictureBoxAvianos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAvianos.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAvianos.Name = "pictureBoxAvianos";
            this.pictureBoxAvianos.Size = new System.Drawing.Size(884, 461);
            this.pictureBoxAvianos.TabIndex = 5;
            this.pictureBoxAvianos.TabStop = false;
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(23, 188);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 6;
            this.buttonSet.Text = "Поставить";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(23, 42);
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
            this.TakeOut.Location = new System.Drawing.Point(34, 68);
            this.TakeOut.Name = "TakeOut";
            this.TakeOut.Size = new System.Drawing.Size(75, 23);
            this.TakeOut.TabIndex = 15;
            this.TakeOut.Text = "Забрать";
            this.TakeOut.UseVisualStyleBackColor = true;
            this.TakeOut.Click += new System.EventHandler(this.buttonTakeShep_Click);
            // 
            // pictureBoxTakeShep
            // 
            this.pictureBoxTakeShep.Location = new System.Drawing.Point(12, 97);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxLevels);
            this.groupBox2.Controls.Add(this.buttonSet);
            this.groupBox2.Location = new System.Drawing.Point(740, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 237);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Уровни";
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(12, 19);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(120, 121);
            this.listBoxLevels.TabIndex = 0;
            this.listBoxLevels.Click += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxTakeShep);
            this.groupBox1.Controls.Add(this.TakeOut);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(740, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 194);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забрать";
            // 
            // FormParking
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.pictureBoxAvianos);
            this.Name = "FormParking";
            this.Text = "Avianosec";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvianos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxAvianos;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TakeOut;
        private System.Windows.Forms.PictureBox pictureBoxTakeShep;
        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

