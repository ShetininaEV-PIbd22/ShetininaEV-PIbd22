using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormAvianos
{
    public partial class FormParking : Form
    {
        Parking<ITransport> parking;
        public FormParking() 
        {
            InitializeComponent(); 
            parking = new Parking<ITransport>(15, pictureBoxParking.Width, pictureBoxParking.Height);
            Draw(); 
        }
        private void Draw()
        { 
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height); 
            Graphics gr = Graphics.FromImage(bmp); 
            parking.Draw(gr); 
            pictureBoxParking.Image = bmp; 
        }
        private void buttonSetCar_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog(); 
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var shep = new Shep(100, 1050, dialog.Color);
                int place = parking + shep;
                Draw();
            } 
        }
        private void buttonSetSportCar_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog(); 
            if (dialog.ShowDialog() == DialogResult.OK) 
            { 
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK) 
                {
                    var shep = new Avianos(100, 1000, dialog.Color, dialogDop.Color, true, true, true, dialogDop.Color, true, true); 
                    int place = parking + shep;
                    Draw();
                }
            }
        }
        private void buttonTakeCar_Click(object sender, EventArgs e) 
        { 
            if (maskedTextBox.Text != "")
            {
                var shep = parking - Convert.ToInt32(maskedTextBox.Text); 
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
} 
