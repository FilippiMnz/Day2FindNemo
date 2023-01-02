using System;
namespace FindNemo
{

    
    class Program
    {
        static void Main(string[] args)
        {
            // this application can be executed either in an "automated" way or by inserting data by the client
            Console.WriteLine("Escreva a frase");
            string nemoCliente = Console.ReadLine();
            // or 

            // string str = "I am finding Nemo !";

            FindingNemo instence = new FindingNemo();
            instence.str = nemoCliente;
            Console.WriteLine(instence.FoundNemo());

        }
    }

    public class FindingNemo
    {
        public string str;
        public string FoundNemo()
        {
            string[] strSplit = str.Split(' ');
            int i = 0;
            string output = string.Empty;
            foreach (var word in strSplit)
            {
                if (word == "Nemo")
                {
                    output = "I found Nemo at " + (i + 1) + "!";
                    break;
                }
                else
                {
                    output = "Nemo deu a fuga";
                }

                i++;
            }

            return (output);
        }
    }
}
