namespace AOCDayOne;

public class CalorieCounter
{
    public int mostCalories = 0;
    public int secondMostCalories = 0;
    public int thirdMostCalories = 0;
    public int currentCalories = 0;
    public int CountCalories()
    {
        foreach (string line in System.IO.File.ReadLines(@"./elves_inventory.txt"))
        {
            if (string.IsNullOrEmpty(line))
            {
                if (currentCalories > mostCalories)
                {
                    int temp = mostCalories;
                    mostCalories = currentCalories;
                    currentCalories = secondMostCalories;
                    secondMostCalories = temp;
                    thirdMostCalories = currentCalories;
                    currentCalories = 0;
                    continue;
                    
                } else if (currentCalories > secondMostCalories)
                {
                    int temp = secondMostCalories;
                    secondMostCalories = currentCalories;
                    thirdMostCalories = temp;
                    currentCalories = 0;
                    continue;
                    
                } else if (currentCalories > thirdMostCalories)
                {
                    thirdMostCalories = currentCalories;
                    currentCalories = 0;
                    continue;
                }
                else
                {
                    currentCalories = 0;
                    continue;
                }
            }

            int calories = Int32.Parse(line);
            currentCalories += calories;
        }
        return mostCalories + secondMostCalories + thirdMostCalories;
    }
}