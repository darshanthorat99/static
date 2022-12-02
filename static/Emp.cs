using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statics
{
    public class Emp
    {
        private int id;
        private string name;
        private int salary;
        private double hra;
        private double da;
        private double pf;
        private double gross;
        private double net;
        private static int count;
        public Emp(string name, int salary)

        {
            count++;
            this.id = count;
            this.name = name;
            this.salary = salary;

        }
        public void Calculatesalary()
        {
            hra = salary * 0.4;
            da = salary * 0.2;
            gross = salary + da + hra;
            pf = salary * 0.12;
            net = gross - pf;
        }
        public static string TotalCounts()
        {
            return $"the counted value is:{count}";

        }
        public override string ToString()
        {
            return $"ID {id}  NAME {name}  GROSS SALARY {gross} NET SALARY{net}";
        }



    }
}
