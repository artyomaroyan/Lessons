namespace Lessons.arrays;

/*
 * Կազմել ծրագրեր , որոնք կհաշվեն և կտպեն տրված n տարրեր պարունակող միաչափ զանգվածի `
 * 77. դրական և բացասական տարրերի քանակը ;
 */
public class Task077 {
    public static void Main() {
        var numbers = GenerateRandomArray(10);
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");

        var result = Solution(numbers);
        Console.WriteLine($"Result: {result}");
    }

    private static string Solution(int[] array) {
        var positive = 0;
        var negative = 0;

        foreach (var e in array) {
            if (e >= 0) positive++;
            else negative++;
        }
        return $"Positives: {positive}, Negatives: {negative}";
    }

    private static int[] GenerateRandomArray(int n) {
        var numbers = new int[n];
        for (var i = 0; i < numbers.Length; i++) {
            numbers[i] = Random.Shared.Next(-25, 25);
        }
        return numbers;
    }
}