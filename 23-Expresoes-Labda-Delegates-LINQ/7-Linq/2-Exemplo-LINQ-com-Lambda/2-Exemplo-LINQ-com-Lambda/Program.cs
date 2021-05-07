using System;
using System.Collections.Generic;
using _2_Exemplo_LINQ_com_Lambda.Entities;
using System.Linq;

namespace _2_Exemplo_LINQ_com_Lambda
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
             };

            //Filtrando todos produtos do tier 1 e com o preço menor que 900.00
            //var r1 = products.Where(x => x.Category.Tier == 1 && x.Price < 900.0);
            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900
                select p;
            Print("Tier 1 and price < 900: ", r1);

            //Filtrando somente os nomes da categoria tools
            //var r2 = products.Where(x => x.Category.Name == "Tools").Select( x => x.Name);
            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("Names of products from tools", r2);

            //Filtrar produtos que começam com a letra C
            // var r3 = products.Where(x => x.Name[0] == 'C').Select(x => new { x.Name, x.Price, CategoryName = x.Category.Name });
            var r3 =
                 from p in products
                 where p.Name[0] == 'C'
                 select new
                 {
                     p.Name,
                     p.Price,
                     CategoryName = p.Category.Name
                 };
            Print("Names started with 'c' and anonymous object", r3);

            //Filtrar produtos que tier da categoria seja igual a 1 e ordenar por preço
           // var r4 = products.Where(x => x.Category.Tier == 1).OrderBy(x => x.Price).ThenBy(x => x.Name);
            var r4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Name
                orderby p.Price
                select p;
            Print("Tier 1 order by price then by name: ", r4);

            //Pular dois elementos e pegar os proximos 4 elementos da r4
            //var r5 = r4.Skip(2).Take(4);
            var r5 =
                (from p in r4
                 select p)
                 .Skip(2)
                 .Take(4);
            Print("Tier 1 order by price then by name skip 2 take 4: ", r5);

            //Agrupando os produtos por categoria
            //var r15 = products.GroupBy(p => p.Category);
            var r6 =
                from p in products
                group p by p.Category;
            //Imprimir o agrupamento
            foreach (IGrouping<Category, Product> group in r6)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
