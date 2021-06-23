using System;

namespace ConsoleApp // Project name
{

class Program
{

public static void Main(string[] args)
{
int SIZE = 20;
char[] answers = { 'B', 'D', 'A', 'A', 'C', 'A', 'B', 'A', 'C', 'D', 'B', 'C', 'D', 'A', 'D', 'C', 'C', 'B', 'D', 'A' };
char[] userInput = new char[SIZE];
int numberOfCorrect = 0, numberOfWrong = 0;
for (int i = 0; i < SIZE; i++)
{
Console.Write("Enter Question {0} answer : ", i + 1);
// read user input
userInput[i] = char.Parse(Console.ReadLine());
// check the answer
if (answers[i] != userInput[i])
numberOfWrong++;
else
numberOfCorrect++;
}
// check if user pass or fail
if (numberOfCorrect >= 15)
Console.WriteLine("\nYou have passed");
else
Console.WriteLine("\nYou have failed");
Console.WriteLine("\nTotal number of correct answers : {0}", numberOfCorrect);
Console.WriteLine("Total number of wrong answers : {0}", numberOfWrong);
Console.WriteLine("\n\nQuestions which you have inputed worng : ");

// output worng answer entered
for (int i = 0; i < SIZE; i++)
{
if (answers[i] != userInput[i])
Console.WriteLine("Question {0}", (i + 1));
}
Console.ReadKey();
}
}
}