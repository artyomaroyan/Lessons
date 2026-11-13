namespace Lessons.ThreeDigit;

/*
 * Տրված է եռանիշ թիվ ։ Կազմել հետևյալ խնդիրների ծրագրերն ։
 * 27․ Հաշվել և արտածել եռանիշ թվի տասնավորների և միավորների թվանշանների հարաբերության արժեքը ,
 * եթե եռանիշ թիվը մեծ է 300-ից, հակառակ դեպքում հարյուրավորների և միավորների հարաբերության արժեքը։ Ենթադրվում է որ ,
 * որ եռանիշ թվի միավորների թվանշանը հավասար չէ զրոյի ;
 */
public class Task027 {
    private const int Number = 300;
    public static void Main() {
        var num = Random.Shared.Next(100, 1000);
        Console.WriteLine($"number: {num}");
        if (num is <= 99 or > 999) {
            Console.Error.WriteLine("Number is not a three digit. Please enter three digit number between 100 & 999");
            return;
        }
        Console.WriteLine($"Result: {Solution(num)}");
    }

    private static double Solution(int number) {
        var hundreds = number / 100;
        var tens = (number / 10) % 10;
        var units = number % 10;

        if (units == 0) throw new ArgumentException("units must be greater than 0");

        if (number > Number) {
            return (double)tens / units;
        }
        return (double)hundreds / units;
    }
}