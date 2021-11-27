using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace поиск_в_списке
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
            new Door(){ Id=2,Width=700,Hight=1950,Cost=7200,Manufacturer="Оконный завод",Material="Пластик",Composition=new List<string>(){"полотно","глазок","коробка"} },
        };
            List<Door> doors = (from d in listDoor //перебираем все значения в списке дверей
                               from p in d.Composition//перебираем в списке состава
                                where p=="глазок"
                                select d).ToList();//d в списке Доор,где материал в списке пластик(to list для формированиЯ СПИСКА)переменная d по очереди принимает все значения из списка,если условие выполнячется то добавляется в список
                                /// List<Door> doors = listDoor.Where(d => d.Material == "Металл").ToList();
            foreach (Door d in doors)//выводим новый список на экран 
            {
                Console.WriteLine($"{d.Id} {d.Width} {d.Hight} {d.Cost} {d.Manufacturer} {d.Material}");//интерполируемвя строка
            }
            Console.ReadKey();



        }
    }
}
