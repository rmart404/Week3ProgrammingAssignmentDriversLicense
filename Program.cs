using System;

namespace DriverLicense
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
Console.Write("What is the answer for question {0}: ", i + 1);

userInput[i] = char.Parse(Console.ReadLine());

if (answers[i] != userInput[i])
numberOfWrong++;
else
numberOfCorrect++;
}

if (numberOfCorrect >= 15)
Console.WriteLine("\nCongratulations! You have passed");
else
Console.WriteLine("\nI am sorry. You have failed");
Console.WriteLine("\nNumber of correct answers : {0}", numberOfCorrect);
Console.WriteLine("\nNumber of wrong answers : {0}", numberOfWrong);
Console.WriteLine("\n\nList of questions you got wrong : ");

for (int i = 0; i < SIZE; i++)
{
if (answers[i] != userInput[i])
Console.WriteLine("Question {0}", (i + 1));
}
Console.ReadKey();
}
}
}