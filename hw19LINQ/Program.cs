using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw19LINQ
{
    class Door
    {
        public int Id { get; set; }
        public int Width { get; set; }
        public int Hight { get; set; }
        public int Cost { get; set; }
        public string Manufacturer { get; set; }
        public string Material { get; set; }
        public List<string> Composition { get; set; }//состав двери
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Door> listDoor = new List<Door>()//создаем список параметризированный Door и помещаем в него  запси
        {
            new Door(){ Id=1,Width=1000,Hight=2000,Cost=10000,Manufacturer="Заря",Material="Металл",Composition=new List<string>(){"полотно","коробка"} },
            new Door(){ Id=2,Width=400,Hight=1000,Cost=700,Manufacturer="Луч",Material="Дерево",Composition=new List<string>(){"полотно","коробка"} },
            new Door(){ Id=2,Width=700,Hight=1950,Cost=7200,Manufacturer="Оконный завод",Material="Пластик",Composition=new List<string>(){"полотно","коробка"} },
        };
            List<Door> doors = new List<Door>();//Создаем список для сохранения резу льтата
             foreach (Door  d in listDoor)//ПРЕБИРАЕМ список с дверями
            {
                if (d.Material=="Дерево")//если очередная дверь содержит поле материал-дерево,то добавляем в новый список
                {
                    doors.Add(d);
                }
            }
            foreach (Door d in doors)//выводим новый список на экран 
            {
                Console.WriteLine($"{d.Id} {d.Width} {d.Hight} {d.Cost} {d.Manufacturer} {d.Material}");//интерполируемвя строка
            }
            Console.ReadKey();



        }
    }
}
