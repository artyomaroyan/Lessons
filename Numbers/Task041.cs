namespace Lessons.Numbers;

/*
 * Կազմել հետևյալ խնդիրների լուծման ծրագրերը ։
 * 41․ Տպել բոլոր այն բնական թվերի գումարը, որոնց վրա առանց մնացորդի բաժանվում է տրված n թիվը ;
 */
public class Task041 {
    public static void Main() {
        var num = Random.Shared.Next(1, 20);
        Console.WriteLine($"number: {num}");
        Console.WriteLine($"Result: {Solution(num)}");
    }

    private static int Solution(int n) {
        if (n <= 0)
            throw new ArgumentOutOfRangeException(nameof(n), "n must be greater 0");

        var sum = 0;
        for (var i = 1; i * i <= n; i++) {
            if (n % i != 0) continue;
            sum += i;

            if (i != n / i) {
                sum += n / i;
            }
        }
        return sum;
    }
}