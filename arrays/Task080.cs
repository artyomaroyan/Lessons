namespace Lessons.arrays;

/*
 * Կազմել ծրագրեր , որոնք կհաշվեն և կտպեն տրված n տարրեր պարունակող միաչափ զանգվածի `
 * 80. տրված (a ; b) միջակայքին պատկանող տարրերի քանակը;
 */
public class Task080 {
    private const int IntervalA = -10; 
    private const int IntervalB = 10; 
    public static void Main() {
        var numbers = GenerateRandomArray(10);
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");

        var result = Solution(numbers);
        Console.WriteLine($"Result: {result}");
    }

    private static int? Solution(int[] array) {
        var count = 0;

        foreach (var e in array) {
            if (e is > IntervalA and < IntervalB) {
                count++;
            }
        }
        return count;
        // return array.Count(e => e is > IntervalA and < IntervalB);
    }

    private static int[] GenerateRandomArray(int n) {
        var numbers = new int[n];
        for (var i = 0; i < numbers.Length; i++) {
            numbers[i] = Random.Shared.Next(-25, 25);
        }
        return numbers;
    }
}