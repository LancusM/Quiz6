using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Prompts user to enter both candidate names
            Console.WriteLine("PRESIDENTIAL VOTING");
            Console.WriteLine();
            Console.WriteLine("Input the name of candidate 1:");
            string candidateName1 = Console.ReadLine();
            Console.WriteLine("Input the name of candidate 2:");
            string candidateName2 = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine("Who do you want to vote for? (1 for " + candidateName1 + ", 2 for " + candidateName2 + ", 0 to exit program.)");
            int vote = Convert.ToInt32(Console.ReadLine());


            //while loop to check for vote not equaling 0

            //Except for some reason, it shecks that while vote DOES equal 0, it will then do the statement, and inputting 1 or 2 still works?
            //I am very lost on why this while statement is like this. Also the warnings say it is possibly empty???
            while (vote == 0);
            {
                /* I am 100% aware that it is not good for my grades if I leave these quizzes unfinished like this,
                 * but I truly don't know how to process the votes into a percentage collection, or even if we've touched on that.
                 * I have to admit, I think I'd remember learning in class about how to do things like this. But I don't,
                 * and unless the single day I missed had both this and last quiz's info, I'm not too sure about it.
                 * I'll accept the grade anyway, just know that I did as much as I knew to do. */
                if (vote == 1)
                {
                    Console.WriteLine("Voting Result:");
                    Console.WriteLine(candidateName1);
                    Console.WriteLine(candidateName2);
                }
                else if (vote == 2)
                {
                    Console.WriteLine("Voting Result:");
                    Console.WriteLine(candidateName1);
                    Console.WriteLine(candidateName2);

                }

                Console.WriteLine();
                Console.WriteLine("Who do you want to vote for? (1 for " + candidateName1 + ", 2 for " + candidateName2 + ", 0 to exit program.)");
                vote = Convert.ToInt32(Console.ReadLine());

                Console.ReadLine();
            }

            Console.WriteLine("Final Result:");

            //there would be (candidateName1 + /something/), but again, never even saw a lesson on how that works. I know the syntax for all but that part, so hey.
            Console.WriteLine(candidateName1);
            Console.WriteLine(candidateName2);

        }
    }
}
