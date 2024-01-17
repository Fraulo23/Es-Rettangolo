using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Rettangolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float l1=float.Parse(Console.ReadLine());
            float l2=float.Parse(Console.ReadLine());
            Rettangolo r=new Rettangolo(l1,l2);
            Console.WriteLine("Area e perimetro rettangolo");
            Console.WriteLine(r.Area());
            Console.WriteLine(r.Perimetro());
            float lq=float.Parse(Console.ReadLine());
            Rettangolo q=new Rettangolo(lq,lq);
            Console.WriteLine("Area e perimetro quadrato");
            Console.WriteLine(q.Area());
            Console.WriteLine(q.Perimetro());
            Console.ReadLine();
        }
    }
}
