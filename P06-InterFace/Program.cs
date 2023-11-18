using P06_Interface;

var ps = new ProductService();

ps.GenerateProduct(50);
ps.DisplayProduct();

Console.WriteLine();
//ps.DisplayGroupByPrice();
ps.SearchProduct();