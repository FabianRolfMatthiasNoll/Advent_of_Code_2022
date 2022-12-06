namespace AOCDay3;

public class BackpackChecker
{
    public int SumOfDoubleItems()
    {
        var itemSum = 0;
        var itemFound = false;
        foreach (string line in System.IO.File.ReadLines(@"./backpack_inventory.txt"))
        {
            var compartmentOne = line.Substring(0, (int)(line.Length / 2));
            var compartmentTwo = line.Substring((int)(line.Length / 2), (int)(line.Length / 2));
            var itemsOfCompOne = compartmentOne.ToCharArray();
            var itemsOfCompTwo = compartmentTwo.ToCharArray();

            foreach (var item in itemsOfCompOne)
            {
                foreach (var itemTwo in itemsOfCompTwo)
                {
                    if (item == itemTwo)
                    {
                        if (char.IsUpper(item))
                        {
                            itemSum += ((int)item % 32) + 26;
                            itemFound = true;
                        }
                        else
                        {
                            itemSum += (int)item % 32;
                            itemFound = true;
                        }
                        break;
                    }

                    if (itemFound) break;
                }

                if (itemFound) break;
            }

            itemFound = false;
        }
        return itemSum;
    }
}