namespace Lessons.FourNumber;

/*
 * Տրված են իրարից տարբեր a, b c և d թվերը ։ Կազմել ծրագրեր որոնք
 * 18. կարտածեն true , եթե տրված թվերն կազմում են երկրաչափական պրոգրեսիա , այլապես ` false ;
 */
public class Task018 {
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

    private static bool Solution(int a, int b, int c, int d) {
        return b * b == a * c && c * c == b * d;
    }
}