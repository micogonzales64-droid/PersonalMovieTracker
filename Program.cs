using System.ComponentModel.Design;

namespace PersonalMovieTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = new List<string>();
            List<string> password = new List<string>();
            usernames.Add("Tristan123");
            password.Add("trstngnzls");

            while (true)
            {
                Console.WriteLine("=====================================");
                Console.WriteLine("||WELCOME TO PERSONAL MOVIE TRACKER!||");
                Console.WriteLine("=====================================");
                Console.WriteLine("1.Login\n2.Create Account\n3.Exit");
                Console.WriteLine("---------------------------------");
                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Login");
                        Console.WriteLine("==========");

                        Console.WriteLine("Enter Username");
                        string username = Console.ReadLine();

                        Console.WriteLine("Enter Password");
                        string pass = Console.ReadLine();

                        bool login = false;
                        string user = "";

                        for (int i = 0; i < usernames.Count; i++)
                        {
                            if (username == usernames[i] && pass == password[i])
                            {
                                login = true;
                                user = usernames[i];
                                break;
                            }
                        }
                        if (login)
                        {
                            Console.WriteLine("Welcome " + user);
                            Console.WriteLine("What brings u here today? ");
                            Console.WriteLine("1.Available movie to purchase");
                            Console.WriteLine("2.View my movie collection ");
                            Console.WriteLine("3.Logout");
                            Console.WriteLine();
                            int choice = Convert.ToInt32(Console.ReadLine());

                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine("Available Movie's to purchase: \n1.Avengers Doomsday = 100P \n2.Logan = 100P");
                                    Console.WriteLine("Select a movie to purchase: ");
                                    int moviechoice = Convert.ToInt32(Console.ReadLine());

                                    switch (moviechoice)
                                    {
                                        case 1:
                                            Console.WriteLine("Thankyou for purchasing Avengers Doomsday" + user);
                                            break;

                                        case 2:
                                            Console.WriteLine("Thankyou for purchasing Logan" + user);
                                            break;
                                        case 3:
                                            Console.WriteLine("Logging out.....");
                                            break;
                                    }

                                    break;

                                case 2:
                                    Console.Write(user + " Movie Collections\n");
                                    Console.Write("1. The notebook\n");
                                    Console.Write("2. Monster's University\n");
                                    Console.WriteLine("----------------------\n");

                                    Console.WriteLine("Do you want to add a movie?");
                                    Console.WriteLine("1. Yes\n2. No");

                                    int decision = Convert.ToInt32(Console.ReadLine());

                                    switch (decision)
                                    {
                                        case 1:
                                            Console.WriteLine("Movies you want to add: ");
                                            Console.ReadLine();
                                            Console.WriteLine("Movies are added to your collection");
                                            break;

                                        case 2:
                                            Console.WriteLine("Exit");
                                            break;
                                    }

                                    break;
                                case 3:
                                    Console.WriteLine("Logging out.....");
                                    break;
                            }
                        }


                        else
                        {
                            Console.WriteLine("Incorrect username or password");
                        }
                        break;

                    case 2:
                        Console.WriteLine("_______________");
                        Console.WriteLine("Create Account|");
                        Console.WriteLine("______________|");
                        Console.WriteLine("Username: ");
                        String NewUser = Console.ReadLine();
                        Console.WriteLine("Password: ");
                        String NewPassword = Console.ReadLine();

                        usernames.Add(NewUser);
                        password.Add(NewPassword);
                        Console.WriteLine("Account Created Successfully!");


                        break;

                    case 3:
                        Console.WriteLine("GOODBYE");
                        return;
                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
            }
        }

    }
}


