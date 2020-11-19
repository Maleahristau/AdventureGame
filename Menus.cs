using System;
using System.Text;
using static System.Console;

namespace AdventureGame
{
  class Menu
  {
    private int Selected;
    private string[] Options;
    private string Prompt;

    public Menu(string prompt, string[] options)
    {
      Prompt = prompt;
      Options = options;
      Selected = 0;
    }


    private void DisplayOptions()
    {
      WriteLine(Prompt);
      for (int i = 0; i < Options.Length; i++)
      {
        string currentOption = Options[i];
        string prefix;
        if (i == Selected)
        {
          prefix = ">>";
          ForegroundColor = ConsoleColor.Black;
          BackgroundColor = ConsoleColor.White;
        }
        else
        {
          prefix = "  ";
          ForegroundColor = ConsoleColor.White;
          BackgroundColor = ConsoleColor.Black;
        }
        WriteLine($"{prefix} << {currentOption} >>");
      }
      ResetColor();
    }

    public int Run()
    {
      ConsoleKey keyPressed;
      do
      {
        Clear();
        DisplayOptions();
        
        ConsoleKeyInfo keyInfo = ReadKey(true);
        keyPressed = keyInfo.Key;

        if(keyPressed == ConsoleKey.UpArrow)
        {
          Selected--;
          if (Selected == -1)
          {
            Selected = Options.Length - 1;
          }
        }else if (keyPressed == ConsoleKey.DownArrow)
        {
          Selected++;
          if (Selected == Options.Length)
          {
            Selected = 0;
          }
        }

      } while (keyPressed != ConsoleKey.Enter);
      

      return Selected;
    }





  }

}