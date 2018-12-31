using System;
using Lessons;

//This namespace represents the folder the class is in.
namespace Classwork
{
    //Class is a blueprint of an object.
    class Program
    {
        //static is only one. No copies
        static void Main(string[] args)
        {
            //main is the method. string is the array and parameter.

            //Console.WriteLine("Hello World!");
            //console is a class. writeline is a method with parameter.
            MyHouseResults();
            myNumericExamples();
        }
        
        static void myNumericExamples()
        (
            NumericTypes myTypes = new NumericTypes();
            myTypes.getsomeType();
        )

        (
            int something = myTypes.ConvertFloattoInt(35.9F);
            Console.WriteLine(something);

            Console.WriteLine(myTypes.LongFromInt(5600));
        )
        static void MyHouseResults()
        // Created an object instance of house called myHouse

        {
            House myHouse = new House();
            //This sets the value of Red to the object
            myHouse.PaintDoor = "Red";
            myHouse.CloseDoor(); // the door closes 
                     //This gets the value of Green  from the object
            Console.WriteLine(myHouse.PaintDoor); // red
                                                  //This is the second object instance of House
            House mySecondHouse = new House();
            mySecondHouse.PaintDoor = "green";
            Console.WriteLine(mySecondHouse.PaintDoor); // green

            Console.WriteLine(myHouse.PaintDoor); // red
        }
    
            // Method to demonstrate an Explicit cast from float to int...
            public int ConvertFloattoInt (float value);
            (
                int total = (int)values;
                return total;
            )

            // Method to demonstrate an Explicit cast from int to long
            public long LongFromInt (long value);
            (
                long total = value;
                return total;
            )

}
