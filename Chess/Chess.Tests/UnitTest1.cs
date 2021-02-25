using NUnit.Framework;

namespace Chess.Tests
{
    public class Tests
    {
        [TestCase(new int[] { 0, 1 }, new int[] { 0, 2 }, ExpectedResult = true)]

        public bool IsPawnsorrect_Test(int[] start, int[] end)
        {
            return Figure.IsPawnsorrect(start, end);
        }

        [TestCase(new int[] { 4, 0 }, new int[] { 4, 1 }, ExpectedResult = true)]

        public bool IsKingCorrect_Test(int[] start, int[] end)
        {
            return Figure.IsKingCorrect(start, end);
        }

        [TestCase(new int[] { 3, 0 }, new int[] { 3, 1 }, ExpectedResult = true)]

        public bool IsQueenCorrect_Test(int[] start, int[] end)
        {
            return Figure.IsQueenCorrect(start, end);
        }
        
        [TestCase(new int[] { 1, 0 }, new int[] { 0, 2 }, ExpectedResult = true)]

        public bool IsHorseCorrect_Test(int[] start, int[] end)
        {
            return Figure.IsHorseCorrect(start, end);
        }

        [TestCase(new int[] { 2, 0 }, new int[] { 4, 2 }, ExpectedResult = true)]

        public bool IsBishopCorrect_Test(int[] start, int[] end)
        {
            return Figure.IsBishopCorrect(start, end);
        }

        [TestCase(new int[] { 0, 0 }, new int[] { 0, 2 }, ExpectedResult = true)]

        public bool IsRookCorrect_Test(int[] start, int[] end)
        {
            return Figure.IsRookCorrect(start, end);
        }
    }
}