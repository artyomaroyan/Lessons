namespace Lessons.FourDigit;

/*
 * Տրված է քառանիշ թիվ ։ Կազմել հետևյալ խնդիրների ծրագրերն ։
 * 37․ Արտածել 'YES' հաղորդագրությունը ,
 * եթե քառանիշ թիվը հավասար է իր թվանշանների գումարի քառակուսուն ,
 * հակառակ դեպքում 'NO' հաղորդագրությունը ;
 */
public class Task037 {
    public static void Main() {
        var num = Random.Shared.Next(1000, 10000);
        Console.WriteLine($"number: {num}");
        Console.WriteLine($"Result: {Solution(num)}");
    }

    private static string Solution(int number) {
        if (number is < 1000 or > 9999) {
            throw new ArgumentOutOfRangeException(nameof(number),"Number must be a four-digit integer");
        }
        
        var thousands = (number / 1000) % 10;
        var hundreds = (number / 100) % 10;
        var tens = (number / 10) % 10;
        var units = number % 10;

        var sumOfDigits = thousands + hundreds + tens + units;
        var square = sumOfDigits * sumOfDigits;
        Console.WriteLine($"square: {square}");
        
        return number == square ? "YES" : "NO";
    }
}