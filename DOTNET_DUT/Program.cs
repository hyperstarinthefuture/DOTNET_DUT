using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOTNET_DUT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        //static void Main(string[] args)
        //{
        //    //Parse(); TryParse();
        //    /*
        //    int x = 1, y,z;
        //    Console.Write("Input x = ");
        //    x = int.Parse(Console.ReadLine());
        //    Console.WriteLine(x + 1);
        //    int.TryParse(Console.ReadLine(),out y);
        //    Console.WriteLine(y + 1);
        //    z = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine(z + 1);
        //    Console.WriteLine("Hello World!");
        //    */
        //    //Ref & out
        //    /*
        //    int m ,n;
        //    m = int.Parse(Console.ReadLine());
        //    n = int.Parse(Console.ReadLine());
        //    HV(ref m,ref n);
        //    Console.WriteLine("m = " + m + " n = " + n);
        //    A(out m);
        //    Console.WriteLine("m = " + m);
        //    */
        //    //Array
        //    int s;
        //    s = int.Parse(Console.ReadLine());
        //    string[] Arr = new string[s];
        //    for (int i = 0; i < s; i++)
        //    {
        //        Arr[i] = Console.ReadLine();
        //    }
        //    foreach (string ch in Arr)
        //    {
        //        Console.WriteLine(ch);
        //    }
        //}
        //static void HV(ref int x, ref int y)
        //{
        //    int temp;
        //    temp = x;
        //    x = y;
        //    y = temp;
        //}
        //static void A(out int x)
        //{
        //    x = 5;
        //}
    }
}
