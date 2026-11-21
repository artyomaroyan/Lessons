namespace Lessons.arrays;

/*
 * Կազմել ծրագրեր , որոնք կհաշվեն և կտպեն տրված n տարրեր պարունակող միաչափ զանգվածի `
 * 76. տրված k թվին բազմապատիկ ինդեքս ունեցող տարրերի քանակը;
 */
public class Task076 {
    private static readonly int K = Random.Shared.Next(1, 9);
    public static void Main() {
        var numbers = GenerateRandomArray(10);
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");
        Console.WriteLine($"Static K: {K}");

        var result = Solution(numbers);
        if (result is 0) {
            Console.Error.WriteLine("empty");
            return;
        }
        Console.WriteLine($"Result: {result}");
    }

    private static int Solution(int[] array) {
        // var count = 0;
        //
        // for (var i = 0; i < array.Length; i++) {
        //     if (array[i] % K == 0) {
        //         count++;
        //     }
        // }
        // return count;
        return array.Count(e => e % K == 0);
    }

    private static int[] GenerateRandomArray(int n) {
        var numbers = new int[n];
        for (var i = 0; i < numbers.Length; i++) {
            numbers[i] = Random.Shared.Next(-25, 25);
        }
        return numbers;
    }
}