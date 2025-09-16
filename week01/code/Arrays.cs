public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //use a List 
        List<double> result = new List<double>();



        //use For loop , until meet length

        for (int i = 1; i <= length; i++)
        {
            //add mutiple of number in the result List
            result.Add(i * number);
        }

        //convert List result to array resultO
        double[] resultO = result.ToArray();

        return resultO; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.



        //fix the right amount value
        amount = amount % data.Count;

        // item to start = total - amount
        int startIndexData = data.Count - amount;

        //add the last numbers from "data" list which start startIndexData
        List<int> newData = data.GetRange(startIndexData, amount);


        //add the rest of data list numbers to newData List
        newData.AddRange(data.GetRange(0, startIndexData));

        //update data numbers by newData value
        data.Clear();
        data.AddRange(newData);


    }

   
}

