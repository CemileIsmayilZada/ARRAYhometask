double [] myArray= { 6,7,10};
int PositiveAmount = 0;
int NegativeAmount = 0;
if (myArray.Length > 0)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] >= 0)
        {
            
            PositiveAmount++;


        }
        else
        {
           
            NegativeAmount++;
        }
    }
    Console.WriteLine("Positive numbers' amount : " + PositiveAmount);
    Console.WriteLine("Neqative numbers' amount : " + NegativeAmount);
}
else
{
    Console.WriteLine("Enter number to array ,then check again! ");
}
