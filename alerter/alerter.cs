using System.Diagnostics;

namespace AlerterSpace
{
    class Alerter
    {
            private static int alertFailureCount = 0;

            private static void AlertInCelsius(INetworkAlert alertSystem, float fahrenheit)
            {
                float celsius = (fahrenheit - 32) * 5 / 9;
                int returnCode = alertSystem.SendAlert(celsius);
                if (returnCode != 200)
                {
                    alertFailureCount += 1;
                }
            }

            public static void Main()
            {
                INetworkAlert stubAlert = new NetworkAlertStub();

                alertFailureCount = 0;
                AlertInCelsius(stubAlert, 400.5f);
                Debug.Assert(alertFailureCount == 1, "Test failed, expected failure count = 1");
                AlertInCelsius(stubAlert, 303.6f);
                Debug.Assert(alertFailureCount == 2, "Test failed, expected failure count = 2");
                Console.WriteLine($"{alertFailureCount} alerts failed.");
                Console.WriteLine("All is well (maybe!)");
            }
    }
}
