using System;
using System.Diagnostics;

namespace TshirtSpace {
    class TestTshirtSize
    {
        private static bool isPassed = false;
        public static void Size_ShouldReturn_Small_ForMeasurementsLessThanOrEqualTo38(int cms, string expected)
        {
            string actual = Tshirt.Size(cms);
            isPassed = Debug.Equals(expected, actual);
            CheckTest_status(isPassed);
        }

        public static void Size_ShouldReturn_Medium_ForMeasurementsBetween38And42(int cms, string expected)
        {
            string actual = Tshirt.Size(cms);
            isPassed = Debug.Equals(expected, actual);
            CheckTest_status(isPassed);
        }

        public static void Size_ShouldReturn_Large_ForMeasurements42AndAbove(int cms, string expected)
        {
            string actual = Tshirt.Size(cms);
            isPassed = Debug.Equals(expected, actual);
            CheckTest_status(isPassed);
        }

        public static void Size_ShouldReturn_Exception_ForNegativeMeasurements(int cms, string expected)
        {
            string actual = Tshirt.Size(cms);
            isPassed = Debug.Equals(actual, expected);
            CheckTest_status(isPassed);
        }

        private static void CheckTest_status(bool isPassed)
        {
            if (isPassed)
                Console.WriteLine("Test passed");
            else
                throw new Exception("Test failed");
        }
    }
}
