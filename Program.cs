using System;

namespace cn_week9_c_sharp
{
    class Room
    {
        public double length;
        public double height;
        public double width;
    }

    class Program
    {
        static void Main(string[] args)
        {

            // declared room1 and room2 to be instances of the Room class
            Room Room1 = new Room();
            Room Room2 = new Room();
            double room1Vol = 0.0;
            double room2Vol = 0.0;
            String name = "Danny";

            // room1 details
            Room1.height = 5.0;
            Room1.length = 20.0;
            Room1.width = 40.9;

            // room2 details
            Room2.height = 30.3;
            Room2.length = 12.6;
            Room2.width = 26.8;

            room1Vol = Room1.height * Room1.length * Room1.width;
            Console.WriteLine("Room1 volume is: {0} and my name is {1}", room1Vol, name);
            Console.WriteLine("The total is: " + room1Vol + ".");

            room2Vol = Room2.height * Room2.length * Room2.width;
            Console.WriteLine("Room2 volume is: {0} and my name is {1}", room2Vol, name);
            Console.WriteLine("The total is: " + room2Vol + ".");

            Console.ReadKey();

            // Console.WriteLine("Hello World!");
        }
    }
}
