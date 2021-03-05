using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque_C_sharp
{
    class Mad
    {
        private double val;
        public Mad(double v)
        {
            this.val = v;
        }
        public int Comparer(Mad s)
        {
           if(this.val > s.val)
            {
                return 1;
            }
           else if(this.val < s.val)
            {
                return -1;
            }
           else
            {
                return 0;
            }
        }

        public Mad somme(Mad s)
        {
            Mad r = new Mad(0);
            r.val = this.val + s.val;
            return r;
        }

        public void afficheSolde()
        {
            Console.WriteLine("Solde de compte: " + this.val); 
        }

    }
}
