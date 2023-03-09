using System;

namespace Main_C_Sharp
{
    partial class motorcycle
    {
        private int _id;
        private string _brand;
        private double _weight;
        private int _salesNumber;
        private short? _maxSpeed;


        public motorcycle()
        {
            _brand = "Unknown";
            _maxSpeed = 330;
            _weight = 150;
            ID++;
            SalesNumber++;
            _id = ID;
            _salesNumber = SalesNumber;
        }
        public motorcycle(string brand, short speed, double weight)
        {
            _brand = brand;
            _maxSpeed = speed;
            _weight = weight;
            ID++;
            SalesNumber++;
            _id = ID;
            _salesNumber = SalesNumber;
        }
        public motorcycle(string brand, double weight)
        {
            _brand = brand;
            _maxSpeed = null;
            _weight = weight;
            ID++;
            SalesNumber++;
            _id = ID;
            _salesNumber = SalesNumber;
        }

        public short? speed()
        {
            return _maxSpeed;
        }
    }

    partial class motorcycle
    {
        static private int ID;

        static private int SalesNumber;
        static motorcycle()
        {
            ID = 0;
            SalesNumber = 12345;

        }
        public void print()
        {
            Console.WriteLine(_id);
            Console.WriteLine(_brand);
            Console.WriteLine(_weight);
            Console.WriteLine(_salesNumber);
            Console.WriteLine(_maxSpeed);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            motorcycle[] mainOBJ = new motorcycle[5];

            for (int i = 0; i < 5; i++)
            {
                mainOBJ[i] = new motorcycle();
                mainOBJ[i].print();
                Console.WriteLine();
            }
        }
    }
}