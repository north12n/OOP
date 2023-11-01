
using System.Text.RegularExpressions;

namespace Exercise02_P55T3
{
    internal class ShowData
    {
        //ปอกปาตี้ 
        public GenerateData GenerateData { get; set; }
        public ShowData()
        {
            //คอนตั้กเตอ
            GenerateData = new GenerateData(10);
        }

        public void DisplayBySection()
        {
            foreach (var emp in GenerateData.SortBySection())
            {
                Console.WriteLine($"{emp.Section,5} {NameOfSection(emp.Section),-10} {emp.Id,5} {emp.Age,5}");
            }
        }

        public void DisplayBySectionGroup()
        {
            foreach (var group in GenerateData.GroupOfSection())
            {
                Console.WriteLine(NameOfSection(group.key));
                foreach (var emp in group)
                {
                    Console.WriteLine($"{emp.Section,5} {emp.Id,5} {emp.Age,5}");
                }
            }
                
        }

        //การนำตัวเลขที่สุ่มมา แทนค่าเป็น ชื่อแผนก)
        public string NameOfSection(int section)
        {
            string name="";
            switch (section)
            {
                case 1: name = "Account"; break;
                case 2: name = "Person"; break;
                case 3: name = "IT"; break;
                case 4: name = "Marketing"; break;
                case 5: name = "Salr"; break;
            }
            return name;    
        }
       
    }
}
