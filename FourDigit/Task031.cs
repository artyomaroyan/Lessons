namespace Lessons.FourDigit;

/*
 * Տրված է քառանիշ թիվ ։ Կազմել հետևյալ խնդիրների ծրագրերն ։
 * 31․ t տրամաբանական փոփոխականին վերագրել true արժեքը ,
 * եթե թվի միավորների և տասնավորների թվանշանների գումարը հավասար է հարյուրավորների և հազարավորների թվանշանների գումարին ,
 * հակառակ դեպքում` false: Արտածել t փոփոխականի արժեքը;
 */
public class Task031 {
    public static void Main() {
        var num = Random.Shared.Next(1000, 10000);
        Console.WriteLine($"number: {num}");
        Console.WriteLine($"Result: {Solution(num)}");
    }

    private static bool Solution(int number) {
        if (number is < 1000 or > 9999) {
            throw new ArgumentOutOfRangeException(nameof(number),"Number must be a four-digit integer");
        }
        
        var thousands = (number / 1000) % 10;
        var hundreds = (number / 100) % 10;
        var tens = (number / 10) % 10;
        var units = number % 10;
        
        return units + tens == hundreds + thousands;
    }
}