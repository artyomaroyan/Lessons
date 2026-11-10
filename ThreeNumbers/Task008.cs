namespace Lessons.ThreeNumber;

/*
 * Տրված են իրարից տարբեր a, b c թվերը ։ Կազմել ծրագրեր որոնք
 * 8. կարտածեն true , եթե տրված թվերն երկրաչափական պրոգրեսիա են կազմում, հակառակ դեպքում false:
 */

public class Task008 {
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
        var n = b / a;
        return c / b == n;
    }
}