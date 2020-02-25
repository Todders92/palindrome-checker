using System;
using System.Collections.Generic;

public class Palindrome
{
  public string Word;
  
  public Palindrome(string word)
  {
    Word = word;
  }
  // public bool IsPalendrome(string phrase)
  // {

  // }
}

public class Program
{
  public static void Main()
  {
    Console.WriteLine("input a word to find out if it is a palindrome");
    string words = Console.ReadLine();
    Palindrome phrase = new Palindrome(words);
    char[] check = words.ToCharArray();
    Array.Reverse(check);
    string wordCheck = new string(check);
    if (wordCheck == words)
    {
      Console.WriteLine("yes");
    }
    else
    {
      Console.WriteLine("no");
    }
    

  }
}
