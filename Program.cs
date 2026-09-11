    namespace PersonalMovieTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome User!");
            Console.Write("Enter username: ");
            string UserName = Console.ReadLine();
            Console.Write("Enter Password: ");
            string pword = Console.ReadLine();
            string User = "trstnmkcl";
            string pw = "12345";
            bool name = UserName == User;
            bool pass = pword == pw; 
            int total = 0;


            if (name)
            {
                Console.WriteLine("Welcome " + User);
                Console.WriteLine("What brings u here today? ");
                Console.WriteLine("1.Available movie to purchase");
                Console.WriteLine("2.View my movie collection ");
                Console.WriteLine("3.Add new movie to my collection ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Available Movie's to purchase: \n1.Avengers Doomsday = 100P \n2.Logan = 100P \nChoose a movie to purchase: ");
                        Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Thankyou For Purchasing " + User);
                        break;
                    case 2:
                        Console.WriteLine("trstnmkcl's movie collection\n 1.The notebook\n 2.Amazing Spiderman");
                        break;
                    case 3:
                        Console.Write("Movies to add: ");
                        Console.Read();
                        break;
                }

            }
            }
        }
    }
