namespace Lessons.arrays;

/*
 * Կազմել ծրագրեր , որոնք կհաշվեն և կտպեն տրված n տարրեր պարունակող միաչափ զանգվածի `
 * 83. այն տարրերի քանակը , որոնք բացարձակ արժեքով փոքր են տրված k թվից ;
 */
public class Task083 {
    private static readonly int K = Random.Shared.Next(0, 10);
    public static void Main() {
        var numbers = GenerateRandomArray(10);
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");
        Console.WriteLine($"K: {K}");

        var result = Solution(numbers);
        Console.WriteLine($"Result: {result}");
    }

    private static int? Solution(int[] array) {
        var count = 0;

        foreach (var e in array) {
            if (e >= K) continue;
            count++;
        }
        return count;
    }

    private static int[] GenerateRandomArray(int n) {
        var numbers = new int[n];
        for (var i = 0; i < numbers.Length; i++) {
            numbers[i] = Random.Shared.Next(-25, 25);
        }
        return numbers;
    }
}