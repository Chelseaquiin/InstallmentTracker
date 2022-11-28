namespace BigBrandsHub
{
    internal partial class Run
    {
        Gadgets gadget = new Gadgets();
        UserDetails user = new UserDetails();
        UserDetails userToTransferTo = new UserDetails();
        List<UserDetails> userList = new List<UserDetails>();


        public void LogIn()
        {
            do
            {
                try
                {
                    userList.Add(new UserDetails("Big Brands Hub", "BBN", 0000, "9999", 1000000000));
                    userList.Add(new UserDetails("Uzoamaka Nweze", "Chelseaquiin", 1111, "1234", 789000000));
                    userList.Add(new UserDetails("Alex King", "Alexy", 2222, "5678", 549000000));

                    Console.WriteLine("Please Enter your username");
                    string userName = Console.ReadLine();
                    


                    user = userList.FirstOrDefault<UserDetails>(a => a.UserName == userName);


                    if (user.UserName == userName)
                    {
                        

                    }

                    Console.WriteLine("Please enter your password");

                    string password = Console.ReadLine();

                    if (user.Password == password)
                    {
                        Console.WriteLine($"Welcome {user.Fullname}!");
                        Welcome();
                    }

           

                }

                catch (FormatException e) { Console.WriteLine(e.Message); }
                catch
                {
                    Console.WriteLine("UserName Not recognized.");
                

                }
            } while (true);

        }




        public void LogOut() { Environment.Exit(0); }

        public void ViewAccount()
        {

        }
        public decimal FundWallet(decimal amount)
        {

            decimal wallet = amount;

            user.Wallet += wallet;

            return user.Wallet;
        }
        public void CreateAnAccount()
        {
            try
            {
                Console.WriteLine("Please Enter your FullName");
                string fullName = Console.ReadLine();
                Console.WriteLine("Please enter your username");
                string userName = Console.ReadLine();
                Console.WriteLine("Please your unique ID");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter your password");
                string password = Console.ReadLine();
                Console.WriteLine("How much do you want to fund your account with?");
                decimal amount = Convert.ToDecimal(Console.ReadLine());

                decimal wallet = FundWallet(amount);
                userList.Add(new UserDetails(fullName, userName, id, password, wallet));

                LogIn();

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch
            {

                Console.WriteLine("Hmmm");
            }
        }

        public void Welcome()
        {
            do
            {
                try
                {
                    Console.WriteLine("This is the home of Gadgets");
                    Console.WriteLine("Please select an option");
                    Console.WriteLine("1. Buy a Gadget");
                    Console.WriteLine("2. View Balance");
                    Console.WriteLine("3. Fund Your Wallet");
                    Console.WriteLine("4. Return");
                    Console.WriteLine("5. Log Out");

                    int userInput = int.Parse(Console.ReadLine());

                    switch (userInput)
                    {
                        case 1:
                            Start();
                            break;
                        case 2:
                            ViewBalance();
                            break;
                        case 3:
                            Console.WriteLine("Please enter the amount you want to deposit in your wallet");
                            decimal amount = decimal.Parse(Console.ReadLine());
                            FundWallet(amount);
                            break;
                        case 4:
                            return;
                        case 5:
                            LogOut();
                            return;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (true);
        }

        private void ViewBalance()
        {
            Console.WriteLine("Insert your ID");

            int id = int.Parse(Console.ReadLine());

            if (user.ID != id)
            {
                Console.WriteLine("Access denied");
            }
            else
            {
                Console.WriteLine($"Your balance is {user.Wallet}");
            }
        }

        public void StartApplication()
        {


            int userInput = 0;
            do
            {
                Console.WriteLine("Welcome to Big Brands Hub");
                Console.WriteLine("Do you have an account with us?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                Console.WriteLine("3. Exit");

                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());

                    switch (userInput)
                    {
                        case 1:
                            LogIn();
                            break;
                        case 2:
                            CreateAnAccount();
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.WriteLine("Thank you");
                            return;
                        default:
                            Console.WriteLine();
                            break;
                    }

                    Console.WriteLine("Please select a valid option");
                }

                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (userInput != 3);
        }
    }
}
