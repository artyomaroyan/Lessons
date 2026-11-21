namespace Lessons.arrays;

/*
 * Կազմել ծրագրեր , որոնք կհաշվեն և կտպեն տրված n տարրեր պարունակող միաչափ զանգվածի `
 * 79. տրված [c; d) միջակայքին պատկանող տարրերի արտադրյալը ;
 */
public class Task079 {
    private const int IntervalC = -10;
    private const int IntervalD = 20;
    public static void Main() {
        var numbers = GenerateRandomArray(10);
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");

        var result = Solution(numbers);
        Console.WriteLine($"Result: {result}");
    }

    private static int? Solution(int[] array) {
        var product = 1;
        var found = false;

        foreach (var e in array) {
            if (e is >= IntervalC and < IntervalD) {
                product *= e;
                found = true;
            }
        }
        return found ? product : null;
    }

    private static int[] GenerateRandomArray(int n) {
        var numbers = new int[n];
        for (var i = 0; i < numbers.Length; i++) {
            numbers[i] = Random.Shared.Next(-25, 25);
        }
        return numbers;
    }
}