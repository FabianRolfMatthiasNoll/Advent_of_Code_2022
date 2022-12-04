namespace AOCDayTwo;
/*
 * A = X = Rock (1)
 * B = Y = Paper (2)
 * C = Z = Scissor (3)
 * Loss = 0 // Draw = 3 // Win = 6
 * Possibilitys:
 * A - X = 3 + 1 = 4
 * A - Y = 6 + 2 = 8
 * A - Z = 0 + 3 = 3
 * B - X = 0 + 1 = 1
 * B - Y = 3 + 2 = 5
 * B - Z = 6 + 3 = 9
 * C - X = 6 + 1 = 7
 * C - Y = 0 + 2 = 2
 * C - Z = 3 + 3 = 6
 */
public class ScoreCalculator
{
    public int CalculateScore()
    {
        var score = 0;
        foreach (string line in System.IO.File.ReadLines(@"./strategy_guide.txt"))
        {
            var moves = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (moves[0] == "A" && moves[1] == "X") score += 4;
            if (moves[0] == "A" && moves[1] == "Y") score += 8;
            if (moves[0] == "A" && moves[1] == "Z") score += 3;
            
            if (moves[0] == "B" && moves[1] == "X") score += 1;
            if (moves[0] == "B" && moves[1] == "Y") score += 5;
            if (moves[0] == "B" && moves[1] == "Z") score += 9;
            
            if (moves[0] == "C" && moves[1] == "X") score += 7;
            if (moves[0] == "C" && moves[1] == "Y") score += 2;
            if (moves[0] == "C" && moves[1] == "Z") score += 6;
        }
        return score;
    }
}