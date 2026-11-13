namespace Lessons.FourDigit;

/*
 * Տրված է քառանիշ թիվ ։ Կազմել հետևյալ խնդիրների ծրագրերն ։
 * 32․ Հաշվել և արտածել քառանիշ թվի հարաբերության արժեքը միավորների և հարյուրավորների թվանշանների գումարին ,
 * եթե քառանիշ թիվը փոքր է 5000-ից , հակառակ դեպքում ՝ քառանիշ թվի հաաբերության արժեքը հազարավորների ու տասնավորների
 * թվանշանների գումարին։ Ենթադրվում է որ քառանիշ թվի միավորների և հարյուրավորների թվանշանների գումարը հավասար չէ զրոյի ;
 */
public class Task032 {
    private const int Threshold = 5000;
    public static void Main() {
        var num = Random.Shared.Next(1000, 10000);
        Console.WriteLine($"number: {num}");
        Console.WriteLine($"Result: {Solution(num)}");
    }

    private static double Solution(int number) {
        if (number is < 1000 or > 9999) {
            throw new ArgumentOutOfRangeException(nameof(number), "Number must be a four-digit integer");
        }

        var thousands = (number / 1000) % 10;
        var hundreds = (number / 100) % 10;
        var tens = (number / 10) % 10;
        var units = number % 10;

        if (number < Threshold) {
            var sumOfUh = units + hundreds;

            if (sumOfUh == 0) {
                throw new DivideByZeroException("Sum of units and hundreds digits cannot be zero.");
            }
            return (double)number / sumOfUh;
        }
        var sumOfTt = thousands + tens;
        return (double)number / sumOfTt;
    }
}