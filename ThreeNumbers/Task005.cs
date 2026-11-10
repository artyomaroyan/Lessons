namespace Lessons.ThreeNumber;

/*
 * Տրված են իրարից տարբեր a, b c թվերը ։ Կազմել ծրագրեր որոնք
 * 5. եթե այդպիսի երկարություն ունեցող հատվածներով հնարավոր է կառուցել եռանկյունի ,
 * ապա կարտածեն “y=1” հակառակ դեպքում “y=2” արտահայտությունը ։
 */
public class Task005 {
    public static void Main() {
        Console.WriteLine("Enter first number");
        var a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        var b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third number");
        var c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Result: {Solution(a, b, c)}");
    }

    private static string Solution(int a, int b, int c) {
        return a + b > c && a + c > b && b + c > a ? "y=1" : "y=2";
    }
}