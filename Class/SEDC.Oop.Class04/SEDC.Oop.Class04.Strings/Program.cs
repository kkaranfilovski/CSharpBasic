using System;

namespace SEDC.Oop.Class04.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Kristijan";

            string hello1 = "Hello " + name;
            string hello2 = string.Format("hello {0}", name);
            Console.WriteLine(hello1);
            Console.WriteLine(hello2);
            string hello3 = $"Hello {name}";
            Console.WriteLine(hello3);


            string path = "check your c:\\ drive";
            string a = "we will have \"fair\" elections.";
            string b = "The \\n sign \n means: new line";

            Console.WriteLine(path);
            Console.WriteLine(a);
            Console.WriteLine(b);

            string path1 = @"check your c:\ drive";
            string aa = @"we will have ""fair"" elections";
            string bb = @"The \n sign means new line";

            Console.WriteLine(path1);
            Console.WriteLine(aa);
            Console.WriteLine(bb);

            string filePath = @"system\windows";
            string cc = $@"check your c:\\{filePath} drive";

            Console.WriteLine(cc);

            Console.WriteLine("====================================");

            string myStringCurrency = string.Format("{0:C}", 105.5);
            Console.WriteLine(myStringCurrency);

            int phoneNumber = 072210670;
            string formatedNumber = string.Format("{0:0##-###-###}", phoneNumber);
            Console.WriteLine(formatedNumber);

            string formatWithMultipleStrings = string.Format("{0} {1} {2} {3} {4} {5}", "hello", "my", "name", "is", "Kristijan", ".");
            Console.WriteLine(formatWithMultipleStrings);

            string ourString = "       We are learning c# and it is FUN and EASY, Okay maybe just FUN.";

            string lowerLetters = ourString.ToLower();
            Console.WriteLine(lowerLetters);

            string upperLetters = ourString.ToUpper();
            Console.WriteLine(upperLetters);

            string trimedString = ourString.Trim();
            Console.WriteLine(trimedString);

            string[] splitted = ourString.Trim().Split(' ');
            Console.WriteLine(splitted.Length);
            foreach (string item in splitted)
            {
                Console.WriteLine(item);
            }

            string subString = ourString.Trim().Substring(3, 8);
            Console.WriteLine(subString);

            Console.ReadLine();
        }
    }
}
