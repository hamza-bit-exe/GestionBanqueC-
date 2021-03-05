using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque_C_sharp
{
    class Client
    {
        private string cin;
        private string nom;
        private string prenom;
        private string adrs;

        public Client(string c, string n, string p, string a)
        {
            this.cin = c;
            this.nom = n;
            this.prenom = p;
            this.adrs = a;
        }

        public void affichage()
        {
            Console.WriteLine("La CIN N° :" + cin);
            Console.WriteLine("Le nom :" + nom);
            Console.WriteLine("Le prenom :" + prenom);
            Console.WriteLine("L adresse :" + adrs);
        }
    }
}
