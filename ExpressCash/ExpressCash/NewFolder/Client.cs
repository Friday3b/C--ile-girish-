using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///Client (class)
//id, name, surname, age, salary, BankCard bankAccount*/


namespace ExpressCash.NewFolder
{
    internal class Client
    {

        private static int _staticId = 1;
        private string sunrame;
        private decimal balance;
        private int cardYears;

        public Client(string name, string sunrame, int age, decimal balance, decimal salary, int cardYears)
        {
            Name = name;
            this.sunrame = sunrame;
            Age = age;
            this.balance = balance;
            Salary = salary;
            this.cardYears = cardYears;
        }

        public Client(string name, string surname, int age, decimal salary, string bankName, decimal balance, int cardYears , string pan , string pin)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
            Card = new Bankcard(
                pan: pan,
                pin: pin,
                balance: balance,
                fullname: $"{Name} {Surname}",
                bankname: bankName,
                expireData: cardYears);
         
        }

        public int Id { get; set; } = _staticId++;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public Bankcard Card { get; set; }

        public void showBalance(Client obj)
        {

            Console.WriteLine(obj.Card.Balance);




        }

        public void Cash (Client obj)
        {

            Console.Write("neqeder mebleg cekmek isteyirsiz , ekrana yazin : ");
            string mebleg = Console.ReadLine();

            if (int.TryParse(mebleg , out int mebleg1))
            {
                obj.Card.Balance -= mebleg1;


            }
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"negdden sonra qalan mebleg : {obj.Card.Balance}");
            Console.ForegroundColor = ConsoleColor.White;



        }



    }








}
