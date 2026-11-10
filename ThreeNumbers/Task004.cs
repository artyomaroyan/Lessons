namespace Lessons.ThreeNumber;

/* Տրված են իրարից տարբեր a, b c թվերը ։ Կազմել ծրագրեր որոնք
 * 4. եթե տրված թվերից ճիշտ երկուսը հավասար են երկուսի, ապա կարտածեն true , հակառակ դեպքում՝ false;
 */
public class Task004 {
    public static void Main() {
        Console.WriteLine("Enter first number");
        var a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        var b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third number");
        var c = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"Result: {Solution(a, b, c)}");
    }

    private static bool Solution(int a, int b, int c) {
        return a == 2 && b == 2 || a == 2 && c == 2 || b == 2 && c == 2;
    }
}