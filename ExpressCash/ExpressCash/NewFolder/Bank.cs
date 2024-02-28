using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCash.NewFolder
{
    internal class Bank
    {
        public string Name { get; set; } 
        public List <Client> clients { get; set; } 



        public Bank (string name)
        {
            Name = name;
            clients = new();
        }
        
        public void AddClient (string name , string sunrame , int age  , decimal balance , decimal salary , int cardYears )
        {



            clients.Add(new Client(name, sunrame, age, balance, salary, cardYears));


        }



    }
}
