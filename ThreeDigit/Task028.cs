namespace Lessons.ThreeDigit;

/*
 * Տրված է եռանիշ թիվ ։ Կազմել հետևյալ խնդիրների ծրագրերն ։
 * 28․ Սիմվոլային f փոփոխականին վերագրել 'a' արժեքը, եթե եռանիշ
 * թվի տասնավորների և հարյուրավորների թվանշանների գումարը փոքր է 5-ից ,
 * հակառակ դեպքում ՝ 'b' արժեքը ։ Արտածել f-ի արժեքը ;
 */
public class Task028 {
    public static void Main() {
        var num = Random.Shared.Next(100, 1000);
        Console.WriteLine($"number: {num}");
        if (num is <= 99 or > 999) {
            Console.Error.WriteLine("Number is not a three digit. Please enter three digit number between 100 & 999");
            return;
        }
        Console.WriteLine($"Result: {Solution(num)}");
    }

    private static char Solution(int number) {
        var hundreds = number / 100;
        var tens = (number / 10) % 10;
        var units = number % 10;

        var sumOfDigits = tens + hundreds;
        return sumOfDigits < 5 ? 'a' : 'b';
    }
}