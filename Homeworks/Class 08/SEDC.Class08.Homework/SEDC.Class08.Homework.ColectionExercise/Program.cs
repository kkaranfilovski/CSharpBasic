using System;
using System.Collections.Generic;

namespace SEDC.Class08.Homework.ColectionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product() { Name =  "Keyboard", Price = 100, Category = Category.ItEquipment},
                new Product() { Name =  "Mouse", Price = 150, Category = Category.ItEquipment},
                new Product() { Name =  "Headphones", Price = 80, Category = Category.ItEquipment},
                new Product() { Name =  "Microphone", Price = 220, Category = Category.ItEquipment},
                new Product() { Name =  "Camera", Price = 1000, Category = Category.ItEquipment},
                new Product() { Name =  "Hp-580", Price = 20000, Category = Category.LapTop},
                new Product() { Name =  "Lenovo G200", Price = 18500, Category = Category.LapTop},
                new Product() { Name =  "Hp ProBook", Price = 12000, Category = Category.LapTop},
                new Product() { Name =  "Acer S1200", Price = 28000, Category = Category.LapTop},
                new Product() { Name =  "Dell MS300", Price = 74000, Category = Category.LapTop},
                new Product() { Name =  "Office 1", Price = 10200, Category = Category.PC},
                new Product() { Name =  "Office 2", Price = 12400, Category = Category.PC},
                new Product() { Name =  "Gaming", Price = 22000, Category = Category.PC},
                new Product() { Name =  "Ultra Gaming", Price = 32200, Category = Category.PC},
                new Product() { Name =  "Ultra Ultra Gaming", Price = 61600, Category = Category.PC},
                new Product() { Name =  "Alienware", Price = 128000, Category = Category.PC},
                new Product() { Name =  "Samsung Proview", Price = 56200, Category = Category.TV},
                new Product() { Name =  "LG LG420MQ8", Price = 32000, Category = Category.TV},
                new Product() { Name =  "SONY Plasma", Price = 18000, Category = Category.TV},
                new Product() { Name =  "SONY RW78OS", Price = 179999, Category = Category.TV},
                new Product() { Name =  "Samsung Oval", Price = 247999, Category = Category.TV}
            };

            Services services = new Services();

            //List<Product> task1 = services.SearchByCategory(products, Category.LapTop);
            //services.ItterateArray(task1);
            //Console.WriteLine("=======================================================");

            //List<Product> task2 = services.FilterByPriceRange(products, 50, 200);
            //services.ItterateArray(task2);
            //Console.WriteLine("=======================================================");

            //List<Product> task3 = services.FindByPartOfName(products, "dell");
            //services.ItterateArray(task3);
            //Console.WriteLine("=======================================================");

            //List<string> task4 = services.GetOnlyProductsName(products);
            //foreach (string item in task4)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("=======================================================");

            //int task5 = services.GetProductPrice(products, "Office 2");
            //Console.WriteLine(task5);
            //Console.WriteLine("=======================================================");

            //Product task6 = services.GetCheapestProduct(products);
            //Console.WriteLine(task6.Name);
            //Console.WriteLine("=======================================================");

            //Product task7 = services.GetMostExpensiveProduct(products);
            //Console.WriteLine(task7.Name);
            //Console.WriteLine("=======================================================");

            //Product newProduct = new Product { Name = "Logitech G102", Price = 200, Category = Category.ItEquipment};
            //List<Product> task8 = services.AddProduct(products, newProduct);
            //services.ItterateArray(task8);
            //Console.WriteLine("=======================================================");

            List<Product> task9 = services.RemoveProduct(products, "mouse");
            services.ItterateArray(task9);
            Console.WriteLine("=======================================================");
        }
    }
}
