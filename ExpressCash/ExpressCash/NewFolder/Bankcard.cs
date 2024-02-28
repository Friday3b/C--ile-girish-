using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCash.NewFolder
{
    internal class Bankcard
    {

        public string Bankname;
        public string Fullname;
        public string Pan;
        public string Pin;
        public string Cvc;
        public string ExpireData;
        public decimal Balance;
        private int expireData;

        public Bankcard()
        {
        }

        public Bankcard(string pan , string pin ,decimal balance, string fullname, string bankname, int expireData)
        {
            Pan = pan;
            Pin = pin;
            Balance = balance;
            Fullname = fullname;
            Bankname = bankname;
            this.expireData = expireData;
        }

        public Bankcard(string bankname, string fullname, 
            string pan, string pin, string cvc, string expireData, decimal balance )
        {
            Bankname = bankname;
            Fullname = fullname;
            Pan = pan;
            Pin = pin;
            Cvc = cvc;
            ExpireData = expireData;
            Balance = balance;
        }





    }
}
