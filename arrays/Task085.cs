namespace Lessons.arrays;

/*
 * Կազմել ծրագրեր , որոնք կհաշվեն և կտպեն տրված n տարրեր պարունակող միաչափ զանգվածի `
 * 85. այն տարրերի գումարը , որոնց ինդեքսը առանց մնացորդի բաժանվում է տրված k ամբողջ թվի վրա ;
 */
public class Task085 {
    private static readonly int K = Random.Shared.Next(1, 10);
    public static void Main() {
        var numbers = GenerateRandomArray(10);
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");
        Console.WriteLine($"K: {K}");

        var result = Solution(numbers);
        Console.WriteLine($"Result: {result}");
    }

    private static int? Solution(int[] array) {
        var sum = 0;

        for (var i = 0; i < array.Length; i += K) {
            sum += array[i];
        }
        return sum;
    }

    private static int[] GenerateRandomArray(int n) {
        var numbers = new int[n];
        for (var i = 0; i < numbers.Length; i++) {
            numbers[i] = Random.Shared.Next(-25, 25);
        }
        return numbers;
    }
}