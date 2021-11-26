using System;
namespace ExaminationQustions
{
    struct op25_structure
    {
        public int ProductId;
        public string ProductName;
        public double Priceperkg;
        public DateTime ExpireDate;
        public string ExportFrom;
        public op25_structure(int ProductId,string ProductName,double Priceperkg,DateTime Expire,string PackedFrom)
        {
            this.ProductId = ProductId;
            this.ProductName = ProductName;
            this.Priceperkg = Priceperkg;
            this.ExpireDate = Expire;
            this.ExportFrom = PackedFrom;
        }
        //static void Main()
        //{
        //    op25_structure obj = new op25_structure(11,"Apples",150,new DateTime(2021,12,01),"Kashmir");
        //    Console.WriteLine($" ProductId :{obj.ProductId}");
        //    Console.WriteLine($" ProductName :{obj.ProductName}");
        //    Console.WriteLine($" Priceperkg :{obj.Priceperkg}");
        //    Console.WriteLine($" ExpireDate of Product :{obj.ExpireDate}");
        //    Console.WriteLine($" Place of Export :{obj.ExportFrom}");
        //}
    }
    struct op25_structureS1       //we can call the structure from another structure by creating instance 
    {
        static void Main()
        {
            op25_structure obj = new op25_structure(11, "Apples", 150, new DateTime(2021, 12, 01), "Kashmir");
            Console.WriteLine($" ProductId :{obj.ProductId}");
            Console.WriteLine($" ProductName :{obj.ProductName}");
            Console.WriteLine($" Priceperkg :{obj.Priceperkg}");
            Console.WriteLine($" ExpireDate of Product :{obj.ExpireDate}");
            Console.WriteLine($" Place of Export :{obj.ExportFrom}");
        }
    }
    class op25_structureC1      //we can call the structure from class by creating instance  IT'S NOT SUPPORT FOR INHERITENCE. BY DEFAULT CONSTR... IS NOT THEIR AS LIKE CLASS
    {
        static void Main()
        {
            op25_structure obj = new op25_structure(11, "Apples", 150, new DateTime(2021, 12, 01), "Kashmir");
            Console.WriteLine($" ProductId :{obj.ProductId}");
            Console.WriteLine($" ProductName :{obj.ProductName}");
            Console.WriteLine($" Priceperkg :{obj.Priceperkg}");
            Console.WriteLine($" ExpireDate of Product :{obj.ExpireDate}");
            Console.WriteLine($" Place of Export :{obj.ExportFrom}");
            Console.WriteLine("======================================================");
            op25_structure obj1 = new(01, "Saffron", 750, new DateTime(2022, 02, 01), "Kashmir");
            Console.WriteLine($" ProductId :{obj1.ProductId}");
            Console.WriteLine($" ProductName :{obj1.ProductName}");
            Console.WriteLine($" Priceperkg :{obj1.Priceperkg}");
            Console.WriteLine($" ExpireDate of Product :{obj1.ExpireDate}");
            Console.WriteLine($" Place of Export :{obj1.ExportFrom}");
        }
    }
}
