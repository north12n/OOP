using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO3_Encapsulate
{
    public class BankAccount
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        private string Password { get; set; }
        protected double Money { get; set; } //ป้องกัน
        internal double Rate { get; set; }


        //เรียกใช้ private โดยทางอ่อมผ่าน เมธอด
        //เข้าหา (private string Password) โดยอ่วม
        public void SetPassword(string Password) 
        {
            this.Password = Password; //this แทนคลาส 

            if (this.Password == "1234") 
            {
                Console.WriteLine(Money);
            }
            else
            {
                Console.Write(Money);
            }
        }
    }
}
