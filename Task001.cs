namespace Lessons;

/*
 * Տրված են իրարից տարբեր a, b c թվերը ։ Կազմել ծրագրեր որոնք
 * 1․ կարտածեն տրված թվերից մեծի արժեքը ։
 */

public abstract class Task001 {
    public static void Main() {
        
        Console.Write("Enter first number ");
        var a = Convert.ToInt32(Console.ReadLine());
        Console.Out.Write("Enter second number ");
        var b = Convert.ToInt32(Console.ReadLine());
        Console.Out.Write("Enter third number ");
        var c = Convert.ToInt32(Console.ReadLine());

        if (a > b && a > c) {
            Console.Out.Write(a + " is biggest");
        } else if (b > a && b > c) {
            Console.Out.Write(b + " is biggest");
        } else {
            Console.Out.Write(c + " is biggest");
        }
    }
}