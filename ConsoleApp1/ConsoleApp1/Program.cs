using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"F:\Fernando\Curso\c#\Sistemas\TrabalhandoComArqUsing\File1.txt";

           try
            {
                /*
                 * usando o using para fechamento automatico do arq no final
                 * sem a necessidade de utilizar o finally
                 */
                 
                using (StreamReader sr = File.OpenText(path))
                {
                    while (! sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro");
                Console.WriteLine(e.Message);
            }
            finally
            {

            }


        }
    }
}
