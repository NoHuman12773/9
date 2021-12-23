using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_vrema
{
    class Program
    {
        struct electro
        {
            public DateTime time;
            public int Kol_vo;
            public int Price;
        }
        static void Main(string[] args)
        {       
            //Console.WriteLine("Введите первую дату");
            //var date1 = DateTime.Parse(Console.ReadLine()).Year;
            //Console.WriteLine("Введите вторую дату");
            //var date2 = DateTime.Parse(Console.ReadLine()).Year;
            //var year = date1 - date2;
            //Console.WriteLine("разница между датами равна "+Math.Abs(year));


            electro[] electros = new electro[1];
            for (int i = 0; i < electros.Length; i++)
            {
                Console.WriteLine("Введите время");
                electros[i].time = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Введите кол-во потребленной электроэнергии в кВт");
                electros[i].Kol_vo = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите полную стоимость 1 кВт/час(в копейках)");
                electros[i].Price = int.Parse(Console.ReadLine());
            }
            foreach (electro i in electros)
            {
                var date = i.time.Hour;
                if ((date >= 8 && date < 11) || (date >= 20 && date < 23)) Console.WriteLine(i.Price * i.Kol_vo+" коп.");
                else if ((date >= 7 && date < 8) || (date >= 11 && date < 20)) Console.WriteLine((i.Price * i.Kol_vo) * 0.7+" коп.");
                else if ((date >= 23 && date < 24) || (date >= 1 && date < 7)) Console.WriteLine((i.Price * i.Kol_vo) * 0.4+" коп.");                 
            }
            Console.ReadKey();
        }
    }
}
