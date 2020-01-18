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
            this.panelColor21 = new System.Windows.Forms.Panel();
            this.panelColor20 = new System.Windows.Forms.Panel();
            this.panelColor19 = new System.Windows.Forms.Panel();
            this.panelColor18 = new System.Windows.Forms.Panel();
            this.panelColor17 = new System.Windows.Forms.Panel();
            this.panelColor16 = new System.Windows.Forms.Panel();
            this.panelColor15 = new System.Windows.Forms.Panel();
            this.panelColor14 = new System.Windows.Forms.Panel();
            this.panelColor13 = new System.Windows.Forms.Panel();
            this.panelColor12 = new System.Windows.Forms.Panel();
            this.panelColor11 = new System.Windows.Forms.Panel();
            this.panelColor10 = new System.Windows.Forms.Panel();
            this.panelColor9 = new System.Windows.Forms.Panel();
            this.panelColor8 = new System.Windows.Forms.Panel();
            this.panelColor7 = new System.Windows.Forms.Panel();
            this.panelColor6 = new System.Windows.Forms.Panel();
            this.panelColor5 = new System.Windows.Forms.Panel();
            this.panelColor4 = new System.Windows.Forms.Panel();
            this.panelColor3 = new System.Windows.Forms.Panel();
            this.panelColor2 = new System.Windows.Forms.Panel();
            this.panelColor1 = new System.Windows.Forms.Panel();
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
            this.groupBoxColors.Controls.Add(this.panelColor21);
            this.groupBoxColors.Controls.Add(this.panelColor20);
            this.groupBoxColors.Controls.Add(this.panelColor19);
            this.groupBoxColors.Controls.Add(this.panelColor18);
            this.groupBoxColors.Controls.Add(this.panelColor17);
            this.groupBoxColors.Controls.Add(this.panelColor16);
            this.groupBoxColors.Controls.Add(this.panelColor15);
            this.groupBoxColors.Controls.Add(this.panelColor14);
            this.groupBoxColors.Controls.Add(this.panelColor13);
            this.groupBoxColors.Controls.Add(this.panelColor12);
            this.groupBoxColors.Controls.Add(this.panelColor11);
            this.groupBoxColors.Controls.Add(this.panelColor10);
            this.groupBoxColors.Controls.Add(this.panelColor9);
            this.groupBoxColors.Controls.Add(this.panelColor8);
            this.groupBoxColors.Controls.Add(this.panelColor7);
            this.groupBoxColors.Controls.Add(this.panelColor6);
            this.groupBoxColors.Controls.Add(this.panelColor5);
            this.groupBoxColors.Controls.Add(this.panelColor4);
            this.groupBoxColors.Controls.Add(this.panelColor3);
            this.groupBoxColors.Controls.Add(this.panelColor2);
            this.groupBoxColors.Controls.Add(this.panelColor1);
            this.groupBoxColors.Location = new System.Drawing.Point(565, 26);
            this.groupBoxColors.Name = "groupBox2";
            this.groupBoxColors.Size = new System.Drawing.Size(223, 412);
            this.groupBoxColors.TabIndex = 3;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelColor21
            /Colors 
            tColorsis.panelColor21.BackColor = System.Drawing.Color.Orange;
            tColorsis.panelColor21.Location = new System.Drawing.Point(156, 334);
            this.panelColor21.Name = "panel21";
            this.panelColor21.Size = new System.Drawing.Size(51, 53);
            this.panelColor21.TabIndex = 20;
            this.panelColor21.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor20
            // 
            this.panelColor20.BackColor = System.Drawing.Color.SaddleBrown;
            this.panelColor20.Location = new System.Drawing.Point(156, 286);
            this.panelColor20.Name = "panel20";
            this.panelColor20.Size = new System.Drawing.Size(51, 42);
            this.panelColor20.TabIndex = 19;
            this.panelColor20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel19
            // 
            this.panelColor19.BackColor = System.Drawing.Color.White;
            this.panelColor19.Location = new System.Drawing.Point(156, 233);
            this.panelColor19.Name = "panel19";
            this.panelColor19.Size = new System.Drawing.Size(51, 47);
            this.panelColor19.TabIndex = 18;
            this.panelColor19.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor18
            // 
            this.panelColor18.BackColor = System.Drawing.Color.DeepPink;
            this.panelColor18.Location = new System.Drawing.Point(156, 181);
            this.panelColor18.Name = "panel18";
            this.panelColor18.Size = new System.Drawing.Size(51, 46);
            this.panelColor18.TabIndex = 17;
            this.panelColor18.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor17
            // 
            this.panelColor17.BackColor = System.Drawing.Color.Purple;
            this.panelColor17.Location = new System.Drawing.Point(156, 131);
            this.panelColor17.Name = "panel17";
            this.panelColor17.Size = new System.Drawing.Size(51, 44);
            this.panelColor17.TabIndex = 16;
            this.panelColor17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor16
            // 
            this.panelColor16.BackColor = System.Drawing.Color.BlueViolet;
            this.panelColor16.Location = new System.Drawing.Point(156, 83);
            this.panelColor16.Name = "panel16";
            this.panelColor16.Size = new System.Drawing.Size(51, 42);
            this.panelColor16.TabIndex = 15;
            this.panelColor16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor15
            // 
            this.panelColor15.BackColor = System.Drawing.Color.Indigo;
            this.panelColor15.Location = new System.Drawing.Point(156, 31);
            this.panelColor15.Name = "panel15";
            this.panelColor15.Size = new System.Drawing.Size(51, 46);
            this.panelColor15.TabIndex = 14;
            this.panelColor15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor14
            // 
            this.panelColor14.BackColor = System.Drawing.Color.DarkBlue;
            this.panelColor14.Location = new System.Drawing.Point(89, 337);
            this.panelColor14.Name = "panel14";
            this.panelColor14.Size = new System.Drawing.Size(47, 50);
            this.panelColor14.TabIndex = 13;
            this.panelColor14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor13
            // 
            this.panelColor13.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelColor13.Location = new System.Drawing.Point(89, 286);
            this.panelColor13.Name = "panel13";
            this.panelColor13.Size = new System.Drawing.Size(47, 43);
            this.panelColor13.TabIndex = 12;
            this.panelColor13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor12
            // 
            this.panelColor12.BackColor = System.Drawing.Color.Aqua;
            this.panelColor12.Location = new System.Drawing.Point(89, 233);
            this.panelColor12.Name = "panel12";
            this.panelColor12.Size = new System.Drawing.Size(47, 47);
            this.panelColor12.TabIndex = 11;
            this.panelColor12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor11
            // 
            this.panelColor11.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelColor11.Location = new System.Drawing.Point(89, 181);
            this.panelColor11.Name = "panel11";
            this.panelColor11.Size = new System.Drawing.Size(47, 46);
            this.panelColor11.TabIndex = 10;
            this.panelColor11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor10
            // 
            this.panelColor10.BackColor = System.Drawing.Color.Turquoise;
            this.panelColor10.Location = new System.Drawing.Point(89, 132);
            this.panelColor10.Name = "panel10";
            this.panelColor10.Size = new System.Drawing.Size(47, 43);
            this.panelColor10.TabIndex = 9;
            this.panelColor10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor9
            // 
            this.panelColor9.BackColor = System.Drawing.Color.Lime;
            this.panelColor9.Location = new System.Drawing.Point(89, 83);
            this.panelColor9.Name = "panel9";
            this.panelColor9.Size = new System.Drawing.Size(46, 42);
            this.panelColor9.TabIndex = 8;
            this.panelColor9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor8
            // 
            this.panelColor8.BackColor = System.Drawing.Color.Chartreuse;
            this.panelColor8.Location = new System.Drawing.Point(89, 33);
            this.panelColor8.Name = "panel8";
            this.panelColor8.Size = new System.Drawing.Size(46, 44);
            this.panelColor8.TabIndex = 7;
            this.panelColor8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor7
            // 
            this.panelColor7.BackColor = System.Drawing.Color.ForestGreen;
            this.panelColor7.Location = new System.Drawing.Point(17, 337);
            this.panelColor7.Name = "panel7";
            this.panelColor7.Size = new System.Drawing.Size(47, 50);
            this.panelColor7.TabIndex = 6;
            this.panelColor7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor6
            // 
            this.panelColor6.BackColor = System.Drawing.Color.Yellow;
            this.panelColor6.Location = new System.Drawing.Point(17, 286);
            this.panelColor6.Name = "panel6";
            this.panelColor6.Size = new System.Drawing.Size(47, 43);
            this.panelColor6.TabIndex = 5;
            this.panelColor6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor5
            // 
            this.panelColor5.BackColor = System.Drawing.Color.OrangeRed;
            this.panelColor5.Location = new System.Drawing.Point(17, 233);
            this.panelColor5.Name = "panel5";
            this.panelColor5.Size = new System.Drawing.Size(47, 47);
            this.panelColor5.TabIndex = 4;
            this.panelColor5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor4
            // 
            this.panelColor4.BackColor = System.Drawing.Color.Red;
            this.panelColor4.Location = new System.Drawing.Point(17, 181);
            this.panelColor4.Name = "panel4";
            this.panelColor4.Size = new System.Drawing.Size(47, 46);
            this.panelColor4.TabIndex = 3;
            this.panelColor4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor3
            // 
            this.panelColor3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelColor3.Location = new System.Drawing.Point(17, 131);
            this.panelColor3.Name = "panel3";
            this.panelColor3.Size = new System.Drawing.Size(47, 44);
            this.panelColor3.TabIndex = 2;
            this.panelColor3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor2
            // 
            this.panelColor2.BackColor = System.Drawing.Color.Gray;
            this.panelColor2.Location = new System.Drawing.Point(17, 83);
            this.panelColor2.Name = "panel2";
            this.panelColor2.Size = new System.Drawing.Size(47, 42);
            this.panelColor2.TabIndex = 1;
            this.panelColor2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor1
            // 
            this.panelColor1.BackColor = System.Drawing.Color.Black;
            this.panelColor1.Location = new System.Drawing.Point(17, 31);
            this.panelColor1.Name = "panel1";
            this.panelColor1.Size = new System.Drawing.Size(47, 46);
            this.panelColor1.TabIndex = 0;
            this.panelColor1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
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
        private System.Windows.Forms.Panel panelColor21;
        private System.Windows.Forms.Panel panelColor20;
        private System.Windows.Forms.Panel panelColor19;
        private System.Windows.Forms.Panel panelColor18;
        private System.Windows.Forms.Panel panelColor17;
        private System.Windows.Forms.Panel panelColor16;
        private System.Windows.Forms.Panel panelColor15;
        private System.Windows.Forms.Panel panelColor14;
        private System.Windows.Forms.Panel panelColor13;
        private System.Windows.Forms.Panel panelColor12;
        private System.Windows.Forms.Panel panelColor11;
        private System.Windows.Forms.Panel panelColor10;
        private System.Windows.Forms.Panel panelColor9;
        private System.Windows.Forms.Panel panelColor8;
        private System.Windows.Forms.Panel panelColor7;
        private System.Windows.Forms.Panel panelColor6;
        private System.Windows.Forms.Panel panelColor5;
        private System.Windows.Forms.Panel panelColor4;
        private System.Windows.Forms.Panel panelColor3;
        private System.Windows.Forms.Panel panelColor2;
        private System.Windows.Forms.Panel panelColor1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonnCancel;
        private System.Windows.Forms.Label labelDopColor;
    }
}

