using P06_Interface;

var ps = new ProductService();

ps.GenerateProduct(10);
ps.DisplayProduct();

Console.WriteLine();
//ps.DisplayGroupByPrice();
//ps.SearchByAny();
//ps.DeleteProductById();
ps.UpdataProductService();