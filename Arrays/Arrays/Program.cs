

double[] myArr=new double[] {2,5,12,56,4};
double sum = 0;
double mean;
for (int i = 0; i < myArr.Length; i++)
{
    sum = sum + myArr[i];
    mean = sum / i;
}
Console.WriteLine("mean of array elemets "+mean );
