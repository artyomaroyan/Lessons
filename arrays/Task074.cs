namespace Lessons.arrays;

/*
 * Կազմել ծրագրեր , որոնք կհաշվեն և կտպեն տրված n տարրեր պարունակող միաչափ զանգվածի `
 * 74. կենտ ինդեքս ունեցող տարրերի քառակուսիների արտադրյալը ;
 */
public class Task074 {
    public static void Main() {
        var numbers = GenerateRandomArray(5);
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");

        var result = Solution(numbers);
        if (result is 0) {
            Console.Error.WriteLine("empty");
            return;
        }
        Console.WriteLine($"Result: {result}");
    }

    private static int Solution(int[] array) {
        var multiplication = 1;
        
        for (var i = 1; i < array.Length; i += 2) {
            var square = array[i] * array[i];
            multiplication *= square;
        }
        return multiplication;
    }
    
    private static int[] GenerateRandomArray(int n) {
        var numbers = new int[n];
        for (var i = 0; i < numbers.Length; i++) {
            numbers[i] = Random.Shared.Next(-5, 5);
        }
        return numbers;
    }
}