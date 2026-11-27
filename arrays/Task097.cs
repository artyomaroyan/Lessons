namespace Lessons.arrays;

/*
 * Կազմել ծրագրեր , որոնք կհաշվեն և կտպեն n հատ ամբողջ տիպի տարրեր պարունակող միաչափ զանգվածի
 * 97. 7-ին բազմապատիկ տարրերի քանակը ;
 */
public class Task097 {
    public static void Main() {
        var numbers = GenerateRandomArray(10);
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");

        var result = Solution(numbers);
        Console.WriteLine($"Result: {result}");
    }

    private static int Solution(int[] array) {
        var count = 0;

        foreach (var e in array) {
            if (e % 7 != 0) continue;
            count++;
        }
        return count;
        // return array.Count(e => e % 7 == 0);
    }
    
    private static int[] GenerateRandomArray(int n) {
        var numbers = new int[n];
        for (var i = 0; i < numbers.Length; i++) {
            numbers[i] = Random.Shared.Next(-100, 100);
        }
        return numbers;
    }
}