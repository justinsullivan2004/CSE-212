namespace prove_01;

public class Lists
{
    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start (don't forget to fill out the 01-prove-response.docx)
        double[] multiples = new double[length];
        double newNumber = number;
        for (int i = 0; i < length; i++)
        {
            multiples[i] = newNumber;
            newNumber += number;
        }

        return multiples; // replace this return statement with your own
    }
    
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be 
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and 
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> numbers, int amount)
    {
        List<int> secondPart = numbers.GetRange(numbers.Count - amount, amount);
        List<int> firstPart = numbers.GetRange(0,numbers.Count -amount);
        
        numbers.Clear();
        
        numbers.AddRange(secondPart);
        numbers.AddRange(firstPart);
        
        // TODO Problem 2 Start (don't forget to fill out the 01-prove-response.docx)
    }
}