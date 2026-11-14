namespace Lessons.FourDigit;

/*
 * Տրված է քառանիշ թիվ ։ Կազմել հետևյալ խնդիրների ծրագրերն ։
 * 34․ Սիմվոլային y փոփոխականին վերագրել 's' արժեքը ,
 * եթե քառանիշ թվի միավորների և տասնավորների թվանշանների գումարը հավասար է 5-ի, հակառակ դեպքում 'd' արժեքը;
 * Արտածել y-ի արժեքը;
 */
public class Task034 {
    public static void Main() {
        var num = Random.Shared.Next(1000, 10000);
        Console.WriteLine($"number: {num}");
        Console.WriteLine($"Result: {Solution(num)}");
    }

    private static char Solution(int number) {
        if (number is < 1000 or > 9999) {
            throw new ArgumentOutOfRangeException(nameof(number),"Number must be a four-digit integer");
        }
        
        var thousands = (number / 1000) % 10;
        var hundreds = (number / 100) % 10;
        var tens = (number / 10) % 10;
        var units = number % 10;
        var sumOfUt = units + tens;
        return sumOfUt == 5 ? 's' : 'd';
    }
}