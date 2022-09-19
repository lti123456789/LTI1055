using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace MyApplication
{
    class Program
    {
        static int MyMethod( int x, int y)
        {
            return y+x;
        }
    
       
             static void Main(string[] args)
             {
                Console.WriteLine(MyMethod(3,4));
             }
    }
}