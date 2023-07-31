using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPG223_Project_Group2
{
    public class Employees
    {
        public int Event_Num { get; set; }
        public int Emp_ID { get; set; }
        public DateTime Event_Date { get; set; }
        public String Emp_FName { get; set; }
        public String Emp_LName { get; set; }
        public String Event_Name { get; set; }
        public String LProvince { get; set; }
        public String LCity { get; set; }
        public String Status_Descr { get; set; }
        public String Risk_Descr { get; set; }
        public int Capacity_Limit { get; set; }
        public float Temp_Limit { get; set; }
        public float Emp_Temp { get; set; }
        public float Emp_PayRate { get; set; }
    }
}
