using System;

namespace SingleDimantionArraysUsingDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integer = new int[5];
            Console.Write("Insert 5 Integer Numbers one by one by clicking Enter after 1 value \n");
            integer[0] = Convert.ToInt32(Console.ReadLine());
            integer[1] = Convert.ToInt32(Console.ReadLine());
            integer[2] = Convert.ToInt32(Console.ReadLine());
            integer[3] = Convert.ToInt32(Console.ReadLine());
            integer[4] = Convert.ToInt32(Console.ReadLine());

            double[] double_number = new double[5];
            Console.Write("Insert 5 Double Numbers one by one by clicking Enter after 1 value \n");
            double_number[0] = Convert.ToDouble(Console.ReadLine());
            double_number[1] = Convert.ToDouble(Console.ReadLine());
            double_number[2] = Convert.ToDouble(Console.ReadLine());
            double_number[3] = Convert.ToDouble(Console.ReadLine());
            double_number[4] = Convert.ToDouble(Console.ReadLine());

            float[] float_number = new float[5];
            Console.Write("Insert 5 Float Numbers one by one by clicking Enter after 1 value \n");
            float_number[0] = float.Parse(Console.ReadLine());
            float_number[1] = float.Parse(Console.ReadLine());
            float_number[2] = float.Parse(Console.ReadLine());
            float_number[3] = float.Parse(Console.ReadLine());
            float_number[4] = float.Parse(Console.ReadLine());

            string[] string_number = new string[5];
            Console.Write("Insert 5 String values one by one by clicking Enter after 1 value \n");
            string_number[0] = Console.ReadLine();
            string_number[1] = Console.ReadLine();
            string_number[2] = Console.ReadLine();
            string_number[3] = Console.ReadLine();
            string_number[4] = Console.ReadLine();

            DateTime[] Date_time = new DateTime[5];
            Console.Write("Insert 5 Dates Format: (MM/DD/YYYY H:M:S AM/PM) one by one by clicking Enter after 1 value \n");
            Date_time[0] = DateTime.Parse(Console.ReadLine());
            Date_time[1] = DateTime.Parse(Console.ReadLine());
            Date_time[2] = DateTime.Parse(Console.ReadLine());
            Date_time[3] = DateTime.Parse(Console.ReadLine());
            Date_time[4] = DateTime.Parse(Console.ReadLine());

            decimal[] dec_number = new decimal[5];
            Console.Write("Insert 5 decimal Numbers one by one by clicking Enter after 1 value \n");
            dec_number[0] = decimal.Parse(Console.ReadLine());
            dec_number[1] = decimal.Parse(Console.ReadLine());
            dec_number[2] = decimal.Parse(Console.ReadLine());
            dec_number[3] = decimal.Parse(Console.ReadLine());
            dec_number[4] = decimal.Parse(Console.ReadLine());

            long[] long_number = new long[5];
            Console.Write("Insert 5 long Numbers one by one by clicking Enter after 1 value \n");
            long_number[0] = long.Parse(Console.ReadLine());
            long_number[1] = long.Parse(Console.ReadLine());
            long_number[2] = long.Parse(Console.ReadLine());
            long_number[3] = long.Parse(Console.ReadLine());
            long_number[4] = long.Parse(Console.ReadLine());

            bool[] bool_number = new bool[5];
            Console.Write("Insert 5 boolian values formate(true/fales) one by one by clicking Enter after 1 value \n");
            bool_number[0] = Convert.ToBoolean(Console.ReadLine());
            bool_number[1] = Convert.ToBoolean(Console.ReadLine());
            bool_number[2] = Convert.ToBoolean(Console.ReadLine());
            bool_number[3] = Convert.ToBoolean(Console.ReadLine());
            bool_number[4] = Convert.ToBoolean(Console.ReadLine());

            Console.Write("The integer data types single dimention arrays are: ");
            Console.Write("\n" + integer[0] + " ");
            Console.Write(integer[1] + " ");
            Console.Write(integer[2] + " ");
            Console.Write(integer[3] + " ");
            Console.Write(integer[4] + "\n\n");

            Console.Write("The double data types single dimention arrays are: ");
            Console.Write("\n" + double_number[0] + " ");
            Console.Write(double_number[1] + " ");
            Console.Write(double_number[2] + " ");
            Console.Write(double_number[3] + " ");
            Console.Write(double_number[4] + "\n\n");

            Console.Write("The float data types single dimention arrays are: ");
            Console.Write("\n" + float_number[0] + " ");
            Console.Write(float_number[1] + " ");
            Console.Write(float_number[2] + " ");
            Console.Write(float_number[3] + " ");
            Console.Write(float_number[4] + "\n\n");

            Console.Write("The string data types single dimention arrays are: ");
            Console.Write("\n" + string_number[0] + " ");
            Console.Write(string_number[1] + " ");
            Console.Write(string_number[2] + " ");
            Console.Write(string_number[3] + " ");
            Console.Write(string_number[4] + "\n\n");

            Console.Write("The DateTime data types single dimention arrays are: ");
            Console.Write("\n" + Date_time[0] + " ");
            Console.Write(Date_time[1] + " ");
            Console.Write(Date_time[2] + " ");
            Console.Write(Date_time[3] + " ");
            Console.Write(Date_time[4] + "\n\n");

            Console.Write("The decimal data types single dimention arrays are: ");
            Console.Write("\n" + dec_number[0] + " ");
            Console.Write(dec_number[1] + " ");
            Console.Write(dec_number[2] + " ");
            Console.Write(dec_number[3] + " ");
            Console.Write(dec_number[4] + "\n\n");

            Console.Write("The long data types single dimention arrays are: ");
            Console.Write("\n" + long_number[0] + " ");
            Console.Write(long_number[1] + " ");
            Console.Write(long_number[2] + " ");
            Console.Write(long_number[3] + " ");
            Console.Write(long_number[4] + "\n\n");

            Console.Write("The bool data types single dimention arrays are: ");
            Console.Write("\n" + bool_number[0] + " ");
            Console.Write(bool_number[1] + " ");
            Console.Write(bool_number[2] + " ");
            Console.Write(bool_number[3] + " ");
            Console.Write(bool_number[4] + "\n\n");
        }
    }
}
