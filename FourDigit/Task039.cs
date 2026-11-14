namespace Lessons.FourDigit;

/*
 * Տրված է քառանիշ թիվ ։ Կազմել հետևյալ խնդիրների ծրագրերն ։
 * 39. y փոփոխականին վերագրել 1 արժեքը,
 * եթե քառանիշ թվի թվանշանների գումարը մեծ է 20-ից , հակառակ դեպքում՝ 0 արժեքը ։
 * Արտածել y փոփոխականի արժեքը ;
 */
public class Task039 {
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
        var sumOfDigits = thousands + hundreds + tens + units;
        return sumOfDigits > 20 ? 1 : 0;
    }
}