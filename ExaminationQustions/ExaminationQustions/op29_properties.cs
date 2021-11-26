using System;
namespace ExaminationQustions
{
    class op29_properties
    {
        string _FlightNO;
        string _NameofPassenger;
        double _Price;
        string _Destination;
        public string FlightNo
        {
            get { return _FlightNO; }
        }
        public string NameofPassenger
        {
            get { return _NameofPassenger; }
            set { _NameofPassenger = (string)value; }
        }
        public double Price
        {
            get { return _Price; }
            set { _Price = (double)value; }
        }
        public string Destination
        {
            get { return _Destination; }
            set { _Destination = (string)value; }
        }
        public op29_properties()
        {
            this._FlightNO = "AIRIND747";
            this._NameofPassenger = "Pradeep";
            this._Price = 94500.89;
            this._Destination = "IceLand";
        }
        static void Main()
        {
            op29_properties obj = new();
            Console.WriteLine($" Flight Number is {obj.FlightNo}");
            Console.WriteLine($" Name of the Passenger {obj.NameofPassenger}");
            Console.WriteLine($" Ticket Price is {obj.Price}");
            Console.WriteLine($" Passenger Destination {obj.Destination}");
            //For 2nd Passenger 
            // obj.FlightNo = "FLYEMIRATES777";  THIS IS NOT ALLOWED
            Console.WriteLine("=======================================");
            obj.NameofPassenger = "Yashidhar";
            obj.Price = 56900.89;
            obj.Destination = "Paris";
            Console.WriteLine($" Flight Number is  {obj.FlightNo}");
            Console.WriteLine($" Name of Passenger  {obj.NameofPassenger}");
            Console.WriteLine($" Ticket Price {obj.Price}");
            Console.WriteLine($" Passenger Destination  {obj.Destination}");
        }
    }
}
