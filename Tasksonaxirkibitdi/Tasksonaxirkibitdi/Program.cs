using System;

namespace Tasksonaxirkibitdi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci ededi daxil edin: 3 reqemli olmalidir");
            string numstr1 = Console.ReadLine();
            Console.WriteLine("Ikinci ededi daxil edin: 3 reqemli olmalidir");
            string numstr2 = Console.ReadLine();
            Console.WriteLine("Ucuncu ededi daxil edin: 4 reqemli olmalidir");
            string numstr3 = Console.ReadLine();
            Console.WriteLine("Dorduncu ededi daxil edin: 4 reqemli olmalidir");
            string numstr4 = Console.ReadLine();
            Console.WriteLine("Besinci ededi daxil edin: 5 reqemli olmalidir");
            string numstr5 = Console.ReadLine();
            Console.WriteLine("Altinci ededi daxil edin: 5 reqemli olmalidir");
            string numstr6 = Console.ReadLine();
            Console.WriteLine("Yeddinci ededi daxil edin: 6 reqemli olmalidir");
            string numstr7 = Console.ReadLine();
            if (numstr1.Length+1 >=3 && numstr2.Length+1>= 3 && numstr3.Length+1>=4 && numstr4.Length+1>=4 && numstr5.Length+1>=5 && numstr6.Length+1>=5 && numstr7.Length+1>=6)
            {
                int numint1 = int.Parse(numstr1);
                int numint2 = int.Parse(numstr2);
                int numint3 = int.Parse(numstr3);
                int numint4 = int.Parse(numstr4);
                int numint5 = int.Parse(numstr5);
                int numint6 = int.Parse(numstr6);
                int numint7 = int.Parse(numstr7);

                //Ariphmetic methods
                int threeddigitsum = numint1 + numint2;

                int multiplefourdigit = numint3 * numint4;

                //Sum double result
                int sumtworesult = threeddigitsum + multiplefourdigit;

                //Stringify my result 
                string resulttostring = sumtworesult.ToString();

                //Adding num 7 to resulttostring
                string addingseventoresult = resulttostring + "7";

                //Parsing Co-result number 
                int result2 = int.Parse(addingseventoresult);

                //5 digits of number 
                int fivedigitnumsum = numint5 + numint6;

                //Add 5 digits of number to result2
                int result3 = result2 + fivedigitnumsum;

                //Three digit of number multiple and plus 1
                int threedigitmultiple = numint1 * numint2;
                string threedigitmultipletostr = threedigitmultiple.ToString();
                string addingonetoresult = threedigitmultipletostr + "1";
                int result4 = int.Parse(addingonetoresult);

                //Result4 - result3
                int result5 = result3 - result4;

                //Result5 - numint6
                int result6 = result5 + numint7;

                //three digit num and four digit num summary 
                int result7 = numint1 + numint2 + numint3 + numint4;

                //Resut6 - result7
                int result8 = result6 - result7;

                //Alinan cavabin 18 sonra 3 sonra 1 faizini tap
                double persentage18 = result8 * 0.18;
                double persentagein3 = persentage18 * 0.03;
                double persentagein1 = persentagein3 * 0.01;

                //Alinan cavablarin uzerine 5 reqemli ededlerin cemini gel
                double resultfinal = fivedigitnumsum + persentagein1;

                Console.WriteLine("--------");
                Console.WriteLine("Netice :");
                Console.WriteLine(resultfinal);

            }
            else
            {
                Console.WriteLine("Xais olunur sherte uygun ededler daxil edin!!!! Bir daha demeyecem!");
            }
        }
    }
}
