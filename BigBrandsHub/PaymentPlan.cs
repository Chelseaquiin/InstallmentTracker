namespace BigBrandsHub
{
    internal partial class Run
    {

        public void Init()
        {
            do
            {
                Console.WriteLine("Thank you for choosing us. Please select a payment plan");
                Console.WriteLine("1. Pay Immediately");
                Console.WriteLine("2. Pay in installments");
                Console.WriteLine("4. Return");
                Console.WriteLine("5. Cancel Transaction");

                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)

                {
                    case 1:
                        PayImmediately();
                        break;
                    case 2:
                        PayInInstallments();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                    case 4:
                        return;
                    case 5:
                        Console.WriteLine("Thank you");
                        LogOut();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (true);

        }

        private void PayImmediately()
        {
            if (user.Wallet >= gadget.Price)
            {
                string userName = "BBN";

                userToTransferTo = userList.FirstOrDefault<UserDetails>(a => a.UserName == userName);

                userToTransferTo.Wallet += gadget.Price;
                user.Wallet -= gadget.Price;
                Console.WriteLine("Payment accepted");
                Console.WriteLine($"New Balance: {user.Wallet}");
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }

        public void PayInInstallments()
        {
            Console.WriteLine("Which Installment plan is best for you?");
            Console.WriteLine("1. Daily payment");
            Console.WriteLine("2. Weekly payment");
            Console.WriteLine("3. Bi-Weekly payment");
            Console.WriteLine("4. Monthly payment");
            Console.WriteLine("5. Pay every 6 months");
            Console.WriteLine("6. Pay every year");
            Console.WriteLine("7. Exit");

            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    DailyPayment();
                    break;
                case 2:
                    WeeklyPlan();
                    break;
                case 3:
                    BiWeeklyPlan();
                    break;
                case 4:
                    MonthlyPlan();
                    break;
                case 5:
                    SixMonthsPlan();
                    break;
                case 6:
                    YearlyPlan();
                    break;
                case 7:

                    return;
                default:
                    break;
            }
        }

        private void YearlyPlan()
        {
            decimal yearlyPay = 20000;
            decimal interestRate = 0.2m * gadget.Price;
            decimal yearlyAmount = yearlyPay + interestRate;


            Console.WriteLine($"Your interest rate is {interestRate}");
            Console.WriteLine($"You are to pay {yearlyAmount} every year");
            if (user.Wallet >= yearlyAmount)
            {
                string userName = "BBN";

                userToTransferTo = userList.FirstOrDefault<UserDetails>(a => a.UserName == userName);

                gadget.Price -= yearlyPay;
                userToTransferTo.Wallet += gadget.Price;

                user.Wallet -= yearlyAmount;
                Console.WriteLine($"You laptop price is now {gadget.Price}");
                Console.WriteLine($"Your yearly amount has been deducted. Your balance is now {user.Wallet}");
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
            }
        }

        private void SixMonthsPlan()
        {
            decimal sixMonthsPay = 10000m;
            decimal interestRate = 0.1m * gadget.Price;
            decimal sixMonthsAmount = sixMonthsPay + interestRate;

            Console.WriteLine($"Your interest rate is {interestRate}");
            Console.WriteLine($"You are to pay {sixMonthsAmount} every six months");
            if (user.Wallet >= sixMonthsAmount)
            {
                string userName = "BBN";

                userToTransferTo = userList.FirstOrDefault<UserDetails>(a => a.UserName == userName);
                gadget.Price -= sixMonthsPay;

                userToTransferTo.Wallet += gadget.Price;



                user.Wallet -= sixMonthsAmount;
                Console.WriteLine($"You laptop price is now {gadget.Price}");
                Console.WriteLine($"Your balance is now {user.Wallet}");
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
            }
        }

        private void MonthlyPlan()
        {
            decimal monthlyPay = 4000;
            decimal interestRate = 0.04m * gadget.Price;
            decimal monthlyAmount = monthlyPay + interestRate;

            Console.WriteLine($"Your interest rate is {interestRate}");
            Console.WriteLine($"You are to pay {monthlyAmount} every month");
            if (user.Wallet >= monthlyAmount)
            {
                string userName = "BBN";

                userToTransferTo = userList.FirstOrDefault<UserDetails>(a => a.UserName == userName);
                gadget.Price -= monthlyPay;

                userToTransferTo.Wallet += gadget.Price;

                user.Wallet -= monthlyAmount;
                Console.WriteLine($"You laptop price is now {gadget.Price}");
                Console.WriteLine($"Your Monthly amount has been deducted. Your balance is now {user.Wallet}");
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
            }
        }

        private void BiWeeklyPlan()
        {
            decimal biWeeklyPay = 3000m;
            decimal interestRate = 0.01m * gadget.Price;
            decimal biWeeklyAmount = biWeeklyPay + interestRate;

            Console.WriteLine($"Your interest rate is {interestRate}");
            Console.WriteLine($"You are to pay {biWeeklyAmount} every two weeks");
            if (user.Wallet >= biWeeklyAmount)
            {
                string userName = "BBN";

                userToTransferTo = userList.FirstOrDefault<UserDetails>(a => a.UserName == userName);
                gadget.Price -= biWeeklyPay;

                userToTransferTo.Wallet += gadget.Price;


                user.Wallet -= biWeeklyAmount;
                Console.WriteLine($"You laptop price is now {gadget.Price}");
                Console.WriteLine($"Your bi-weekly amount has been deducted. Your balance is now {user.Wallet}");
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
            }
        }

        private void WeeklyPlan()
        {
            decimal weeklyPay = 2000;
            decimal interestRate = 0.02m * gadget.Price;
            decimal weeklyAmount = weeklyPay + interestRate;

            Console.WriteLine($"Your interest rate is {interestRate}");
            Console.WriteLine($"You are to pay {weeklyAmount} every week");
            if (user.Wallet >= weeklyAmount)
            {
                string userName = "BBN";

                userToTransferTo = userList.FirstOrDefault<UserDetails>(a => a.UserName == userName);
                gadget.Price -= weeklyPay;

                userToTransferTo.Wallet += gadget.Price;

                user.Wallet -= weeklyAmount;
                Console.WriteLine($"You laptop price is now {gadget.Price}");
                Console.WriteLine($"Your weekly amount has been deducted. Your balance is now {user.Wallet}");
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
            }
        }

        private void DailyPayment()
        {
            decimal dailyPay = 1000m;
            decimal interestRate = 0.01m * gadget.Price;
            decimal dailyAmount = dailyPay + interestRate;

            Console.WriteLine($"Your interest rate is {interestRate}");
            Console.WriteLine($"You are to pay {dailyAmount} everyday");
            if (user.Wallet >= dailyAmount)
            {

                string userName = "BBN";

                userToTransferTo = userList.FirstOrDefault<UserDetails>(a => a.UserName == userName);

                gadget.Price -= dailyPay;
                userToTransferTo.Wallet += gadget.Price;

                user.Wallet -= dailyAmount;
                Console.WriteLine($"You laptop price is now {gadget.Price}");
                Console.WriteLine($"Your daily amount has been deducted. Your balance is now {user.Wallet}");
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
            }

        }
        public void Transfer()
        {
            try
            {
                Console.WriteLine();

                decimal amount = Convert.ToDecimal(Console.ReadLine());



                if (user.Wallet >= gadget.Price)
                {
                    userToTransferTo.Wallet += amount;

                    user.Wallet -= amount;

                    Console.WriteLine($"\nTransfer to {userToTransferTo.Fullname} was successful. \nYour Balance is: {user.Wallet}");
                }
                else
                {

                    Console.WriteLine("\ncard not recognized or Insufficient funds");
                    Console.WriteLine($"Balance {user.Wallet}");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}

