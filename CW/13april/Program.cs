namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Contains
            string w = "Varya";
            if (w.Contains("a"))
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("No");
            }

            char[] e = { 'a', ',', '5' };
            Console.WriteLine(e.Contains('a'));
            char[] pu = { '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/' };
            char x = 'a';
            if (pu.Contains(x))
            {
                Console.WriteLine("The symbol is punk");
            }
            else
            {
                Console.WriteLine("It is not punk");
            }
            //Replace
            string text = "Cat dog love";
            string text1 = text.Replace("dog", "more cats");
            Console.WriteLine(text1);
            string pr = "123121";
            Console.WriteLine(pr.Replace('1','5'));

            //Trim 
            string w1 = "    cat";
            string w2 = "cat";
            Console.WriteLine(w1.Contains(w2));
            w2 = w2.Trim(new char[] { ' ', 't' });
            Console.WriteLine(w2);

            //Split 
            string t1 = "Hello, my dear 2 friends";
            string[] dw = t1.Split(' ');
            foreach(string wt in dw)
            {
                Console.WriteLine(wt);
            }

            //Join
            string t2 = String.Join(" ", dw);
            Console.WriteLine(t2);

            //IsDigit/ IIsLetter
            char s = 'a';
            Console.WriteLine(Char.IsDigit(s));
            Console.WriteLine(Char.IsLetter(s));
            Console.WriteLine(Char.IsAsciiLetterOrDigit(s));

            //ToUpper/ToLower
            string w3 = "Hello";
            Console.WriteLine(w3.ToUpper());
            Console.WriteLine(w3.ToLower());

            string w4 = "olsekgngk";
            w4 += w4.ToUpper();
            Console.WriteLine(w4);

            string inp = "Hello, my dear 2 friends";
            int c = 0;
            string[] dw2 = inp.Split(' ');
            for (int i = 0; i< dw2.Length; i++)
            {
                string tw = dw2[i].Trim(pu);
                Console.WriteLine(tw);

                bool f = true;
                foreach (char.IsDigit(sy) sy in tw)
                 {

                 }
            }


        }
    }
}
