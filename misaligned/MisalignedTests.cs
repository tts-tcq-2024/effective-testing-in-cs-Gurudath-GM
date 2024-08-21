using MisalignedSpace;
using System.Diagnostics;

namespace MisalignedSpace
{
    public class MisalignedTests
    {
        public static void TestPrintColorMapAndReturnsPairsCount()
        {
            bool isColorCombinationOkay, isPairCountOkay;
            string expectedColorCombination;

            int result = Misaligned.PrintColorMap();
            expectedColorCombination = GenerateExpectedOutput();

            isColorCombinationOkay = Debug.Equals(Misaligned.actualColorCombination, expectedColorCombination);
            isPairCountOkay = Debug.Equals(25, result);

            if (!isColorCombinationOkay || !isPairCountOkay)
                Console.WriteLine("Test failed, because either combination of color or pair count is failed.");
            else
                Console.WriteLine("Test passed.");
        }

        private static string GenerateExpectedOutput()
        {
            string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
            string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
            string output = "";

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    output += $"{i * 5 + j} | {majorColors[i]} | {minorColors[j]}\r\n";
            }
            return output;
        }
    }
}
