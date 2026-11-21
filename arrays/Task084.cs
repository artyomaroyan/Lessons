namespace Lessons.arrays;

/*
 * Կազմել ծրագրեր , որոնք կհաշվեն և կտպեն տրված n տարրեր պարունակող միաչափ զանգվածի `
 * 84. այն տարրերի միջին թվաբանականը , որոնց ինդեքսը բազմապատիկ է տրված k ամբողջ թվին ;
 */
public class Task084 {
    private static readonly int K = Random.Shared.Next(1, 10);
    public static void Main() {
        var numbers = GenerateRandomArray(10);
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");
        Console.WriteLine($"K: {K}");

        var result = Solution(numbers);
        Console.WriteLine($"Result: {result}");
    }

    private static double? Solution(int[] array) {
        var sum = 0;
        var count = 0;

        for (var i = 0; i < array.Length; i += K) {
                sum += array[i];
                count++;
        }
        return count == 0 ? null : (double)sum / count;
    }

    private static int[] GenerateRandomArray(int n) {
        var numbers = new int[n];
        for (var i = 0; i < numbers.Length; i++) {
            numbers[i] = Random.Shared.Next(-25, 25);
        }
        return numbers;
    }
}