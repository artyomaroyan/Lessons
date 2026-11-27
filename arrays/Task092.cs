namespace Lessons.arrays;

/*
 * Կազմել ծրագրեր , որոնք կհաշվեն և կտպեն n հատ ամբողջ տիպի տարրեր պարունակող միաչափ զանգվածի
 * 92. կենտ արժեք ունեցող տարրերի միջին քառակուսայինը ;
 */
public class Task092 {
    public static void Main() {
        var numbers = GenerateRandomArray(10);
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");

        var result = Solution(numbers);
        Console.WriteLine($"Result: {result}");
    }

    private static double Solution(int[] array) {
        var sum = 0;
        var count = 0;

        foreach (var e in array) {
            if (e % 2 == 0) continue;
            var square = e * e;
            sum += square;
            count++;
        }
        return count != 0 ? Math.Sqrt((double)sum / count) : 0;
    }
    
    private static int[] GenerateRandomArray(int n) {
        var numbers = new int[n];
        for (var i = 0; i < numbers.Length; i++) {
            numbers[i] = Random.Shared.Next(-100, 100);
        }
        return numbers;
    }
}