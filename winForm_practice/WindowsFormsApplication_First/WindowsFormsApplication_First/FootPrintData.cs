using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication_First
{
    public class FootPrintData
    {
        public string Name { get; set; }
        public byte Width { get; set; }
        public byte Long { get; set; }
        public byte Height { get; set; }
        public byte Mirror { get; set; }
        public byte AngeInLayout { get; set; }
        public byte AngeAtFeeder1 { get; set; }

        public string getString()
        {
            Int64 temValue = 0;
            temValue += ((Int64)Width << (8 * 0));
            temValue += ((Int64)Long << (8 * 1));
            temValue += ((Int64)Height << (8 * 2));
            temValue += ((Int64)Mirror << (8 * 3));
            temValue += ((Int64)AngeInLayout << (8 * 4));
            temValue += ((Int64)AngeAtFeeder1 << (8 * 5));
            //temValue += ((UInt64)Long << (8 * 6));
            //temValue += ((UInt64)Long << (8 * 7));


            return temValue.ToString();
        }

        public void getValueFromString(string inputString_)
        {
            if (inputString_ == "") return;

            Int64 temValue = Convert.ToInt64(inputString_);

            Width = (byte)temValue;
            Long = (byte)(temValue >> (8 * 1));
            Height = (byte)(temValue >> (8 * 2));
            Mirror = (byte)(temValue >> (8 * 3));
            AngeInLayout = (byte)(temValue >> (8 * 4));
            AngeAtFeeder1 = (byte)(temValue >> (8 * 5));
        }
    }
}
