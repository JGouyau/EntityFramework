using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class SavingAccount
    {
        public int ID { get; set; }
        public int Solde { get; set; }
        public int Taux { get; set; }

        public virtual Person Person { get; set; }

        public SavingAccount() { }

        public SavingAccount(int DepotInitial, int TauxEnPourcent, Person person)
        {
            this.Solde = DepotInitial;
            this.Taux = TauxEnPourcent;
            this.Person = person;
        }

    }
}

//Une classe SavingAccount représente un compte épargne