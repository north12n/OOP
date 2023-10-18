
using OOP_Class;
using System.ComponentModel.DataAnnotations;

Product product = new Product();
Product t =  new Product();
Product p = new Product();

product.Id = 1;
product.Name = "Coffee";
product.Price = 10;
product.Amoumt = 20;

t.Id = 2;
t.Name = "Cream";
t.Price = 20;
t.Amoumt = 20;

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
Display(product);
Display(t);

void Display(Product p)
{
    Console.WriteLine($"{p.Id} {p.Name} {p.Price} {p.Amoumt} ");
}