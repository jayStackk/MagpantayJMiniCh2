// John Magpantay 
// 10-20-22 

// Adding two numbers but a different method than last time
// Peer Review {} notes :PreReview by mauricio Acosta everything works great 
//play again function works and code looks nice data.


// int n1;
//nt n2;
int numOne = 0;
int numTwo = 0;
string stop = "";
int roundUp = 0;
bool validNum = true;
bool validNum2 = true;


string playAgain = "yes";
while( stop != "no"){


Console.Clear();
// var stringNumber = "123";
// int firstNum;
// bool isNumber = int.TryParse(stringNumber, out firstNum);

//isNumber is true and numericValue=123
Console.WriteLine("We are going to add any two numbers together");
Console.WriteLine("Enter your first number");
Console.WriteLine("|-----------------------|");
Console.WriteLine("|-----------------------|");
string firstNum = Console.ReadLine();
validNum = Int32.TryParse(firstNum, out numOne);

Console.WriteLine("Enter your second number");

Console.WriteLine("|-----------------------|");


string secondNum = Console.ReadLine();
validNum2 = Int32.TryParse(secondNum, out numTwo);
//int num1;
//int num2;
//num1 = Convert.ToInt32(firstNum);
//num2 = Convert.ToInt32(secondNum);

Console.WriteLine("|-----------------------|");
// Console.WriteLine("Your sum is:");
// Console.WriteLine(numOne + numTwo);

//Console.WriteLine("Would you like to do it again?");
//playAgain = Console.ReadLine();
if (validNum == true && validNum2 == true)
{
    roundUp = numOne + numTwo;
    Console.WriteLine("The sum of the #'s are!: " + (numOne + numTwo));

}
else
{
    Console.WriteLine("INVALID, I said numbers not letters");
}

Console.WriteLine("Press Enter to play again other wise type no");
stop = Console.ReadLine();



}



