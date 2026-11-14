namespace Lessons.FourDigit;

/*
 * Տրված է քառանիշ թիվ ։ Կազմել հետևյալ խնդիրների ծրագրերն ։
 * 38․ Հաշվել և արտածել քառանիշ թվի միավորների և հարյուրավորների թվանշանների արտադրյալի արժեքը ,
 * եթե միավորների թվանշանը մեծ է տասնավորների թվանշանից ,
 * հակառակ դեպքում արտածել 1;
 */
public class Task038 {
    public static void Main() {
        var num = Random.Shared.Next(1000, 10000);
        Console.WriteLine($"number: {num}");
        Console.WriteLine($"Result: {Solution(num)}");
    }

    private static int Solution(int number) {
        if (number is < 1000 or > 9999) {
            throw new ArgumentOutOfRangeException(nameof(number),"Number must be a four-digit integer");
        }
        
        var thousands = (number / 1000) % 10;
        var hundreds = (number / 100) % 10;
        var tens = (number / 10) % 10;
        var units = number % 10;

        if (units < tens) return 1;
        return units * hundreds;
    }
}