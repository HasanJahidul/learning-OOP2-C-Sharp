using System;

namespace _18_38489_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String input,name;
            int id,amount,operationOption;
            Console.Write("Enter Account type:\n1.Current Account\n2.Savings Account\nInput:  ");
            input = Console.ReadLine();
            int scan = Convert.ToInt32(input);

            switch (scan)
            {
                case 1:
                    {
                        
                        Console.Write("Enter Name: ");
                        name = Console.ReadLine();

                        Console.Write("Enter ID: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        if (id > 999999 && id < 10000000)
                        {


                            Console.Write("Enter Account type:\n1.Personal \n2.Salary\n3.Student\nInput:  ");
                            String input2 = Console.ReadLine();
                            int accountType = Convert.ToInt32(input2);

                            Current c = new Current(accountType, name, id, new AccountOpeningDate(4, 2, 2013));

                            Console.WriteLine("Enter Action: \n1.Withdraw\n2.Deposite");
                            operationOption = Convert.ToInt32(Console.ReadLine());
                           

                            switch (operationOption)
                            {
                                case 1:
                                    {
                                        Console.Write("Enter Amount: ");
                                        amount = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("\n ");

                                        if (amount <= 0)
                                        {
                                            Console.WriteLine("Invalid Amount......");
                                        }
                                        else
                                        {
                                            c.Withdraw(amount);
                                        }
                                        

                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write("Enter Amount: ");
                                        amount = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("\n ");

                                        if (amount <500)
                                        {
                                            Console.WriteLine("Invalid Amount......");
                                        }
                                        else
                                        {
                                            c.Deposit(amount);
                                        }


                                        break;

                                    }
                                default:
                                    {
                                        Console.WriteLine("Invalid Operation Choice.....");
                                        break;

                                    }


                            }
                            c.Show();
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid Id......\n");
                        }
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter Name: ");
                         name = Console.ReadLine();

                        Console.Write("Enter ID: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        if (id > 999999 && id < 10000000)
                        {
                            Console.Write("Enter Account Duration: ");
                            int duration = Convert.ToInt32(Console.ReadLine());

                            Savings S = new Savings(name, id, new AccountOpeningDate(11, 12, 2010), duration);
                            Console.WriteLine("Enter Action: \n1.Withdraw\n2.Deposite");
                            operationOption = Convert.ToInt32(Console.ReadLine());

                            switch (operationOption)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Enter Amount: ");
                                        amount = Convert.ToInt32(Console.ReadLine());

                                        if (amount <= 0)
                                        {
                                            Console.WriteLine("Invalid Amount......");
                                        }
                                        else
                                        {
                                            S.Withdraw(amount);
                                        }
                                        //S.Show();
                                        break;
                                    }

                                case 2:
                                    {
                                        Console.Write("Enter Amount: ");
                                        amount = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("\n ");

                                        if (amount < 500)
                                        {
                                            Console.WriteLine("Invalid Amount......");
                                        }
                                        else
                                        {
                                            S.Deposit(amount);
                                        }
                                        //S.Show();


                                        break;

                                    }
                                default:
                                    {
                                        Console.WriteLine("Invalid Operation Choice.....");
                                        break;

                                    }

                            }
                            S.Show();
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid Id......\n");
                        }


                        break;
                    }
                default:
                    {
                        Console.WriteLine("Worng Input Occured...........");
                        break;
                    }

            }
         } 
    }
}
