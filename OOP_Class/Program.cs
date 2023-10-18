
using OOP_Class;
using System.ComponentModel.DataAnnotations;

Product product = new Product();
Product ton =  new Product();
Product p = new Product();

//--------------------------------------------------------------------------------------------------------
//product.Id = 1;
//product.Name = "Coffee";
//product.Price = 10;
//product.Amoumt = 20;

product.Input(new Product { Id = 1, Name = "Coffee", Price = 10, Amoumt = 20 });

//ton.Id = 2;
//ton.Name = "Cream";
//ton.Price = 20;
//ton.Amoumt = 20;

ton.Input(new Product { Id =2, Name = "Cream", Price = 20, Amoumt = 20 });

//---------------------------------------------------------------------------------------------------------
//Console.WriteLine($"{product.Id} {product.Name} {product.Price} {product.Amoumt}");
//Console.WriteLine($"{t.Id} {t.Name} {t.Price} {t.Amoumt}");

//Display(product.Id, product.Name, product.Price, product.Amoumt);
//Display(t.Id, t.Name, t.Price, t.Amoumt);


//void Display(int id, string name, double price, int amonmt)
//{
//    Console.WriteLine($"{id} {name} {price} {amonmt} ");
//}
//---------------------------------------------------------------------------------------------------------

//Reuse ใช้ซ้ำได้
//Display(product);
//Display(t);

product.Display();
ton.Display();




