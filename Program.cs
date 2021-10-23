using System;
using System.Collections.Generic;
namespace ChoixOption
{
     class Etudiant
    {
        string nome;
        int moyen ;
        string Choix1 ,Choix2,Choix3;
        string choixValide ;
        public Etudiant(string c_nome ,int c_moyen , string c_Choix1 ,string c_Choix2,string c_Choix3)
        {
            nome = c_nome;
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
         void setChoixValide(string choix)
          {
              choixValide = choix;
          }
    }
     class Option
    {
        List<Etudiant> ABD = new List<Etudiant>();
        List<Etudiant> ASR = new List<Etudiant>();
        List<Etudiant> GL = new List<Etudiant>(); 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
