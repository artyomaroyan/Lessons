namespace Lessons.FourNumber;

/*
 * Տրված են իրարից տարբեր a, b c թվերը ։ Կազմել ծրագրեր որոնք
 * 13. կարտածեն true , եթե տրված թվերից գոնե մեկը հավասար է մեկի , այլապես ՝ false ;
 */
public class Task013 {
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
        int[] numbers = [a, b, c, d];
        return numbers.Contains(1);
    }
}