using System;

namespace pract1
{
   
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Lib1.pow("ha", 4));
            Console.WriteLine(Lib1.Revers("xev"));
            Console.WriteLine(Lib1.remove("xeveer", "e"));
            Console.WriteLine(Lib1.lenght("xeveer"));
        }

public class Lib1
        {

            public static string pow(string a, int b)
            {
                string ready = "";
                for (int i = 0; i < b; i++)
                {
                    ready = ready + a;
                }
                return ready;
            }
            public static string Revers(string a)
            {
                int length = a.Length;
                char[] b = a.ToCharArray();
                string reverse = "";
                for (int i = length; i != 0; i--)
                {
                    reverse = reverse + b[i - 1];
                }
                return reverse;
            }
            public static string remove(string str, string s)
            {
                string ready = "";
                int rros = str.Length;
                int length_tr = s.Length;
                int kis = str.IndexOf(s);
                ready = str.Replace(s, "");

                return ready;
            }
            public static int lenght(string str)
            {
                int length = str.Length;
                return length;
            }
        }
    }
}




