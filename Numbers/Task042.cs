namespace Lessons.Numbers;

/*
 * Կազմել հետևյալ խնդիրների լուծման ծրագրերը ։
 * 42․ Տպել բոլոր այն բնական թվերի արտադրյալը, որոնց վրա առանց մնացորդի բաժանվում է տրված n թիվը ;
 */
public class Task042 {
    public static void Main() {
        var num = Random.Shared.Next(1, 20);
        Console.WriteLine($"number: {num}");
        Console.WriteLine($"Result: {Solution(num)}");
    }

    private static int Solution(int n) {
        if (n <= 0)
            throw new ArgumentOutOfRangeException(nameof(n), "n must be greater than 0");

        var multiply = 1;
        for (var i = 1; i * i <= n; i++) {
            if (n % i != 0) continue;
            multiply *= i;

            if (i != n / i) {
                multiply *= n / i;
            }
        }
        return multiply;
    }
}