namespace Lessons.arrays;

/*
 * Կազմել ծրագրեր , որոնք կհաշվեն և կտպեն տրված n տարրեր պարունակող միաչափ զանգվածի `
 * 86. այն տարրերի արտադրյալը, որոնց արժեքի և ինդեքսի տարբերությունը դրական թիվ է ;
 */
public class Task086 {
    public static void Main() {
        var numbers = GenerateRandomArray(10);
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");

        var result = Solution(numbers);
        Console.WriteLine($"Result: {result}");
    }

    private static int? Solution(int[] array) {
        var product = 1;

        for (var i = 1; i < array.Length; i++) {
            if (array[i] - i > 0) {
                product *= array[i];
            }
        }
        return product;
    }

    private static int[] GenerateRandomArray(int n) {
        var numbers = new int[n];
        for (var i = 0; i < numbers.Length; i++) {
            numbers[i] = Random.Shared.Next(-25, 25);
        }
        return numbers;
    }
}