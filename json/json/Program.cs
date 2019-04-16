using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serialisation");
            Movie mv = new Movie { Id=1 ,Title="Vixen"};
            string result = JsonConvert.SerializeObject(mv);
            Console.WriteLine(result);

            Console.WriteLine("------------");

            Console.WriteLine("DeSerialisation");
            Movie desermv = JsonConvert.DeserializeObject<Movie>(result);
            Console.WriteLine("Id: " + desermv.Id + "," + "Title: " + desermv.Title);

            Console.WriteLine("------------");

            Console.WriteLine("List Serialisation");
            Movie mv1 = new Movie { Id = 1, Title = "Vixen" };
            Movie mv2 = new Movie { Id = 2, Title = "SuperVixens" };
            List<Movie> mvL = new List<Movie>();
            mvL.Add(mv1);
            mvL.Add(mv2);
            string Lresult = JsonConvert.SerializeObject(mvL);
            Console.WriteLine(Lresult);

            Console.WriteLine("------------");

            Console.WriteLine("List DeSerialisation");
            List<Movie> Ldesermv = JsonConvert.DeserializeObject<List<Movie>>(Lresult);
            foreach (Movie m in Ldesermv)
            {
                Console.WriteLine("Id: " + m.Id + "," + "Title: " + m.Title);
            }

        }
    }

    class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
