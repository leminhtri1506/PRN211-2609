using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventLINQ
{
    public delegate void PrintDeatails(string msg);

    class Program
    {
        event PrintDeatails Print;
        void Show(string msg) => Console.WriteLine(msg.ToUpper());
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Print += new PrintDeatails(p.Show);
            p.Print("Hung keu GauGau ");
            Console.ReadLine();
        }
    }
    
}