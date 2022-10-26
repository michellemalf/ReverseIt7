//Michelle Malfabon
//Aug 16 2022

//--------Mini 7----REVERSE IT-------///

//Description: Takes a sequence of numbers and reverses them. 
//Declared variables, get user input and use while loop to reverse the number.  

// Mauricio review, good job!

void PlayGame()
{
int number;
int remainder;
int reverseNum = 0;
int playAgain;

//print question and store in variable (number)
Console.WriteLine("Enter a number to reverse: ");
number = Convert.ToInt32(Console.ReadLine());

//display user input again
Console.WriteLine("The number is: " + number);

//define function
void ReverseNum()
{ 
    while (number > 0)
    {
        remainder = number % 10;//123 divided by 10 = 12.3; whole number is 12, R=3.
        number= number / 10; //123/10=12
        reverseNum= (reverseNum * 10) + remainder;
    }
    Console.WriteLine("The reverse is: " + reverseNum);
}
//calling function
ReverseNum();

Console.WriteLine("Enter 0 to play again.");
playAgain= Convert.ToInt32(Console.ReadLine());
if (playAgain == 0)
{
    PlayGame();
}
else{
    Console.WriteLine("Goodbye.");
}
}
PlayGame();

