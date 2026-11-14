namespace Lessons.FourDigit;

/*
 * Տրված է քառանիշ թիվ ։ Կազմել հետևյալ խնդիրների ծրագրերն ։
 * 36․ Արտածել 'YES' հաղորդագրությունը , եթե քառանիշ թվի առաջին և վերջին թվանշանի մեջ կա '4' թվանշանը ,
 * հակառակ դեպքում 'NO' հաղորդագրությունը;
 */
public class Task036 {
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
        return thousands == 4 && units == 4 ? "YES" : "NO";
    }
}