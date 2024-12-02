// See https://aka.ms/new-console-template for more information
//Lag en metode som tar imot to tall og returnerer summen av tallene dersom de er ulike,
//og returnerer tallene multiplisert med hverandre dersom de er like

using System.Diagnostics.CodeAnalysis;

int firstNum = 3;
int secondNum = 9;
int numberSum = 0;
bool sumEqual = true;
EqualOrNot();
Run(); 

int EqualOrNot() { 

    Console.WriteLine("Insert the first number");
    firstNum = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insert the second number");
    secondNum = Convert.ToInt32(Console.ReadLine());
    numberSum = firstNum + secondNum;
    Console.WriteLine($"The sum is {numberSum}");
    return numberSum;
}

    void Run() {
    if (firstNum == secondNum)
        
    {
        sumEqual = true;
        Console.Write("The numbers are equal");
       
    }  
    else if (firstNum != secondNum)
    {
        sumEqual = false;
        Console.Write("The numbers are not equal");
    }   
}   
 

 






