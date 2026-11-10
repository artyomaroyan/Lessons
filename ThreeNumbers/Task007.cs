namespace Lessons.ThreeNumber;

/*
 * Տրված են իրարից տարբեր a, b c թվերը ։ Կազմել ծրագրեր որոնք
 * 7. կարտածեն true , եթե տրված թվերն թվաբանական պրոգրեսիա են կազմում, հակառակ դեպքում false:
 */
public class Task007 {
    public static void Main() {
        Console.WriteLine("Enter first number");
        var a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        var b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third number");
        var c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Result: {Solution(a, b, c)}");
    }

    private static bool Solution(int a, int b, int c) => a - b == b - c;
}