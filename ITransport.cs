using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormAvianos
{
   public interface ITransport
    {
        /// Установка позиции автомобиля
        void SetPosition(int x, int y, int width, int height);
        /// Изменение направления пермещения
        void MoveTransport(Direction direction);
        void DrawShep(Graphics g);
    }
}
