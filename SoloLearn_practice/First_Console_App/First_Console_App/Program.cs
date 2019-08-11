using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Console_App
{
    class Program
    {
        #region Pointer : out
        static int Test(out int x, int y = 4)
        {
            x = 6;
            return x * y;
        }
        #endregion

        static void Main(string[] args)
        {
            #region Xuly chuoi

            #region trim()
            string temString = " 123 456 ";
            Console.WriteLine(temString);            
            Console.WriteLine(temString.Trim());

            #endregion

            #endregion

            #region display string to cmd.

            //int x = 10;
            //double y = 100;

            //Console.WriteLine("khuu xuan ngoc");
            //Console.WriteLine("x= {0}, y = {1}", x,y);

            #endregion

            #region Pointer : out

            //int a;
            //int z = Test(out a);
            //Console.WriteLine(a + z);

            #endregion

            #region Chuong trinh chuyen tung ký tự thành byte vd: '1' => 48

            //string myString = "0123456789";
            //Console.WriteLine(Convert.ToSByte(myString[1]));
            ////myString[1] = '3'; //Lỗi
            //Console.WriteLine(Convert.ToSByte(myString[1]));

            #endregion

            #region read string from user input cmd.

            //string myname = "";
            //myname = Console.ReadLine();
            //Console.WriteLine("my name is: {0}", myname);

            #endregion

            #region convert number

            //int age = 0;
            //age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("My age is {0}", age);

            #endregion

            #region bị Lỗi var nếu chưa gán giá trị

            //var bol = true;
            ////bol = true;
            //Console.WriteLine(bol);

            #endregion

            Console.ReadKey();
        }
    }
}
