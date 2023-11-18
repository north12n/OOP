using System.Text.RegularExpressions;

namespace P06_Interface
{
    public class ProductService
    {
        public ProductManagement ProductManagement { get; set; }
        public ProductService()
        {
            ProductManagement = new ProductManagement();
        }

        public void GenerateProduct(int number = 1)
        {
            Random random = new Random();
            for (int i = 1; i <= number; i++)
            {
                ProductManagement.AddProduct(new Product
                {
                    Id = i,
                    Name = "Coffee",
                    Price = random.Next(10, 200),
                    Category = random.Next(1, 5)
                });
            }
        }

        public void DisplayProduct()
        {
            foreach (var item in ProductManagement.GetProducts())
            {
                Console.WriteLine($" {item.Id,5}  {item.Name,-7} {item.Price,4} {item.Category,4}");
            }
        }

        public List<Product> OrderByPrice()
        {
            var sort = ProductManagement.Products.OrderBy(x => x.Price).ToList();
            return sort;
        }

        public List<TempGroup> GroupByPrice()
        {
            var temp = new List<TempGroup>();
            int tempGr, tempty;

            foreach (var item in OrderByPrice())
            {
                tempGr = item.Price switch
                {
                    <= 100 => 1,
                    <= 200 => 2,
                    _ => 3,
                };

                tempty = item.Category;
                temp.Add(new TempGroup { group = tempGr, groupTy = tempty });
            }
            return temp;
        }

        public void DisplayGroupByPrice()   
        {
            var numOfGroup = GroupByPrice().GroupBy(g => g.group);
      
            Console.WriteLine(" Product Type \t1\t2\t3\t4\t5");
            Console.WriteLine("===================================================");
            foreach (var item in numOfGroup)
            {
                Console.Write($" {NameOfPrice(item.Key)} ");
                for (int i = 0; i <= 4; i++)
                {
                    //Console.Write($"{item.Count(p => p.groupTy == i),7} ");
                    Console.Write($"{item.Count(p => p.groupTy.Equals(i)),7} ");
                }
                Console.WriteLine(" ");
            }
        }

        private string NameOfPrice(int price)
        {
            return price switch
            {
                1 => "  10-100",
                2 => " 101-200",
                _ => " ",
            };
        }
        public Product SearchProduct()
        {
            Console.Write("Enter Id: ");
            var id = int.Parse(Console.ReadLine());

            var result = ProductManagement.GetProductById(id);
            if (result == null)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine($"{result.Id,5} {result.Name,5} {result.Price,5}" +
                              $" {result.Category,5}");
            }

            return result;
        }

        public void SearchByAny()
        {
            Console.Write("Enter number ");
            var number = int.Parse(Console.ReadLine());

            Console.Write("Enter keyword ");
            var keyword = Console.ReadLine();

            var result = ProductManagement.GetProductByAny(number, keyword);
            if (result.Count == 0) Console.WriteLine("Not found");
            else
            {
                result.ForEach(x => Console.WriteLine($"{x.Id,5} {x.Name,5}" +
                    $" {x.Price,5} {x.Category,5}"));
            }
        }

        public void DeleteProductById()
        {
            var result = SearchProduct();

            if (result == null) return;

            ProductManagement.DeleteById(result);

            Console.WriteLine();
            DisplayProduct();
        }

        public void UpdataProductService()
        {
            UpdataProductService:
            var result = SearchProduct();

            if (result == null) goto UpdataProductService;

            var newProduct = ProductManagement.InputProduct(result);

            ProductManagement.UpdataProduct(newProduct,result);

            DisplayProduct();
        }


    }

    public class TempGroup
    {
        public int group { get; set; }
        public int groupTy { get; set; }
    }
}
