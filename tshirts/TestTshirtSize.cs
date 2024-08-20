using System;
using System.Diagnostics;

namespace TshirtSpace {
    class TestTshirtSize
    {
        public static void Size_ShouldReturn_Small_ForMeasurementsLessThanOrEqualTo38(int cms, string expected)
        {
            string actual = Tshirt.Size(cms);
            Debug.Equals(actual, expected);
        }

        public static void Size_ShouldReturn_Medium_ForMeasurementsBetween38And42(int cms, string expected)
        {
            string actual = Tshirt.Size(cms);
            Debug.Equals(actual, expected);
        }

        public static void Size_ShouldReturn_Large_ForMeasurements42AndAbove(int cms, string expected)
        {
            string actual = Tshirt.Size(cms);
            Debug.Equals(actual, expected);
        }

        public static void Size_ShouldReturn_Exception_ForNegativeMeasurements(int cms, string expected)
        {
            string actual = Tshirt.Size(cms);
            Debug.Equals(actual, expected);
        }
    }
}
