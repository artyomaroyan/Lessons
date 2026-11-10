namespace Lessons.FourNumbers;

/*
 * Տրված են իրարից տարբեր a, b c և d թվերը ։ Կազմել ծրագրեր որոնք
 * 12. կարտածեն նշված թվերից փոքրագույնի արժեքը
 */
public class Task012 {
    public static void Main() {
        Console.WriteLine("Enter first number");
        var a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        var b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third number");
        var c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter fourth number");
        var d = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Result: {Solution(a, b, c, d)}");
    }

    private static int Solution(int a, int b, int c, int d) {
        var min = a;
        if (b < min) min = b;
        if (c < min) min = c;
        if (d < min) min = d;
        return min;
    }
}