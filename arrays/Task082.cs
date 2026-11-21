namespace Lessons.arrays;

/*
 * Կազմել ծրագրեր , որոնք կհաշվեն և կտպեն տրված n տարրեր պարունակող միաչափ զանգվածի `
 * 82. այն տարրերի արտադրյալը , որոնք բացարձակ արժեքով փոքր են t թվից ;
 */
public class Task082 {
    private static readonly int T = Random.Shared.Next(0, 100);
    public static void Main() {
        var numbers = GenerateRandomArray(10);
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");
        Console.WriteLine($"T: {T}");

        var result = Solution(numbers);
        Console.WriteLine($"Result: {result}");
    }

    private static long? Solution(int[] array) {
        var product = 1;

        foreach (var e in array) {
            if (Math.Abs(e) >= T) continue;
            product *= e;
        }
        return product;
        // return array.Where(e => Math.Abs(e) < T).Aggregate(1, (current, e) => current * e);
    }

    private static int[] GenerateRandomArray(int n) {
        var numbers = new int[n];
        for (var i = 0; i < numbers.Length; i++) {
            numbers[i] = Random.Shared.Next(-25, 25);
        }
        return numbers;
    }
}