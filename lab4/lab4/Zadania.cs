using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Newtonsoft.Json;

namespace lab4
{
    public class Indicator
    {
        public string id { get; set; }
        public string value { get; set; }
    }

    public class Country
    {
        public string id { get; set; }
        public string value { get; set; }
    }

    public class Root
    {
        public Indicator indicator { get; set; }
        public Country country { get; set; }
        public string value { get; set; }
        public string @decimal { get; set; }
        public string date { get; set; }
    }

    public class Fruit
    {
        //[JsonProperty("fruit")]
        public string Type { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
    }




    class Zadania
    {
        static void Main(string[] args)
        {
            //Zad1
            using(var sw = new StreamWriter("zad1.txt", append: true))
            {
                sw.WriteLine("118996");
            }

            //Zadanko2
            using (var sr = new StreamReader("zad1.txt"))
            {
                var line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }

            //Zadanko3
            using (var sr = new StreamReader("pesels.txt"))
            {
                string line = sr.ReadLine();
                int ilosc_kobiet = 0;
                int ilosc_meskich = 0;
                while (line != null)
                {
                    if (line[9] % 2 == 0) ilosc_kobiet++;
                    else ilosc_meskich++;
                    line = sr.ReadLine();
                }

                Console.WriteLine("Ilosc zenski peseli: "+ilosc_kobiet);
                Console.WriteLine("Ilosc meskich peseli: "+ilosc_meskich);
            }

            //Zadanko4
            /*
            List<Fruit> list;
            using (var sr = new StreamReader("fruits.json"))
            {
                var json = sr.ReadToEnd();

                list = JsonConvert.DeserializeObject<List<Fruit>>(json);
            }


            List<Root> list;
            using (var sr = new StreamReader("db.json"))
            {
                var json = sr.ReadToEnd();

                list = JsonConvert.SerializeObejct();
            }

            */
        }
    }
        
}
