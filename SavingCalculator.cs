using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework;

namespace EntityFramework
{
    public static class SavingCalculator 
    {
        public static int CalculNouveauSolde(this int solde, int taux)
        {
            solde += solde * taux / 100;
            return solde;
        }
    }
}
