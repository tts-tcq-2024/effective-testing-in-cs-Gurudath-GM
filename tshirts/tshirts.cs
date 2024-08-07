using System;

namespace TshirtSpace {
    class Tshirt {
        public static string Size(int cms) {
            if(cms < 38) {
                return "S";
            } else if(cms > 38 && cms < 42) {
                return "M";
            } else {
                return "L";
            }
        }
        static void Main(string[] args) {
            // Test cases to verify the Size method
            TestTshirtSize.Size_ShouldReturn_Exception_ForNegativeMeasurements(-1, "Measurement cannot be negative.");
            TestTshirtSize.Size_ShouldReturn_Small_ForMeasurementsLessThanOrEqualTo38(37, "S");
            TestTshirtSize.Size_ShouldReturn_Small_ForMeasurementsLessThanOrEqualTo38(38, "S");
            TestTshirtSize.Size_ShouldReturn_Medium_ForMeasurementsBetween38And42(39, "M");
            TestTshirtSize.Size_ShouldReturn_Medium_ForMeasurementsBetween38And42(41, "M");
            TestTshirtSize.Size_ShouldReturn_Large_ForMeasurements42AndAbove(42, "L");
            TestTshirtSize.Size_ShouldReturn_Large_ForMeasurements42AndAbove(43, "L");
        }
    }
}
