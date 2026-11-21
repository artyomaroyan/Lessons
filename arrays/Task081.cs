namespace Lessons.arrays;

/*
 * Կազմել ծրագրեր , որոնք կհաշվեն և կտպեն տրված n տարրեր պարունակող միաչափ զանգվածի `
 * 81. այն տարրերի խորանարդների գումարը, որոնք բացարձակ արժեքով փոքր են տրված k թվից ;
 */
public class Task081 {
    private static readonly int K = Random.Shared.Next(0, 100);
    public static void Main() {
        var numbers = GenerateRandomArray(25);
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");
        Console.WriteLine($"K: {K}");

        var result = Solution(numbers);
        Console.WriteLine($"Result: {result}");
    }

    private static int? Solution(int[] array) {
        var sum = 0;

        foreach (var e in array) {
            if (Math.Abs(e) >= K) continue;
            var cube = e * e * e;
            sum += cube;
        }
        return sum;
        // return array.Where(e => Math.Abs(e) <= K).Sum(e => e * e * e);
    }

    private static int[] GenerateRandomArray(int n) {
        var numbers = new int[n];
        for (var i = 0; i < numbers.Length; i++) {
            numbers[i] = Random.Shared.Next(-100, 100);
        }
        return numbers;
    }
}