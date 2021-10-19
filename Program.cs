using System;

namespace ChoixOption
{
    class Etudiant
    {
        string nome , prenom ;
        int moyen ;
        string Choix1 ,Choix2,Choix3;
        public Etudiant(string c_nome ,string c_prenom ,int c_moyen , string c_Choix1 ,string c_Choix2,string c_Choix3)
        {
            nome = c_nome;
            prenom = c_prenom;
            moyen = c_moyen;
            Choix1 = c_Choix1;
            Choix2 = c_Choix2;
            Choix3 = c_Choix3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
