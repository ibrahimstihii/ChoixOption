using System;

namespace ChoixOption
{
     class Etudiant
    {
        string nome , prenom ;
        int moyen ;
        string Choix1 ,Choix2,Choix3;
        bool Acceptable =false;
        public Etudiant(string c_nome ,string c_prenom ,int c_moyen , string c_Choix1 ,string c_Choix2,string c_Choix3)
        {
            nome = c_nome;
            prenom = c_prenom;
            moyen = c_moyen;
            Choix1 = c_Choix1;
            Choix2 = c_Choix2;
            Choix3 = c_Choix3;   
        }
        string getChoix1()
         {
             return Choix1;
         }
         string getChoix2()
         {
             return Choix2;
         }
         string getChoix3()
         {
             return Choix3;
         }
         void setAcceptable(bool b)
          {
              Acceptable = b;
          }
    }
    abstract class Option
    {
        string OptionNam;
        Etudiant[] Candidat = new Etudiant[60];
        Etudiant[] CandidatAccepte = new Etudiant[20];
        Option (Etudiant[] C_Candidat = new Etudiant[60]);//affecte un tableau trie
        void setCandidatAccepte(); 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
