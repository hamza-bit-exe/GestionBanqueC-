using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compte 1: ");
            string cin, nom, prenom, tel;
            Console.Write("Donner Le CIN: ");
            cin = Console.ReadLine();
            Console.Write("Donner Le Nom: ");
            nom = Console.ReadLine();
            Console.Write("Donner Le Prénom: ");
            prenom = Console.ReadLine();
            Console.Write("Donner Le numéro de télephone: ");
            tel = Console.ReadLine();
            Client Cl = new Client(cin, nom, prenom, tel);
            Mad s = new Mad(1569.12);
            Compte C1 = new Compte(Cl,s);
            Console.WriteLine("Détails du compte: ");
            C1.afficher();

            double mnt;
            Console.WriteLine("Donner le montant à déposer: ");
            mnt = double.Parse(Console.ReadLine());
            Mad S = new Mad(mnt);
            C1.crediter(S);
            C1.afficher();

            Console.Out.Write("Donner le montant à retirer: ");
            mnt = double.Parse(Console.In.ReadLine());
            Mad p = new Mad(mnt);
            C1.debiter(p);
            C1.afficher();

            Console.WriteLine("Compte 2: ");
            //string cin, nom, prenom, tel;
            Console.Write("Donner Le CIN: ");
            cin = Console.ReadLine();
            Console.Write("Donner Le Nom: ");
            nom = Console.ReadLine();
            Console.Write("Donner Le Prénom: ");
            prenom = Console.ReadLine();
            Console.Write("Donner Le numéro de télephone: ");
            tel = Console.ReadLine();

            Client Cl1 = new Client(cin, nom, prenom, tel);
            Mad s1 = new Mad(1569.12);
            Compte C2 = new Compte(Cl1, s1);
           
            Console.WriteLine("Détails du compte: ");
            C2.afficher();



            Console.ReadKey();
        }
    }
}
