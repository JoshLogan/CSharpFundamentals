using System;
namespace Lessons
{
    public class NumericTypes
    {

        /*Integral - Signed */
        //Range - 128 - 127
        sbyte _mySbyteValue = 1;

        //range -32,768 - 32,767
        short _myShortValue = 4;

        //range -2,347,483,648 - 2,147,483,647
        int _myIntValue = 25000;

        //range -9,223,372,086,775,800 to 9,223,372,086,775,807
        long _myLongValue = 1_234_567L;
        long _myLongValue2 = 0x5F;

        /*Integral - Unsigned*/
        //range 0 to 255
        byte _myByteValue = 3;

        //range 0 to 65,585
        ushort myUShortValue = 35;

        //range 0 to 4,204,967,205 
        uint _myUintValue = 2345U;

        ulong _mylongValue = 123456789;

        /*Real Numbers */
        //range 3.4E +/- 38(7 digits)//
        float _myFloatValue = 123.6589F;

        //range 1.7E +/- 308(15 digits)
        double _myDoubleValue = 12.34;
        double _myDoubleValue2 = 1E06;

        //range -7.9228E+24 to 7.9228E+24
        decimal _myDecimalValue = 13.234M;

        public void GetSomeType()
        {
            Console.WriteLine(3.0.GetType());
            Console.WriteLine(_myFloatValue.GetType());
        }

        public int ConvertFloattoInt(float value)
        {

            int converted = (int)value;
            return converted;

        }
        public long LongFromInt(int value)
        {
            long somelongValue = value;


            return somelongValue;
        }

        public void Basicmath()
        {
            int myVal = 5, myotherval = 10;

            int addval = myVal + myotherval;
            int subtractval = myVal - myotherval;
            int multiplyval = myVal * myotherval;
            int divisionval = myVal / myotherval;
            int modulusval = myVal % myotherval;

            Console.WriteLine(addval);
            Console.WriteLine(subtractval);
            Console.WriteLine(multiplyval);
            Console.WriteLine(divisionval);
            Console.WriteLine(modulusval);
        }


        public void IncrementDecrement()
        {

            int myvalue = 13, myother = 10;
            //myvalue = myvalue +1
            myvalue++;
            Console.WriteLine(myvalue++);
            //myother = myother -1
            myother--;
            Console.WriteLine(myother--);
            --myvalue;
            Console.WriteLine(--myvalue);
            ++myother;
            Console.WriteLine(++myother);
        }

        public void specialvalues()
        {
            Console.WriteLine(2.0 / 0.0);
            Console.WriteLine(-2.0 / 0.0);
            Console.WriteLine(2.0 / -0.0);
            Console.WriteLine(-2.0 / -0.0);
            Console.WriteLine(0.0 / 0.0);
            Console.WriteLine((2.0 / 0.0) - (2.0 / 0.0));
            Console.WriteLine(0.0 / -0.0 == double.NaN);
            Console.WriteLine(double.IsNaN(0.0 / 0.0));
            Console.WriteLine(object.Equals(0.0 / 0.0, double.NaN));
        }

        public void ComparisonOperators()
        {
            bool IsCool = true; //declartion of a bool value

            int x = 3, y = 5, z = 3;

            Console.WriteLine(x == y); // false
            Console.WriteLine(x != y); // true
            Console.WriteLine(x == z); // true
        }

        public void OtherOperators()
        {
            int val1 = 5, val2 = 10;
            //val1 = val1 + val2
            Console.WriteLine(val1 += val2);
            // val1 = val1 <<= val2
            Console.WriteLine(val1 <<= val2);
        }

        public void CheckOperators()
        {
            int test = 100, test2 = 100;
            int testval = checked(test * test2);
            checked
            {
                //Make the value 3000000 to fail.
                int testagain = test * 300;
                Console.WriteLine(testagain);
            }
            Console.WriteLine(testval);

        }
    }
}