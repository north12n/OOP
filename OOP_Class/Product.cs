//ชื่อ พื้นที่
namespace OOP_Class
{
    public class Product //แม่แบบ แบบฟอร์ม
    { // ในแม่แบบ คือ attribute
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amoumt { get; set; }

        //Default Methot (get set)= บีฟอ เม็ดตอด
        //get อ่านค่า
        //set ใส่ค่า

        //สาธารระ
        //public void Display(Product p)
        //{
        //    Console.WriteLine($"{p.Id} {p.Name} {p.Price} {p.Amoumt} ");
        //}
        //ไม่จำเป็น

        //Lamda, Arrow function
        public void Display() => Console.WriteLine($"{Id} {Name} {Price} {Amoumt}");

        public void Input(Product product)
        {
            Id =product.Id;
            Name = product.Name;
            Price = product.Price;
            Amoumt = product.Amoumt;
        }
    }
}
