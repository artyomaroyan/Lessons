namespace Lessons.ThreeDigit;

/*
 * Տրված է եռանիշ թիվ ։ Կազմել հետևյալ խնդիրների ծրագրերն ։
 * 26․ Հաշվել և արտածել եռանիշ թվի և իր թվանշանների գումարի հարաբերության արժեքը ,
 * եթե միավորների թվանշանը մեծ է տասնավորների թվանշանից , հակառակ դեպքում արտածել եռանիշ թիվը ;
 */
public class Task026 {
    public static void Main() {
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

        if (units <= tens) return number;
        var sumOfDigits = hundreds + tens + units;
        return (double)number / sumOfDigits;
    }
}