namespace Lessons.FourNumbers;

/*
 * Տրված են իրարից տարբեր a, b c և d թվերը ։ Կազմել ծրագրեր որոնք
 * 15. եթե տրված թվերից մեկը հավասար է մյուս երեք թվերի գումարին,
 * ապա կարտածեն true , հակառակ դեպքում` false :
 */
public class Task015 {
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

    private static bool Solution(int a, int b, int c, int d) =>
        a == b + c + d || b == a + c + d || c == a + b + d || d == a + b + c;
}