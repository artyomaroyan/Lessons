namespace Lessons.ThreeNumber;

/*
 * Տրված են իրարից տարբեր a, b c թվերը ։ Կազմել ծրագրեր որոնք
 * 6. կարտածեն մեկ , եթե տրված թվերից գոնե մեկը զույգ է, այլապես երկու;
 */
public class Task006 {
    public static void Main() {
        Console.WriteLine("Enter first number");
        var a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        var b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third number");
        var c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Result: {Solution(a, b, c)}");
    }

    private static int Solution(int a, int b, int c) => a % 2 == 0 || b % 2 == 0 || c % 2 == 0 ? 1 : 2;
}