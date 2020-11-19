using System;
using System.Text;
using static System.Console;

namespace AdventureGame
{
  class User
 {
   public virtual void Name()
   {
     string name;
     string ask = "What is your name?";
     WriteLine(ask);
     name = ReadLine();
   }
   
 }

  class doll : User
  {
    public override void Name()
   {
     string name;
     string ask = "What should I name my Doll?";
      WriteLine(ask);
     name = ReadLine();
     WriteLine("The child smiles even brighter and nods. \""+ name + " is a wonderful name, thank you so much!\" says the child. Before long the lady and her child walk away and you are left with a small smile yourself.");
   }
  }



}