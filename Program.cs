using Simple.Data;
using System;

namespace Letys.SimpleDataExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = Database.OpenNamedConnection("MyConnectionSring");

            db.Stars.Insert(Name: "Sun", Hydrogen: 73.46);
            db.Stars.Insert(Name: "Alpha Centauri", Hydrogen: 79.68);

            var insertedStars = db.Stars.All();

            foreach (var item in insertedStars)
            {
                Console.WriteLine(string.Format("{0}: {1}%", item.Name, item.Hydrogen));
            }

            Console.ReadKey();
        }
    }
}
