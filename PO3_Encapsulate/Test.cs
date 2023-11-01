using PO3_Encapsulate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Test
{
    //การเรียกใช้ internal ในโปรเจคเดียวกันสามารถทำได้
    public class Test
    {
        public Test()
        {
            var temp = new BankAccount();
            temp.Rate = 100;
        }
    }

}
