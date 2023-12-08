using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace projetoArqTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string s1 = "teste";
            string s2 = "mais um teste";

            DateTime agora = DateTime.Now;

            StreamWriter arq = new StreamWriter("arq" + agora.Second.ToString() + ".txt");
            
            arq.Write(agora.ToString());
            arq.Write(" - ");
            arq.Write(s1);
            arq.Write(" - ");
            arq.WriteLine(s2);

            arq.Close();
            */

            
            StreamReader arq = new StreamReader("arq41.txt");

            while (!arq.EndOfStream)
            {
                Console.WriteLine(arq.ReadLine());
            }
            arq.Close();

            Console.WriteLine("Fim");
            Console.ReadKey();
            
        }
    }
}
