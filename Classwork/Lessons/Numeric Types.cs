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

        public void GetSomeType ()
        {
                Console.WriteLine(3.0.GetType());
                Console.WriteLine(_myFloatValue.GetType());
        }













































































































    }
}