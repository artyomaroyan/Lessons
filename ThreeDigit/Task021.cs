namespace Lessons.ThreeDigit;

/*
 * Տրված է եռանիշ թիվ ։ Կազմել հետևյալ խնդիրների ծրագրերն ։
 * 21․ t տրամաբանական տիպի փոփոխականին վերագրել true արժեք , եթե եռանիշ թվի միավորների թվանշանը հավասար է
 * տասնավորների և հարյուրավորների թվանշանների գումարին , հակառակ դեպքում false: Արտածել t փոփոխականի արժեքը։
 */
public class Task021 {
    public static void Main() {
        Console.WriteLine("Enter three digit number");
        var num = Convert.ToInt32(Console.ReadLine());
        if (num is <= 99 or > 999) {
            Console.Error.WriteLine("Number is not a three digit. Please enter three digit number between 100 & 999");
            return;
        }

        Console.WriteLine($"Result: {Solution(num)}");
    }

    private static bool Solution(int number) {
        var hundreds = number / 100;
        var tens = (number / 10) % 10;
        var units = number % 10;

        return units == tens + hundreds;
    }
}