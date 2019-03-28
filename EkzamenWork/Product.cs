using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkzamenWork
{
    public class Product
    {
        public delegate void AddProduct(string message);
        public event AddProduct Register;

        public string Name { get; set; }
        public int Quatnity { get; set; }
        public int Price { get; set; }
        public int CountProduct { get; set; } = 0;
        public void ProductAdd(string name, int quantity, int price)
        {
            Name = name;
            Quatnity = quantity;
            Price = price;
            RegisterProduct(name);
            CountProduct++;
        }
        public Product()
        {

        }
        
        public void RegisterProduct(string name)
        {
            
            if (Register != null)
                Register($"Товар {name} добавлен в склад ");
        }
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        
    }
}
