namespace Lessons.ThreeNumber;

/*
 * Տրված են իրարից տարբեր a, b c թվերը ։ Կազմել ծրագրեր որոնք
 * 3. եթե տրված թվերից գոնե մեկը հավասար է մեկի , ապա կարտածեն true , հակառակ դեպքում ՝ false;
 */
public static class Task003 {
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
        return a == 1 || b == 1 || c == 1;
    }
}