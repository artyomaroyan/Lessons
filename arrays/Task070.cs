namespace Lessons.arrays;

/*
 * Կազմել ծրագրեր , որոնք կհաշվեն և կտպեն տրված n տարրեր պարունակող միաչափ զանգվածի `
 * 70. բացասական տարրերի միջին քառակուսայինը ;
 */
public class Task070 {
    public static void Main() {
        var numbers = GenerateRandomArray(20);
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");

        var result = Solution(numbers);
        if (result is null) {
            Console.Error.WriteLine("There are no negative elements.");
            return;
        }
        Console.WriteLine($"Result: {result:F2}");
    }

    private static double? Solution(int[] array) {
        long sum = 0;
        var count = 0;

        foreach (var i in array) {
            if (i >= 0) continue;
            sum += (long)i * i;
            count++;
        }
        
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Count: {count}");
        var average = (double)sum / count;
        return count == 0 ? null : Math.Sqrt((double)sum / count);
    }
    
    private static int[] GenerateRandomArray(int n) {
        var numbers = new int[n];
        for (var i = 0; i < numbers.Length; i++) {
            numbers[i] = Random.Shared.Next(-1000, 1000);
        }
        return numbers;
    }
}