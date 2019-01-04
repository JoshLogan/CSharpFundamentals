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
            //MyHouseResults();
            //myNumericExamples();
            myStringExamples();

        }


        static void myStringExamples()


        {
            StringTypes myTypes = new StringTypes();
            myTypes.SampleString();
            myTypes.AddString();
            string words = myTypes.StringBuilderExample("Hello", "C Sharp", "Class");

            Console.WriteLine(words);
            myTypes.CharTypeExample();
            myTypes.EscapeExample();
            myTypes.PlaceholderExample();
            myTypes.ArraySample();
            myTypes.myHouseArray();
            myTypes.MultiArraySample();
            
        }



        static void myNumericExamples()
        {
            NumericTypes myTypes = new NumericTypes();
            myTypes.GetSomeType();



            int something = myTypes.ConvertFloattoInt(35.9F);
            Console.WriteLine(something);

            Console.WriteLine(myTypes.LongFromInt(5600));
            myTypes.Basicmath();
            myTypes.CheckOperators();
            myTypes.IncrementDecrement();
            myTypes.specialvalues();
            myTypes.ComparisonOperators();
            myTypes.OtherOperators();
        }




        static void OtherNumericExamples()
        {
            NumericTypes myTypes = new NumericTypes();
            myTypes.OtherOperators();

        }



        public void IncrementDecrement()
        {

            int myvalue = 13, myother = 10;
            //myvalue = myvalue +1
            Console.WriteLine(myvalue++);
            //myother = myother -1
            Console.WriteLine(myother--);
            Console.WriteLine(--myvalue);
            Console.WriteLine(++myother);
        }
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
    }
}