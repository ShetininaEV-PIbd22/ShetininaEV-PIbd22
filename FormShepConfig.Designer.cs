namespace WindowsFormsAppAvianos
{
    partial class FormShepConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAvianosec = new System.Windows.Forms.Label();
            this.labelShep = new System.Windows.Forms.Label();
            this.panelCar = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelCar.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAvianosec);
            this.groupBox1.Controls.Add(this.labelShep);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип корабля";
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
            // panelCar
            // 
            this.panelCar.AllowDrop = true;
            this.panelCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCar.Controls.Add(this.labelDopColor);
            this.panelCar.Controls.Add(this.labelBaseColor);
            this.panelCar.Controls.Add(this.pictureBox);
            this.panelCar.Location = new System.Drawing.Point(276, 26);
            this.panelCar.Name = "panelCar";
            this.panelCar.Size = new System.Drawing.Size(257, 329);
            this.panelCar.TabIndex = 2;
            this.panelCar.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShep_DragDrop);
            this.panelCar.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShep_DragEnter);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel21);
            this.groupBox2.Controls.Add(this.panel20);
            this.groupBox2.Controls.Add(this.panel19);
            this.groupBox2.Controls.Add(this.panel18);
            this.groupBox2.Controls.Add(this.panel17);
            this.groupBox2.Controls.Add(this.panel16);
            this.groupBox2.Controls.Add(this.panel15);
            this.groupBox2.Controls.Add(this.panel14);
            this.groupBox2.Controls.Add(this.panel13);
            this.groupBox2.Controls.Add(this.panel12);
            this.groupBox2.Controls.Add(this.panel11);
            this.groupBox2.Controls.Add(this.panel10);
            this.groupBox2.Controls.Add(this.panel9);
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(565, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 412);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.Orange;
            this.panel21.Location = new System.Drawing.Point(156, 334);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(51, 53);
            this.panel21.TabIndex = 20;
            this.panel21.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel20.Location = new System.Drawing.Point(156, 286);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(51, 42);
            this.panel20.TabIndex = 19;
            this.panel20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel19.Location = new System.Drawing.Point(156, 233);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(51, 47);
            this.panel19.TabIndex = 18;
            this.panel19.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.DeepPink;
            this.panel18.Location = new System.Drawing.Point(156, 181);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(51, 46);
            this.panel18.TabIndex = 17;
            this.panel18.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Purple;
            this.panel17.Location = new System.Drawing.Point(156, 131);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(51, 44);
            this.panel17.TabIndex = 16;
            this.panel17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.BlueViolet;
            this.panel16.Location = new System.Drawing.Point(156, 83);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(51, 42);
            this.panel16.TabIndex = 15;
            this.panel16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Indigo;
            this.panel15.Location = new System.Drawing.Point(156, 31);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(51, 46);
            this.panel15.TabIndex = 14;
            this.panel15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.DarkBlue;
            this.panel14.Location = new System.Drawing.Point(89, 337);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(47, 50);
            this.panel14.TabIndex = 13;
            this.panel14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel13.Location = new System.Drawing.Point(89, 286);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(47, 43);
            this.panel13.TabIndex = 12;
            this.panel13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Aqua;
            this.panel12.Location = new System.Drawing.Point(89, 233);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(47, 47);
            this.panel12.TabIndex = 11;
            this.panel12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel11.Location = new System.Drawing.Point(89, 181);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(47, 46);
            this.panel11.TabIndex = 10;
            this.panel11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Turquoise;
            this.panel10.Location = new System.Drawing.Point(89, 132);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(47, 43);
            this.panel10.TabIndex = 9;
            this.panel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Lime;
            this.panel9.Location = new System.Drawing.Point(89, 83);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(46, 42);
            this.panel9.TabIndex = 8;
            this.panel9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Chartreuse;
            this.panel8.Location = new System.Drawing.Point(89, 33);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(46, 44);
            this.panel8.TabIndex = 7;
            this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.ForestGreen;
            this.panel7.Location = new System.Drawing.Point(17, 337);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(47, 50);
            this.panel7.TabIndex = 6;
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Yellow;
            this.panel6.Location = new System.Drawing.Point(17, 286);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(47, 43);
            this.panel6.TabIndex = 5;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.OrangeRed;
            this.panel5.Location = new System.Drawing.Point(17, 233);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(47, 47);
            this.panel5.TabIndex = 4;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(17, 181);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(47, 46);
            this.panel4.TabIndex = 3;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(17, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(47, 44);
            this.panel3.TabIndex = 2;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(17, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(47, 42);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(17, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 46);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonOk_Click);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelCar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCarConfig";
            this.Text = "Выбор коробля";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelCar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAvianosec;
        private System.Windows.Forms.Label labelShep;
        private System.Windows.Forms.Panel panelCar;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonnCancel;
        private System.Windows.Forms.Label labelDopColor;
    }
}

