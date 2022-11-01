double [] myArray = { -4,-5,-3};
double number1;
double number2;
double maxNumber= myArray[0];  
for(int i = 0; i < myArray.Length-1; i++) 
{
   // 0 1 2 3 4 
    number1 = myArray[i];
    number2 = myArray[i+1];
    if ((number1 > number2) && (number1 >= maxNumber))
    {
        maxNumber = number1;
    }
    else if ((number1 < number2) && (number2 >= maxNumber))
    {
        maxNumber = number2;
    }
    

    }
Console.WriteLine("max number :" + maxNumber);


