using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque_C_sharp
{
    class Compte
    {
        private int numero;
        private Mad solde;
        private Client prop;
        private static int cmpt = 0;
        public Compte(Client p,Mad s)
        {
            cmpt++;
            this.numero = cmpt;
            this.prop = p;
            this.solde = s;
        }
        public void crediter(Mad sum)
        {
            Mad s = new Mad(0);
            if(sum.Comparer(s)<=0)
            {
                solde.somme(sum);
           
                Console.WriteLine("Opération effectuée");
            }
            else
            {
                Console.WriteLine("Solde insuffisant");
            }
            
        }
        public void debiter(Mad sum)                     
        {
            if (solde.Comparer(sum)>=0)
            {
                solde.somme(sum);
              
                Console.WriteLine("Opération effectuée");
            }
            else
                Console.WriteLine("Solde insuffisant");
        }

        public void afficher()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Numéro de Compte: " + numero);
            solde.afficheSolde();
            Console.WriteLine("Propriétaire du compte : ");
            prop.affichage();
            Console.WriteLine("*************************");
        }
        
    }
}

