using System;
using System.Collections.Generic;

namespace Monday
{
  class Game
  {
    public bool Playing { get; private set; }
    public Game()
    {
      Playing = true;
      Console.Clear();
      while (Playing)
      {
        GetPlayerInput();
      }
    }
    private void GetPlayerInput()
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Rock, Paper, or Scissors");
      string input = Console.ReadLine();
      Play(input);
    }
    private void Play(string input)
    {
      string action = input.Split(" ")[0].ToLower();
      switch (action)
      {
        case "rock":
          Console.Clear();
          Console.WriteLine("You played Rock");
          OpponentTurn();
          break;
        case "paper":
          Console.Clear();
          Console.WriteLine("You played Paper");
          break;
        case "scissors":
          Console.Clear();
          Console.WriteLine("You played Scissors");
          break;
      }
    }
    private void OpponentTurn()
    {
      Random rand = new Random();
      int Choice = rand.Next(1, 4);

    }
  }
}