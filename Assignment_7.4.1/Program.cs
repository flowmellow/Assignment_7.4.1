/*
Design a parking system for a parking lot. The parking lot has three kinds of parking spaces: big, medium, and small, with a fixed number of slots for each size.
Implement the ParkingSystem class:
• ParkingSystem(int big, int medium, int small) Initializes object of the ParkingSystem class. The number of slots for each parking space are given as part of the constructor.
• bool addCar(int carType) Checks whether there is a parking space of carType for the car that wants to get into the parking lot. carType can be of three kinds: big, medium, or small, which are represented by 1, 2, and 3 respectively. A car can only park in a parking space of its carType. If there is no space available, return false, else park the car in that size space and return true.
Example 1:
Input
["ParkingSystem", "addCar", "addCar", "addCar", "addCar"]
[[1, 1, 0], [1], [2], [3], [1]]
Output
[null, true, true, false, false]
Explanation
ParkingSystem parkingSystem = new ParkingSystem(1, 1, 0);
parkingSystem.addCar(1); // return true because there is 1 available slot for a big car
parkingSystem.addCar(2); // return true because there is 1 available slot for a medium car
parkingSystem.addCar(3); // return false because there is no available slot for a small car
parkingSystem.addCar(1); // return false because there is no available slot for a big car. It is already occupied.
*/

using static Assignment_7._4._1.Program;

namespace Assignment_7._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingSystem parkingSystem = new ParkingSystem(1, 1, 0);
            Console.WriteLine(parkingSystem.AddCar(1));
            Console.WriteLine(parkingSystem.AddCar(2));
            Console.WriteLine(parkingSystem.AddCar(3));
            Console.WriteLine(parkingSystem.AddCar(1));
        }

        public class ParkingSystem
        {
            private int bigSpots;//private to only be available in the class. Stores big values passed in from ParkingSystem Constructor. Also making it available to AddCar() method.
            private int mediumSpots;//private to only be available in the class. Stores medium values passed in from ParkingSystem Constructor. Also making it available to AddCar() method.
            private int smallSpots;//private to only be available in the class. Stores small values passed in from ParkingSystem Constructor. Also making it available to AddCar() method.
            public ParkingSystem(int big, int medium, int small) // arguments passed in main instance of parkingSystem.
            {
                bigSpots = big;
                mediumSpots = medium;
                smallSpots = small;
            }

            public bool AddCar(int carType)
            {
                switch (carType)
                {
                    case 1: // used to check big cars. 1 corresponds to big so the case checks only big spots in the ParkingSystem Object.
                        if (bigSpots > 0)
                        {
                            Console.WriteLine("there is 1 available slot for a big car");
                            bigSpots--;
                            return true;
                        }
                        Console.WriteLine("there is no available slot for a big car");
                        return false;
                    case 2: // used to check medium cars. 1 corresponds to medium so the case checks only medium spots in the ParkingSystem Object.
                        if (mediumSpots > 0)
                        {
                            Console.WriteLine("there is 1 available slot for a medium car");
                            mediumSpots--;
                            return true;
                        }
                        Console.WriteLine("there is no available slot for a medium car");
                        return false;
                    case 3: // used to check small cars. 0 corresponds to medium so the case checks only small spots in the ParkingSystem Object.
                        if (smallSpots > 0)
                        {
                            Console.WriteLine("there is 1 available slot for a small car");
                            smallSpots--;
                            return true;
                        }
                        Console.WriteLine("there is no available slot for a small car");
                        return false;
                    default:
                        Console.WriteLine("there is no available slot for the car");
                        return false;
                       

                }
            }

        }
    }
}
