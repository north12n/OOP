
//Global ใช้ได้ทุกที่
using Microsoft.VisualBasic;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

string Id="11";
string Name="coffee";
double Price = 10;
double Amount = 10;
double rate1 = 0.5;
//double total = 0;

Random r = new Random();

//เรียกใช้
//input();
//Display();   //บีฟอ
//Update(ref Id,ref Name,ref Price);
//Display();   //อาฟเตอ

//พารามิเตอร์ แบบส่งค่าออกอย่างเดียว

rate1 = Cal(out string id, out string name, out double price, out double amount);
Id = id;
Name = name;
Price = price;
Amount = amount;
Display();

//การแบ่งขึ้นข้อมูลแบบ
Console.Write($"Summary = {Summary(1,2,3,4,5)}");


void Display() //ไม่มีค่า ชื่อ
{
    Console.WriteLine("Hallo");
    Console.WriteLine($"ID = {Id} Name = {Name} price = { Price} Amount = {Amount} | sum = {Price*Amount} Process = {process(rate1)}");
    
}

void input()
{
    Console.Write("Input Id: ");
    Id = Console.ReadLine();    

    Console.Write("Input Name: ");
    Name = Console.ReadLine();

    Console.Write("Input Discount Rate [0 - 1]: ");
    rate1 = double.Parse(Console.ReadLine()); //ส่งค้าไปให้

    Price = r.Next(10, 100);
    Amount = r.Next(1, 10);
    

}

double process(double rate)
{
    //ตัวแปรเฉพาะที่ เพราะประกาศไว้ถายในนี้
    var sum = Price * Amount;
    var result = sum - sum * rate;
    return result; //ค่าsumเป็น double ต้องเปลี่ยนหัวให้เป็น double fyfufiygiygiyg
}

          //ใส่ ref เรฟฟอเร้น = ดารชิ้นตำแหล่ง
          //การส่งตัวแปรแบบอ้างอิง
void Update(ref string id,ref string name,ref double price)
{
    id = id + "555";
    name = name + "555";
    price = price * 555;
}

        // ใส่ out การส่งออก
double Cal(out string id, out string name, out double price, out double amount)
{
    id = "777";
    name = "Banana";
    price = 5;
    amount = 5;
    return 0.1;   
}

double Summary(params int[] number)
{
    foreach(var itam in number)
    {
        Console.WriteLine(itam + " ");
    }
    return number.Sum();
}
