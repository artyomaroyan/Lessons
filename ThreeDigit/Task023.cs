namespace Lessons.ThreeDigit;

/*
 * Տրված է եռանիշ թիվ ։ Կազմել հետևյալ խնդիրների ծրագրերն ։
 * 23․ Հաշվել և արտածել եռանիշ թվի և իր թվանշանների գումարի հարաբերության արժեքը , եթե եռանիշ թիվը մեծ է k թվից ,
 * հակառակ դեպքում՝ եռանիշ թվի և միավորների թվանշանի հարաբերության արժեքը։
 */
public class Task023 {
    private static readonly int K = Random.Shared.Next(100, 1000);
    public static void Main() {
        Console.WriteLine($"K - {K}");
        Console.WriteLine("Enter three digit number");
        var num = Convert.ToInt32(Console.ReadLine());
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

        if (number > K) {
            var sumOfDigits = hundreds + tens + units;
            return (double)number / sumOfDigits;
        }
        if (units == 0) {
            throw new DivideByZeroException("Units digit is 0, division is unacceptable.");
        }
        return (double)number / units;
    }
}