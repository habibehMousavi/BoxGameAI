using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace ConsoleApplication5
{
   class Program
    {

        public int turn = 0;
        public string message = "";
        public int[] move = new int[4];


        static void Main(string[] args)
        {
            Program p = new Program();
         //  p.manageServerMessage("Start()");
            //p.manageServerMessage("Recived()");
           // //p.manageServerMessage("[1,1,1,1]");???
           // p.manageServerMessage("Time`sUP()|[1,1,1,1]");
           // p.manageServerMessage("InValid()|[1,1,1,1]");
             p.manageServerMessage("Bonus(+2,A)|[1,1,1,1]");
             p.manageServerMessage("Bonus(+1,A)|[1,1,1,1]");
             p.manageServerMessage("Bonus(+2,A)");
             p.manageServerMessage("Bonus(+1,A)");
           // // manageServerMessage('Time`sUP()|[1,1,1,1]Bonus(+1,A)');
           // // manageServerMessage('InValid()|[1,1,1,1]Bonus(+1,A)');
        }

        public void manageServerMessage(string text)

        {
            string regexBracket = @"Bonus\(\+([1-2]),[A-B]\)(\|\[([0-9]),([0-9]|1[0-4]),([0-9]),([0-9]|1[0-4])])";

            Regex r = new Regex(regexBracket, RegexOptions.IgnoreCase);

            Match m = r.Match(text);

            if (m.Success)
            {
                int count;

                count = Convert.ToInt16(m.Groups[1]);


                if (m.Groups[3] == null)
                    turn = count;
                else
                    turn = -count + 1;
            


                move[0] = Convert.ToInt16(m.Groups[3]);
                move[1] = Convert.ToInt16(m.Groups[4]);
                move[2] = Convert.ToInt16(m.Groups[5]);
                move[3] = Convert.ToInt16(m.Groups[6]);
            }



            Console.WriteLine("turn:");
            Console.WriteLine(turn.ToString());
            Console.WriteLine("");

            Console.WriteLine("move:");
            Console.WriteLine(string.Join(",", move));
            Console.WriteLine("");

            Console.WriteLine("message:");
            Console.WriteLine(message);
            Console.WriteLine("");

        }
    }
}


