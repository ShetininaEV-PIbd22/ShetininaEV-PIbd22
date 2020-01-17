﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAvianos
{
    public partial class FormParking : Form
    {
        MultiLevelParking parking;
        private const int countLevel = 5;
        public FormParking()
        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width, pictureBoxParking.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                //если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран
                //и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }
        private void buttonSetShep_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var shep = new Shep(100, 1000, dialog.Color);
                    int place = parking[listBoxLevels.SelectedIndex] + shep;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }
        private void buttonSetAvianos_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var shep = new Avianos(100, 1000, dialog.Color, dialogDop.Color, true, true, true, dialogDop.Color, true, true);
                        int place = parking[listBoxLevels.SelectedIndex] + shep;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
            }
        }
        private void buttonTakeShep_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    var shep = parking[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBox.Text);
                    if (shep != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeShep.Width, pictureBoxTakeShep.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        shep.SetPosition(15, 5, pictureBoxTakeShep.Width, pictureBoxTakeShep.Height);
                        shep.DrawShep(gr);
                        pictureBoxTakeShep.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeShep.Width, pictureBoxTakeShep.Height);
                        pictureBoxTakeShep.Image = bmp;
                    }
                    Draw();
                }
            }
        }
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
