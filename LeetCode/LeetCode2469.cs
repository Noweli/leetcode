namespace LeetCode;

public static class LeetCode2469
{
    public static double[] ConvertTemperature(double celsius)
    {
        return [CelsiusToKelvin(celsius), CelsiusToFahrenheit(celsius)];
    }

    private static double CelsiusToFahrenheit(double celsius) => celsius * 1.8d + 32d;
    private static double CelsiusToKelvin(double celsius) => celsius + 273.15d;
}