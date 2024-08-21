namespace MisalignedSpace
{
    class Misaligned
    {
        public static string actualColorCombination = "";
        public static int PrintColorMap()
        {
            string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
            string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
            int i = 0, j = 0;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    actualColorCombination += ($"{i * 5 + j} | {majorColors[i]} | {minorColors[i]}\r\n");
                }
            }
            return i * j;
        }
        static void Main(string[] args)
        {
            MisalignedTests.TestPrintColorMapAndReturnsPairsCount();
        }
    }
}
