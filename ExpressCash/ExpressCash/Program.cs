
using ExpressCash.NewFolder;
using System.ComponentModel.Design;

internal class Program
{

    private static void Main(string[] args)
    {

        Client client1 = new Client("Veliyev", "Togrul", 19, 1000,"Kapital", 500, 2022, "1234567891011121", "1234" );
        Client client2 = new Client("Qurbanov", "Yasin", 20, 900, 400, 2022);
        Client client3 = new Client("Qarayev", "Sahib", 21,2400, 300, 2022);
        Client client4 = new Client("Melikov", "Xetai", 22, 3000, 450, 2022);
        Client client5 = new Client("Namazov", "Vusal", 23, 2000, 670, 2022);


       


        Console.Write("lutfen 16 reqemli kodu daxil edin : ");
        string pan = Console.ReadLine();
        //throw new Exception("you must try again ");

        Console.Write("lutfen *pin* daxil edin : ");
        string pin = Console.ReadLine();


        if (pan ==client1.Card.Pan  && pin == client1.Card.Pin)
        {   
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"pan ve pin dogrudur {client1.Card.Fullname}");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(3000);

            Console.Clear();

            int select = 1 ; 
            do
            {

                if (select == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" 1 -> Balance");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" 2 -> Cash");
                    Console.WriteLine(" 3 -> EXIT");
                }
                else if (select == 2)
                {
                    Console.WriteLine(" 1 -> Balance");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" 2 -> Cash");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" 3 -> EXIT");
                }
                else if (select == 3)
                {
                    Console.WriteLine(" 1 -> Balance");
                    Console.WriteLine(" 2 -> Cash");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" 3 -> EXIT");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                ConsoleKeyInfo key  = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow)
                {
                    if (select < 3)
                    {
                        select++;
                    }
                    else
                    {
                        select = 1;
                    }
                }

                else if (key.Key == ConsoleKey.UpArrow)
                {
                    if(select >1 ) { select--; }
                    else
                    { select=3; }

                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if(select == 1)
                    {
                        Console.WriteLine("avada kadabra");
                        client1.showBalance(client1);

                    }
                    else if (select == 2)
                    {
                        client1.Cash(client1);

                    }
                    else if ( select == 3)
                    {
                        Console.WriteLine("Thank you ...");

                    }
                    break;
                    

                }
                Console.Clear();

            } while(true);





        }



    }



}


