namespace AOCDay3;

public class BadgeFinder
{
    public int FindBadgeSum()
    {
        var count = 1;
        var itemSum = 0;
        var itemFound = false;
        char[] backpackOne = {};
        char[] backpackTwo = {};
        char[] backpackThree = {};
        
        foreach (string line in System.IO.File.ReadLines(@"./backpack_inventory.txt"))
        {
            if (count == 1)
            {
                backpackOne = line.ToCharArray();
                count++;
            } else if (count == 2)
            {
                backpackTwo = line.ToCharArray();
                count++;
            } else if (count == 3)
            {
                backpackThree = line.ToCharArray();
                foreach (var itemOne in backpackOne)
                {
                    foreach (var itemTwo in backpackTwo)
                    {
                        foreach (var itemThree in backpackThree)
                        {
                            if (itemOne == itemTwo && itemTwo == itemThree)
                            {
                                if (char.IsUpper(itemOne))
                                {
                                    itemSum += ((int)itemOne % 32) + 26;
                                    itemFound = true;
                                    count = 1;
                                }
                                else
                                {
                                    itemSum += (int)itemOne % 32;
                                    itemFound = true;
                                    count = 1;
                                }
                                break;
                            }
                        }
                        if (itemFound) break;
                    }
                    if (itemFound) break;
                }
                itemFound = false;
            }

        }
        return itemSum;
    }
}