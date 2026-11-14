namespace Lessons.FourDigit;

/*
 * Տրված է քառանիշ թիվ ։ Կազմել հետևյալ խնդիրների ծրագրերն ։
 * 40․ y փոփոխականին վերագրել 0 արժեքը,
 * եթե քառանիշ թվի թվանշանների արտադրյալը մեծ է 200-ից, հակառակ դեպքում 1 արժեքը։
 * Արտածել y փոփոխականի արժեքը ;
 */
public class Task040 {
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
        var multiply = thousands * hundreds * tens * units;
        return multiply > 200 ? 0 : 1;
    }
}