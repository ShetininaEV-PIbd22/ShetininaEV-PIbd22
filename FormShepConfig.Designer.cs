namespace WindowsFormsAppAvianos
{
    partial class FormCarConfig
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.labelAvianosec = new System.Windows.Forms.Label();
            this.labelShep = new System.Windows.Forms.Label();
            this.panelShep = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();

            this.Orange = new System.Windows.Forms.Panel();
            this.SaddleBrown = new System.Windows.Forms.Panel();

            this.White = new System.Windows.Forms.Panel();
            this.DeepPink = new System.Windows.Forms.Panel();
            this.Purple = new System.Windows.Forms.Panel();
            this.BlueViolet = new System.Windows.Forms.Panel();
            this.Indigo = new System.Windows.Forms.Panel();
            this.DarkBlue = new System.Windows.Forms.Panel();
            this.RoyalBlue = new System.Windows.Forms.Panel();
            this.Aqua = new System.Windows.Forms.Panel();
            this.LightSeaGreen = new System.Windows.Forms.Panel();
            this.Turquoise = new System.Windows.Forms.Panel();

            this.Lime = new System.Windows.Forms.Panel();

            this.Chartreuse = new System.Windows.Forms.Panel();
            this.ForestGreen = new System.Windows.Forms.Panel();
            this.Yellow = new System.Windows.Forms.Panel();
            this.OrangeRed = new System.Windows.Forms.Panel();
            this.Red = new System.Windows.Forms.Panel();

            this.Highlight = new System.Windows.Forms.Panel();
            this.Gray= new System.Windows.Forms.Panel();

            this.Black= new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBoxType.SuspendLayout();
            this.panelShep.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(33, 31);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(190, 109);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.labelAvianosec);
            this.groupBoxType.Controls.Add(this.labelShep);
            this.groupBoxType.Location = new System.Drawing.Point(12, 12);
            this.groupBoxType.Name = "groupBox1";
            this.groupBoxType.Size = new System.Drawing.Size(237, 176);
            this.groupBoxType.TabIndex = 1;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Тип корабля";
            // 
            // labelAvianosec
            // 
            this.labelAvianosec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAvianosec.Location = new System.Drawing.Point(32, 107);
            this.labelAvianosec.Name = "labelAvianosec";
            this.labelAvianosec.Size = new System.Drawing.Size(170, 47);
            this.labelAvianosec.TabIndex = 1;
            this.labelAvianosec.Text = "Авианосец";
            this.labelAvianosec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAvianosec.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShep_DragDrop);
            this.labelAvianosec.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShep_DragEnter);
            this.labelAvianosec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAvianosec_MouseDown);
            // 
            // labelShep
            // 
            this.labelShep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShep.Location = new System.Drawing.Point(32, 41);
            this.labelShep.Name = "labelShep";
            this.labelShep.Size = new System.Drawing.Size(170, 50);
            this.labelShep.TabIndex = 0;
            this.labelShep.Text = "Корабль";
            this.labelShep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShep.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShep_DragDrop);
            this.labelShep.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShep_DragEnter);
            this.labelShep.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lablelShep_MouseDown);
            // 
            // panelShep
            // 
            this.panelShep.AllowDrop = true;
            this.panelShep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShep.Controls.Add(this.labelDopColor);
            this.panelShep.Controls.Add(this.labelBaseColor);
            this.panelShep.Controls.Add(this.pictureBox);
            this.panelShep.Location = new System.Drawing.Point(276, 26);
            this.panelShep.Name = "panelCar";
            this.panelShep.Size = new System.Drawing.Size(257, 329);
            this.panelShep.TabIndex = 2;
            this.panelShep.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShep_DragDrop);
            this.panelShep.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShep_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(46, 253);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(155, 50);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Дополнительный цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(43, 174);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(158, 53);
            this.labelBaseColor.TabIndex = 1;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.Orange);
            this.groupBoxColors.Controls.Add(this.SaddleBrown);
            this.groupBoxColors.Controls.Add(this.White);
            this.groupBoxColors.Controls.Add(this.DeepPink);
            this.groupBoxColors.Controls.Add(this.Purple);
            this.groupBoxColors.Controls.Add(this.BlueViolet);
            this.groupBoxColors.Controls.Add(this.Indigo);
            this.groupBoxColors.Controls.Add(this.DarkBlue);
            this.groupBoxColors.Controls.Add(this.RoyalBlue);
            this.groupBoxColors.Controls.Add(this.Aqua);
            this.groupBoxColors.Controls.Add(this.LightSeaGreen);
            this.groupBoxColors.Controls.Add(this.Turquoise);
            this.groupBoxColors.Controls.Add(this.Lime);
            this.groupBoxColors.Controls.Add(this.Chartreuse);
            this.groupBoxColors.Controls.Add(this.ForestGreen);
            this.groupBoxColors.Controls.Add(this.Yellow);
            this.groupBoxColors.Controls.Add(this.OrangeRed);
            this.groupBoxColors.Controls.Add(this.Red);
            this.groupBoxColors.Controls.Add(this.Highlight);
            this.groupBoxColors.Controls.Add(this.Gray);
            this.groupBoxColors.Controls.Add(this.Black);
            this.groupBoxColors.Location = new System.Drawing.Point(565, 26);
            this.groupBoxColors.Name = "groupBox2";

            this.groupBoxColors.Size = new System.Drawing.Size(223, 412);

            this.groupBoxColors.TabIndex = 3;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // Orange

            /Colors 
            tColorsis.Orange.BackColor = System.Drawing.Color.Orange;
            tColorsis.Orange.Location = new System.Drawing.Point(156, 334);

            this.Orange.Name = "panel21";
            this.Orange.Size = new System.Drawing.Size(51, 53);
            this.Orange.TabIndex = 20;
            this.Orange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // SaddleBrown
            // 
            this.SaddleBrown.BackColor = System.Drawing.Color.SaddleBrown;
            this.SaddleBrown.Location = new System.Drawing.Point(156, 286);
            this.SaddleBrown.Name = "panel20";
            this.SaddleBrown.Size = new System.Drawing.Size(51, 42);
            this.SaddleBrown.TabIndex = 19;
            this.SaddleBrown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // White
            // 
            this.White.BackColor = System.Drawing.Color.White;
            this.White.Location = new System.Drawing.Point(156, 233);
            this.White.Name = "panel19";
            this.White.Size = new System.Drawing.Size(51, 47);
            this.White.TabIndex = 18;
            this.White.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // DeepPink
            // 
            this.DeepPink.BackColor = System.Drawing.Color.DeepPink;
            this.DeepPink.Location = new System.Drawing.Point(156, 181);
            this.DeepPink.Name = "panel18";
            this.DeepPink.Size = new System.Drawing.Size(51, 46);
            this.DeepPink.TabIndex = 17;
            this.DeepPink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Purple
            // 
            this.Purple.BackColor = System.Drawing.Color.Purple;
            this.Purple.Location = new System.Drawing.Point(156, 131);
            this.Purple.Name = "panel17";
            this.Purple.Size = new System.Drawing.Size(51, 44);
            this.Purple.TabIndex = 16;
            this.Purple.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // BlueViolet
            // 
            this.BlueViolet.BackColor = System.Drawing.Color.BlueViolet;
            this.BlueViolet.Location = new System.Drawing.Point(156, 83);
            this.BlueViolet.Name = "panel16";
            this.BlueViolet.Size = new System.Drawing.Size(51, 42);
            this.BlueViolet.TabIndex = 15;
            this.BlueViolet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Indigo
            // 
            this.Indigo.BackColor = System.Drawing.Color.Indigo;
            this.Indigo.Location = new System.Drawing.Point(156, 31);
            this.Indigo.Name = "panel15";
            this.Indigo.Size = new System.Drawing.Size(51, 46);
            this.Indigo.TabIndex = 14;
            this.Indigo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // DarkBlue
            // 
            this.DarkBlue.BackColor = System.Drawing.Color.DarkBlue;
            this.DarkBlue.Location = new System.Drawing.Point(89, 337);
            this.DarkBlue.Name = "panel14";
            this.DarkBlue.Size = new System.Drawing.Size(47, 50);
            this.DarkBlue.TabIndex = 13;
            this.DarkBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // RoyalBlue
            // 
            this.RoyalBlue.BackColor = System.Drawing.Color.RoyalBlue;
            this.RoyalBlue.Location = new System.Drawing.Point(89, 286);
            this.RoyalBlue.Name = "panel13";
            this.RoyalBlue.Size = new System.Drawing.Size(47, 43);
            this.RoyalBlue.TabIndex = 12;
            this.RoyalBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Aqua
            // 
            this.Aqua.BackColor = System.Drawing.Color.Aqua;
            this.Aqua.Location = new System.Drawing.Point(89, 233);
            this.Aqua.Name = "panel12";
            this.Aqua.Size = new System.Drawing.Size(47, 47);
            this.Aqua.TabIndex = 11;
            this.Aqua.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // LightSeaGreen
            // 
            this.LightSeaGreen.BackColor = System.Drawing.Color.LightSeaGreen;
            this.LightSeaGreen.Location = new System.Drawing.Point(89, 181);
            this.LightSeaGreen.Name = "panel11";
            this.LightSeaGreen.Size = new System.Drawing.Size(47, 46);
            this.LightSeaGreen.TabIndex = 10;
            this.LightSeaGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Turquoise
            // 
            this.Turquoise.BackColor = System.Drawing.Color.Turquoise;
            this.Turquoise.Location = new System.Drawing.Point(89, 132);
            this.Turquoise.Name = "panel10";
            this.Turquoise.Size = new System.Drawing.Size(47, 43);
            this.Turquoise.TabIndex = 9;
            this.Turquoise.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Lime
            // 
            this.Lime.BackColor = System.Drawing.Color.Lime;
            this.Lime.Location = new System.Drawing.Point(89, 83);
            this.Lime.Name = "panel9";
            this.Lime.Size = new System.Drawing.Size(46, 42);
            this.Lime.TabIndex = 8;
            this.Lime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Chartreuse
            // 
            this.Chartreuse.BackColor = System.Drawing.Color.Chartreuse;
            this.Chartreuse.Location = new System.Drawing.Point(89, 33);
            this.Chartreuse.Name = "panel8";
            this.Chartreuse.Size = new System.Drawing.Size(46, 44);
            this.Chartreuse.TabIndex = 7;
            this.Chartreuse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // ForestGreen
            // 
            this.ForestGreen.BackColor = System.Drawing.Color.ForestGreen;
            this.ForestGreen.Location = new System.Drawing.Point(17, 337);
            this.ForestGreen.Name = "panel7";
            this.ForestGreen.Size = new System.Drawing.Size(47, 50);
            this.ForestGreen.TabIndex = 6;
            this.ForestGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(17, 286);
            this.Yellow.Name = "panel6";
            this.Yellow.Size = new System.Drawing.Size(47, 43);
            this.Yellow.TabIndex = 5;
            this.Yellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // OrangeRed
            // 
            this.OrangeRed.BackColor = System.Drawing.Color.OrangeRed;
            this.OrangeRed.Location = new System.Drawing.Point(17, 233);
            this.OrangeRed.Name = "panel5";
            this.OrangeRed.Size = new System.Drawing.Size(47, 47);
            this.OrangeRed.TabIndex = 4;
            this.OrangeRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(17, 181);
            this.Red.Name = "panel4";
            this.Red.Size = new System.Drawing.Size(47, 46);
            this.Red.TabIndex = 3;
            this.Red.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Highlight
            // 
            this.Highlight.BackColor = System.Drawing.SystemColors.Highlight;
            this.Highlight.Location = new System.Drawing.Point(17, 131);
            this.Highlight.Name = "panel3";
            this.Highlight.Size = new System.Drawing.Size(47, 44);
            this.Highlight.TabIndex = 2;
            this.Highlight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Gray
            // 
            this.Gray.BackColor = System.Drawing.Color.Gray;
            this.Gray.Location = new System.Drawing.Point(17, 83);
            this.Gray.Name = "panel2";
            this.Gray.Size = new System.Drawing.Size(47, 42);
            this.Gray.TabIndex = 1;
            this.Gray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.Location = new System.Drawing.Point(17, 31);
            this.Black.Name = "panel1";
            this.Black.Size = new System.Drawing.Size(47, 46);
            this.Black.TabIndex = 0;
            this.Black.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 230);
            this.buttonOk.Name = "button1";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonnCancel
            // 
            this.buttonnCancel.Location = new System.Drawing.Point(111, 283);
            this.buttonnCancel.Name = "buttonnCancel";
            this.buttonnCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonnCancel.TabIndex = 5;
            this.buttonnCancel.Text = "Отмена";
            this.buttonnCancel.UseVisualStyleBackColor = true;
            // 
            // FormCarConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonnCancel);
            this.Controls.Add(this.buttonOk);

            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelShep);
            this.Controls.Add(this.groupBoxType);

            this.Name = "FormCarConfig";
            this.Text = "Выбор коробля";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBoxType.ResumeLayout(false);
            this.panelShep.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.Label labelAvianosec;
        private System.Windows.Forms.Label labelShep;
        private System.Windows.Forms.Panel panelShep;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel Orange;
        private System.Windows.Forms.Panel SaddleBrown;
        private System.Windows.Forms.Panel White;
        private System.Windows.Forms.Panel DeepPink;
        private System.Windows.Forms.Panel Purple;
        private System.Windows.Forms.Panel BlueViolet;
        private System.Windows.Forms.Panel Indigo;
        private System.Windows.Forms.Panel DarkBlue;
        private System.Windows.Forms.Panel RoyalBlue;
        private System.Windows.Forms.Panel Aqua;
        private System.Windows.Forms.Panel LightSeaGreen;
        private System.Windows.Forms.Panel Turquoise;
        private System.Windows.Forms.Panel Lime;
        private System.Windows.Forms.Panel Chartreuse;
        private System.Windows.Forms.Panel ForestGreen;
        private System.Windows.Forms.Panel Yellow;
        private System.Windows.Forms.Panel OrangeRed;
        private System.Windows.Forms.Panel Red;
        private System.Windows.Forms.Panel Highlight;
        private System.Windows.Forms.Panel Gray;
        private System.Windows.Forms.Panel Black;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonnCancel;
        private System.Windows.Forms.Label labelDopColor;
    }
}

