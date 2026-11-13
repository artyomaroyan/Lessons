namespace Lessons.ThreeDigit;

/*
 * Տրված է եռանիշ թիվ ։ Կազմել հետևյալ խնդիրների ծրագրերն ։
 * 24․ Հաշվել և արտածել եռանիշ թվի թվանշաններից մեծագույնի արժեքը ;
 */
public class Task024 {
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

        int max;

        if (hundreds > tens && hundreds > units) {
            max = hundreds;
        } else if (tens > hundreds && tens > units) {
            max = tens;
        } else {
            max = units;
        }
        return max;
    }
}