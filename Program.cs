using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using(MyContext context = new MyContext())
            {
                Person Richard = new Person("M. Richard");

                context.People.Add(Richard);

                SavingAccount Compte1 = new SavingAccount(2000000, 5, Richard);
                SavingAccount Compte2 = new SavingAccount(250000, 15, Richard);
                SavingAccount Compte3 = new SavingAccount(10000000, 2, Richard);

                context.SavingAccounts.Add(Compte1);
                context.SavingAccounts.Add(Compte2);
                context.SavingAccounts.Add(Compte3);




                for (int i = 1; i <= 3; i++)
                {
                    foreach (SavingAccount compte in context.SavingAccounts.Distinct())
                    {
                        compte.Solde = compte.Solde.CalculNouveauSolde(compte.Taux);
                    }
                    
                }

                context.SaveChanges();

                string message = "";

                foreach (SavingAccount compte in context.SavingAccounts)
                {
                    message += $"\n  ID : {compte.ID}  | Solde : {compte.Solde}  |  Taux d'épargne : {compte.Taux}% ";
                }

                

                MessageBox.Show(message, "Solde des comptes" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
