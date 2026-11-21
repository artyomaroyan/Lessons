namespace Lessons.arrays;

/*
 * Կազմել ծրագրեր , որոնք կհաշվեն և կտպեն տրված n տարրեր պարունակող միաչափ զանգվածի `
 * 87. այն տարրերի միջին քառակուսայինը , որոնց ամբողջ մասը բազմապատիկ է տրված k ամբողջ թվին ;
 */
public class Task087 {
    private static readonly int K = Random.Shared.Next(1, 10);
    public static void Main() {
        var numbers = GenerateRandomArray(10);
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");
        Console.WriteLine($"K: {K}");

        var result = Solution(numbers);
        Console.WriteLine($"Result: {result}");
    }

    private static double? Solution(double[] array) {
        double sumOfSquares = 1;
        var count = 0;

        foreach (var e in array) {
            var integerPart = (long)Math.Truncate(e);
            if (integerPart % K != 0) continue;
            sumOfSquares += e * e;
            count++;
        }
        return count == 0 ? null : Math.Sqrt(sumOfSquares / count);
    }

    private static double[] GenerateRandomArray(int n) {
        var numbers = new double[n];
        for (var i = 0; i < numbers.Length; i++) {
            numbers[i] = Random.Shared.NextDouble() * 100 - 50;
        }
        return numbers;
    }
}