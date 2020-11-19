/* Maleah Ristau AdventureGame Intro to Programing November 10th 2020 */

using System;
using System.Text;
using static System.Console;

namespace AdventureGame
{
  class MainClass 
  {
    public static void Main (string[] args) 
    {
      Game Adventure = new Game();
      Adventure.Start();
    }
  }
}