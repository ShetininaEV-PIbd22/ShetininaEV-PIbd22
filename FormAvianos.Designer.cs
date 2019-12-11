namespace WindowsFormAvianos
{
    partial class FormAvianosec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAvianosec));
            this.pictureBoxAvianos = new System.Windows.Forms.PictureBox();
            this.CreateShep = new System.Windows.Forms.Button();
            this.CreateAvianos = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvianos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvianos
            // 
            this.pictureBoxAvianos.Location = new System.Drawing.Point(0, -1);
            this.pictureBoxAvianos.Name = "pictureBoxAvianos";
            this.pictureBoxAvianos.Size = new System.Drawing.Size(799, 452);
            this.pictureBoxAvianos.TabIndex = 0;
            this.pictureBoxAvianos.TabStop = false;
            // 
            // CreateShep
            // 
            this.CreateShep.Location = new System.Drawing.Point(0, -1);
            this.CreateShep.Name = "CreateShep";
            this.CreateShep.Size = new System.Drawing.Size(75, 23);
            this.CreateShep.TabIndex = 1;
            this.CreateShep.Text = "Корабль";
            this.CreateShep.UseVisualStyleBackColor = true;
            this.CreateShep.Click += new System.EventHandler(this.CreateShep_Click);
            // 
            // CreateAvianos
            // 
            this.CreateAvianos.Location = new System.Drawing.Point(95, -1);
            this.CreateAvianos.Name = "CreateAvianos";
            this.CreateAvianos.Size = new System.Drawing.Size(75, 23);
            this.CreateAvianos.TabIndex = 2;
            this.CreateAvianos.Text = "Авианосец";
            this.CreateAvianos.UseVisualStyleBackColor = true;
            this.CreateAvianos.Click += new System.EventHandler(this.CreateAvianos_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(758, 386);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(734, 359);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 4;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(734, 421);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.UseVisualStyleBackColor = false;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(708, 386);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 6;
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // FormAvianosec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.CreateAvianos);
            this.Controls.Add(this.CreateShep);
            this.Controls.Add(this.pictureBoxAvianos);
            this.Name = "FormAvianosec";
            this.Text = "Avianos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvianos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvianos;
        private System.Windows.Forms.Button CreateShep;
        private System.Windows.Forms.Button CreateAvianos;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
    }
}

