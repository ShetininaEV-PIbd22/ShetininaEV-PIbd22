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
    public partial class FormCarConfig : Form
    {
        ITransport shep = null;
        private event shepDelegate eventAddShep;
        public FormCarConfig()
        {
            InitializeComponent();
            
            buttonnCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        
        private void DrawShep()
        {
            if (shep != null)
            {
                Console.WriteLine("XColor in DrawShip: " + (shep as ITransport).GetMainColor());
                Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
                Graphics gr = Graphics.FromImage(bmp);
                shep.SetPosition(15, 5, pictureBox.Width, pictureBox.Height);
                shep.SetMainColor(Color.FromName((shep as ITransport).GetMainColor()));
                shep.DrawShep(gr);
                pictureBox.Image = bmp;
            }
        }
        public void AddEvent(shepDelegate ev)
        {
            if (eventAddShep == null)
            {
                eventAddShep = new shepDelegate(ev);
            }
            else
            {
                eventAddShep += ev;
            }
        }
        private void panelShep_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void panelShep_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Корабль":
                    shep = new Shep(100, 500, Color.White);
                    break;
                case "Авианосец":
                    shep = new Avianos(100, 500, Color.White, Color.Black, true, true,
                   true, Color.Black, true, true);
                    break;
            }
            DrawShep();
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
           DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// Принимаем основной цвет
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (shep != null)
            {
                
                shep.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                Console.WriteLine("Ship color after set: " + shep.GetMainColor());
                DrawShep();
            }
        }

        /// Принимаем дополнительный цвет
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (shep != null)
            {
                if (shep is Avianos)
                {
                    (shep as
                   Avianos).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawShep();
                }
            }
        }
        private void labelAvianosec_MouseDown(object sender, MouseEventArgs e)
        {
            labelAvianosec.DoDragDrop(labelAvianosec.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddShep?.Invoke(shep);
            Close();
        }
        
        private void lablelShep_MouseDown(object sender, MouseEventArgs e)
        {
            labelShep.DoDragDrop(labelShep.Text, DragDropEffects.Move |
            DragDropEffects.Copy);
        }
        
    }
}
