namespace Lessons.arrays;

/*
 * Կազմել ծրագրեր , որոնք կհաշվեն և կտպեն տրված n տարրեր պարունակող միաչափ զանգվածի `
 * 78. տրված [a; b] միջակայքին պատկանող տարրերի գումարը;
 */
public class Task078 {
    private const int IntervalA = -10;
    private const int IntervalB = 20;
    public static void Main() {
        var numbers = GenerateRandomArray(10);
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");

        var result = Solution(numbers);
        Console.WriteLine($"Result: {result}");
    }

    private static int Solution(int[] array) {
        //foreach (var e in array) {
        //    if (Interval_A <= e && e <= Interval_B) {
        //        sum += e;
        //    }
        return array.Where(e => e is >= IntervalA and <= IntervalB).Sum();
    }

    private static int[] GenerateRandomArray(int n) {
        var numbers = new int[n];
        for (var i = 0; i < numbers.Length; i++) {
            numbers[i] = Random.Shared.Next(-25, 25);
        }
        return numbers;
    }
}