namespace Lessons.arrays;

/*
 * Կազմել ծրագրեր , որոնք կհաշվեն և կտպեն տրված n տարրեր պարունակող միաչափ զանգվածի `
 * 73. զույգ ինդեքս ունեցող տարրերի արտադրյալը ;
 */
public class Task073 {
    public static void Main() {
        var numbers = GenerateRandomArray(20);
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");

        var result = Solution(numbers);
        if (result is 0) {
            Console.Error.WriteLine("empty");
            return;
        }
        Console.WriteLine($"Result: {result}");
    }

    private static int Solution(int[] array) {
        var multiply = 1;
        var evens = new int[(array.Length + 1) / 2];
        for (int i = 0, j = 0; i < array.Length; i += 2, j++) {
            evens[j] = array[i];
            multiply *= evens[j];
        }
        Console.WriteLine($"Evens: {string.Join(", ", evens)}");
        return multiply;
    }
    
    private static int[] GenerateRandomArray(int n) {
        var numbers = new int[n];
        for (var i = 0; i < numbers.Length; i++) {
            numbers[i] = Random.Shared.Next(-10, 10);
        }
        return numbers;
    }
}