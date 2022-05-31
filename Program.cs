// Function
// always return a type beside function name
// void if nothing to return

//Find Max number

int[] integerArray = new int[] { 1, 2, 3, 2, 4, 1, 3 };
int maxNumber = GetLargestInteger(integerArray); // using the function with parameter as argument
Console.WriteLine(maxNumber);

maxNumber = GetLargestInteger(new int[] { 1, 2, 3 }); // other way to use function with new parameter(array)

int GetLargestInteger(int[] myArray) // Parameter of a function can be name any. Also can have many parameters as comma , int myString
{
    int maxNumber = Int32.MinValue;

    for (int i = 0; i < myArray.Length; i++)
    {
        // is the current number greater than the greatest number that we've found so far?
        if (myArray[i] > maxNumber)
        {
            maxNumber = myArray[i];
        }
    }

    return maxNumber;
}


//Frequency of user input in an array
// void if just console writing

int input = Int32.Parse(Console.ReadLine());
Console.WriteLine(GetIntegerFrequency(integerArray, input));

int GetIntegerFrequency(int[] intArray, int searchValue)
{
    int counter = 0;

    for (int i = 0; i < intArray.Length; i++)
    {
        if (intArray[i] == searchValue)
        {
            counter++;
        }
    }
    return counter;
}