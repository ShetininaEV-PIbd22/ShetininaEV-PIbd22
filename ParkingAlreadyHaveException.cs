using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppAvianos
{
    /// Класс-ошибка "Если на парковке уже есть  с такими же характеристиками"
    public class ParkingAlreadyHaveException : Exception
    {
        public ParkingAlreadyHaveException() : base("Уже есть такой корабль")
        { }
    }
}
