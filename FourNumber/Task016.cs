namespace Lessons.FourNumber;

/*
 * Տրված են իրարից տարբեր a, b c և d թվերը ։ Կազմել ծրագրեր որոնք
 * 16. եթե տրված թվերից գոնե երկուսը կենտ են , ապա կարտածեն մեկ, հակառակ դեպքում ՝ երկու ;
 */
public class Task016 {
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
        var oddCount = 0;
        if (a % 2 == 0) oddCount++;
        if (b % 2 == 0) oddCount++;
        if (c % 2 == 0) oddCount++;
        if (d % 2 == 0) oddCount++;

        return oddCount >= 2 ? 2 : 1;
    }

    // alternative 
    private static int AltSolution(int a, int b, int c, int d) =>
        new[] { a, b, c, d }.Count(x => x % 2 == 0) >= 2 ? 2 : 1;

    private static int AltSolution(params int[] values) =>
        values.Count(x => x % 2 == 0) >= 2 ? 2 : 1;
}