using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkzamenWork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>();
            Product pr = new Product();
            pr.Register += pr.ShowMessage;
            string name;
            int price;
            int quant;
            JsonSerializer serializer = new JsonSerializer();
            

            do
            {

                name = Console.ReadLine();
                price = Int32.Parse(Console.ReadLine());
                quant = Int32.Parse(Console.ReadLine());
                pr.ProductAdd(name, price, quant);
                product.Add(new Product { Name = pr.Name, Price = pr.Quatnity, Quatnity = pr.Price });
                
            }
            while (pr.CountProduct!=3);

            
            
            using (StreamWriter sw = new StreamWriter("product.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, product);
            }
        }
    }
}
