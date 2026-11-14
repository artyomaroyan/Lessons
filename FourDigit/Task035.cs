namespace Lessons.FourDigit;

/*
 * Տրված է քառանիշ թիվ ։ Կազմել հետևյալ խնդիրների ծրագրերն ։
 * 35․ Արտածել 'y=12' արտահայտությունը, եթե միավորների և տասնավորների թվանշանների արտադրյալը հավասար է 12-ի,
 * հակառակ դեպքում դեպքում 'y=0' արտահայտությունը ;
 */
public class Task035 {
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
        var multiply = units * tens;
        return multiply == 12 ? "y=12" : "y=0";
    }
}