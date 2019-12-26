using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormAvianos
{
    public class MultiLevelParking
    {
        /// Список с уровнями парковки 
        List<Parking<ITransport>> parkingStages;
        /// Сколько мест на каждом уровне 
        private const int countPlaces = 15;
        /// Ширина окна отрисовки
        /// </summary>
        private int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int pictureHeight;
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
            }
        }
        /// Индексатор 
        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        //запись в файл
        public void SaveData(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            using (sw)
            {
                sw.WriteLine("CountLeveles:" + parkingStages.Count);
                foreach (var level in parkingStages)
                {
                    //Начинаем уровень
                    sw.Write("Level" + Environment.NewLine);
                    for (int i = 0; i < countPlaces; i++)
                    {
                        try
                        {
                            var shep = level[i];
                            if (shep != null)
                            {
                                //если место не пустое
                                //Записываем тип мшаины
                                if (shep.GetType().Name == "Shep")
                                {
                                    sw.Write(i + ":Shep:");
                                }
                                if (shep.GetType().Name == "Avianos")
                                {
                                    sw.Write(i + ":Avianos:");
                                }
                                //Записываемые параметры
                                sw.Write(shep + Environment.NewLine);
                            }
                        }
                        finally { }
                    }
                }
            }
            sw.Close();
        }
        /// Загрузка нформации из файла
        public void LoadData(string filename)
        {
            Parking<ITransport> park = null;
            StreamReader sr = new StreamReader(filename);
            using (sr)
            {
                string line = sr.ReadLine();
                var strs = line.Split(':');
                if (strs[0] == "CountLeveles")
                {
                    int count = int.Parse(strs[1]);
                    parkingStages = new List<Parking<ITransport>>(count);
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        strs = line.Split(':');
                        if (line == "Level")
                        {
                            park = new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight);
                            parkingStages.Add(park);
                        }
                        if ((strs.Length == 3) && (park != null))
                        {
                            Console.WriteLine(park.CheckFreePlace(int.Parse(strs[0])));
                            if (park.CheckFreePlace(int.Parse(strs[0])) == true)
                            {
                                var sss = strs[2].Split(';');
                                if (strs[1] == "Shep" && sss.Length == 3)
                                {
                                    int n = park + new Shep(strs[2]);
                                }
                                else if (strs[1] == "Avianos" && sss.Length == 10)
                                {
                                    int n = park + new Avianos(strs[2]);
                                }
                            }
                            else
                            {
                                throw new ParkingOccupiedPlaceException(int.Parse(strs[0]));
                            }
                        }
                    }
                }
                else
                {
                    throw new Exception("Неверный формат файла");
                }
                sr.Close();
            }
        }
    }
}

