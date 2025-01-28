namespace santander_midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] txtpost = { "txt1", "txt2", "txt3", "txt4", "txt5", "txt6", "txt7", "txt8", "txt9", "txt10" };

            int[] skip = new int[10];
            int[] like = new int[10];
            int[] dislike = new int[10];

            for (int i = 0; i < txtpost.Length; i++)
            {

                Console.WriteLine(txtpost[i]);
                Console.WriteLine("a. react");
                Console.WriteLine("b. skip");
                string user_response = Convert.ToString(Console.ReadLine());

                if (user_response == "a" || user_response == "A")
                {
                    Console.WriteLine("=========================");
                    Console.WriteLine("a. like");
                    Console.WriteLine("b. dislike");
                    string user_react = Convert.ToString(Console.ReadLine());
                    if (user_react == "a" || user_react == "A")
                    {
                        like[i] = i;
                    }
                    else
                    {
                        dislike[i] = i;
                    }
                }

                else
                {
                    skip[i] = i;
                }


            }


            Console.WriteLine("Most Skipped");
            for (int i = 0; i < skip.Length; i++)
            {
                Console.WriteLine(txtpost[skip[i]] + " ");
            }
            Console.WriteLine("Most Liked");
            for (int i = 0; i < like.Length; i++)
            {
                Console.WriteLine(txtpost[like[i]] + " ");
            }
            Console.WriteLine("Most Disliked");
            for (int i = 0; i < dislike.Length; i++)
            {
                Console.WriteLine(txtpost[dislike[i]] + " ");
            }

        }
    }
}