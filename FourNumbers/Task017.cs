namespace Lessons.FourNumbers;

/*
 * Տրված են իրարից տարբեր a, b c և d թվերը ։ Կազմել ծրագրեր որոնք
 * 17. կարտածեն true , եթե տրված թվերն կազմում են թվաբանական պրոգրեսիա , այլապես ` false ;
 */
public class Task017 {
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
        int difference = a - b;
        return b - c == difference && c - d == difference;
    }
    
    // alternative: better approach
    private static bool AltSolution(int a, int b, int c, int d) {
        var n = new long[] { a, b, c, d };
        Array.Sort(n);
        long difference = n[1] - n[0];
        return n[2] - n[1] == difference && n[3] - n[2] == difference;
    }
}