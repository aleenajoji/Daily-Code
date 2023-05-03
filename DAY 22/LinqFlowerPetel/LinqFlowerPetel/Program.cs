using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFlowerPetel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Flower> Flowerlist = new List<Flower>(); 
            Flowerlist.Add(new Flower("Daliya",10));
            Flowerlist.Add(new Flower("Jasmin",7));
            Flowerlist.Add(new Flower("Rose",2));
            Flowerlist.Add(new Flower("Lily",10));
            Flowerlist.Add(new Flower("Lotus",3));
            Flowerlist.Add(new Flower("Sunflower",6));
            Flowerlist.Add(new Flower("Shoeflower",20));
            Flowerlist.Add(new Flower("Jasmin",21));
            Flowerlist.Add(new Flower("Waterlily",18));
            Flowerlist.Add(new Flower("Daffodil",9));

            var FQuery = from Flower flower in Flowerlist
                         orderby flower.PetelNo
                         group flower by flower.PetelNo;
            foreach (var flow in FQuery)
            {
                Console.WriteLine("Flower name ordered by Petel number  : ");

                foreach (var petelNum in flow)
                {
                    Console.WriteLine(petelNum.FlowerName+"-->"+flow.Key);
                }
            }

        }
    }
}
