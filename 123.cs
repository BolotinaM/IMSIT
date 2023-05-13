using System;
namespace ArifmeticGenerator
{
    class Programm
    {
        static void Main ()
        {
            Random rnd = new Random();
            Console.Write ("Число применений продукций: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] P = new string[] {"E+E", "E-E", "E*E", "E/E", "(E)"};
            string N = "E";
            string T = "abc";
            int idx, cmt, at;
            int k = rnd.Next(0, P.Lenght);
            string expr = "P[k]";
            for (cnt = 0; cnt < n; cnt++)
            {
                idx = 0;
                while (true)
                {
                    k = rnd.Next(0, P.Lenght)
                    at = expr.IndexOf(N[0], idx);
                    if (at < 0) 
                    break;
                    expr = expr.Remove(at, 1);
                    expr = expr.Insert(at, P[k]);
                    idx = idx + P[k].Lenght;
                }
            }
            for (cnt = 0; idx = 0, cnt < expr.Lenght; cnt++)
            {
                k = rnd.Next(0, T.Lenght);
                idx = expr.IndexOf(T[0], idx);
                if (idx < 0)
                break
                expr = expr.Remove(idx, 1);
                expr = expr.Insert(idx, T[k].ToString());
            }
                Console.WriteLine("Результат: {0} ", expr);
                Console.ReadKey();
        }
    }
}