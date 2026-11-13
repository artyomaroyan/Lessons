namespace Lessons.ThreeDigit;

/*
 * Տրված է եռանիշ թիվ ։ Կազմել հետևյալ խնդիրների ծրագրերն ։
 * 25․ Հաշվել և արտածել եռանիշ թվի թվանշաններից փոքրագույնի արժեքը ;
 */
public class Task025 {
    public static void Main() {
        Console.WriteLine("Enter three digit number");
        var num = Convert.ToInt32(Console.ReadLine());
        if (num is <= 99 or > 999) {
            Console.Error.WriteLine("Number is not a three digit. Please enter three digit number between 100 & 999");
            return;
        }

        Console.WriteLine($"Result: {Solution(num)}");
    }

    private static int Solution(int number) {
        var hundreds = number / 100;
        var tens = (number / 10) % 10;
        var units = number % 10;

        int min;

        if (hundreds < tens && hundreds < units) {
            min = hundreds;
        } else if (tens < hundreds && tens < units) {
            min = tens;
        } else {
            min = units;
        }
        return min;
    }
}