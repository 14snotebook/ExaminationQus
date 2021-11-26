using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationQustions
{
    class op14_indexer
    {
        public int Id;
        public int DeptId;
        public string Name;
        public string Department;
        public string Location;
        public op14_indexer(int DeptId)
        {
            this.DeptId = DeptId;
            this.Id = 12;
            this.Name = "Pradeep";
            this.Department = "Technical";
            this.Location = "Hyderabad";
            
        }
        public object this[int i]
        {
            get {
                if (i == 1) { return DeptId; }
                else if (i == 2) { return Id; }
                else if (i == 3) { return Name; }
                else if (i == 4) { return Department; }
                else if (i == 5) { return Location; }
                else return 0;
            }
            set
            {
                if (i == 1) { Id = (int)value; }
                else if (i == 2) { Name = (string)value; }
                else if (i == 3) { Department = (string)value; }
                else if (i == 4) { Location = (string)value; }
            }
        }
        static void Main()
        {
            op14_indexer obj = new(12);
            Console.WriteLine($" your DeptId  is {obj[1]}");
            Console.WriteLine($" your ID  is {obj[2]}");
            Console.WriteLine($" your Name is {obj[3]}");
            Console.WriteLine($" your Department  is {obj[4]}");
            Console.WriteLine($" your Location  is {obj[5]}");
            obj[3] = "Research And Development";
            Console.WriteLine(" setting the value using index key ");
            Console.WriteLine($" your transfored Department is {obj[4]} ");
        }
    }
}
