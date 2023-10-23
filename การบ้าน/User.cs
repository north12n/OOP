
namespace การบ้าน
{
    public class User
    {
        public Employees Employees { get; set; } = new Employees();
        // Method
        public void Display(int person) //Display = การนำมาใช้
        {
            // ใส่ public บนEmployees ใน Employees.cs แล้ว สามารถใช้ Employees.GenereteData(person) ได้
            var IncomeData = Employees.GenereteData(person); //Add มา ... รายการ

            foreach (var item in IncomeData)
            {
                var Income = item.Salary + item.Sales * item.Rate;
                var tex = Income * 0.05;
                var net = Income - tex;

                Console.WriteLine($"{item.Id} {item.Name} {Show(item.Salary)} {item.Sales} {item.Rate} {Income} {tex} {net} ");
            }
        }
        //สร้าง MetHod ทำให้ตวเลขสวยส่งไปใช้ เป็น พารามิตเตอร์ คือ Show() เช่น {Show(item.Salary)}
        string Show(double number)
        { 
            return number.ToString("#,###.##"); 
        }
    }
}
