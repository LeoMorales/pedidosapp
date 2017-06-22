using PedidosApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductModel p = new ProductModel { Id = 101, Name = "Tornillo", Type = ProductType.Both, Thumbnail = "" };
            
            Console.WriteLine(p.describe_yourself());
            
            Console.ReadKey();
        }
    }

}