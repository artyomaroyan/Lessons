namespace Lessons.arrays;

/*
 * Կազմել ծրագրեր , որոնք կհաշվեն և կտպեն n հատ ամբողջ տիպի տարրեր պարունակող միաչափ զանգվածի
 * 90. զույգ արժեք ունեցող տարրերի արտադրյալը և գումարը ;
 */
public class Task090 {
    public static void Main() {
        var numbers = GenerateRandomArray(10);
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");

        var result = Solution(numbers);
        Console.WriteLine($"Result: {result}");
    }

    private static string Solution(int[] array) {
        var sum = 0;
        var product = 1;

        foreach (var e in array) {
            if (e % 2 != 0) continue;
            sum += e;
            product *= e;
        }
        return $"Sum: {sum}, Product: {product}";
    }
    
    private static int[] GenerateRandomArray(int n) {
        var numbers = new int[n];
        for (var i = 0; i < numbers.Length; i++) {
            numbers[i] = Random.Shared.Next(-100, 100);
        }
        return numbers;
    }
}