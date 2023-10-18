
using OOP_Class;

//วัตถุ
//Array = จำกันจำนวน
//Product[] product = new Product[100];

//list = ไม่จำกันจำนวน
List<Product> products = new List<Product>();
Random random = new Random();

for (int i = 0; i < 100; i++)
{
    products.Add(new Product
    {
        Id = i,
        Name = "Coffee" + i,
        Price = random.NextDouble() * 990 + 10, //หว่าง 10 ถึง 1000
        Amoumt = random.Next(10,50)
    });
}

//foreach (var item in products)
//{
//    item.Display();
//}

products.ForEach(p => p.Display());


