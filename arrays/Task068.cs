namespace Lessons.arrays;

/*
 * Կազմել ծրագրեր , որոնք կհաշվեն և կտպեն տրված n տարրեր պարունակող միաչափ զանգվածի `
 * 68. դրական տարրերի միջին թվաբանականը ;
 */
public class Task068 {
    public static void Main() {
        var numbers = GenerateRandomArray(20);
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");

        var result = Solution(numbers);
        if (result is null) {
            Console.Error.WriteLine("There are no positive elements.");
            return;
        }
        Console.WriteLine($"Result: {result:F2}");
    }

    private static double? Solution(int[] array) {
        var sum = 0;
        var count = 0;

        foreach (var i in array) {
            if (i <= 0) continue;
            sum += i;
            count++;
        }
        
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Count: {count}");
        return count == 0 ? null : (double)sum / count;
    }
    
    private static int[] GenerateRandomArray(int n) {
        var numbers = new int[n];
        for (var i = 0; i < numbers.Length; i++) {
            numbers[i] = Random.Shared.Next(-1000, 1000);
        }
        return numbers;
    }
}