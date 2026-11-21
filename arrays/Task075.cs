namespace Lessons.arrays;

/*
 * Կազմել ծրագրեր , որոնք կհաշվեն և կտպեն տրված n տարրեր պարունակող միաչափ զանգվածի `
 * 75. կենտ արժեք ունեցող տարրերի բացարձակ արժեքների գումարը ;
 */
public class Task075 {
    public static void Main() {
        var numbers = GenerateRandomArray(10);
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");

        var result = Solution(numbers);
        if (result is 0) {
            Console.Error.WriteLine("empty");
            return;
        }
        Console.WriteLine($"Result: {result}");
    }

    private static int Solution(int[] array) {
        // var sum = 0;
        //
        // for (var i = 0; i < array.Length; i++) {
        //     if (array[i] % 2 == 0) continue;
        //     var abs = Math.Abs(array[i]);
        //     sum += abs;
        // }
        // return sum;
        return array
            .Where(t => t % 2 != 0)
            .Sum(Math.Abs);
    }

    private static int[] GenerateRandomArray(int n) {
        var numbers = new int[n];
        for (var i = 0; i < numbers.Length; i++) {
            numbers[i] = Random.Shared.Next(-25, 25);
        }
        return numbers;
    }
}