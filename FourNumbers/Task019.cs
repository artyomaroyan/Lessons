namespace Lessons.FourNumbers;

/*
 * Տրված են իրարից տարբեր a, b c և d թվերը ։ Կազմել ծրագրեր որոնք
 * 19. տրված թվերն կարտածեն ըստ աճման կարգի հաջորդականության ;
 */
public class Task019 {
    public static void Main() {
        Console.WriteLine("Enter first number");
        var a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        var b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third number");
        var c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter fourth number");
        var d = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Result: {string.Join(", ", Solution(a, b, c, d))}");
    }

    private static int[] Solution(int a, int b, int c, int d) {
        int[] numbers = [a, b, c, d];
        for (var i = 1; i < numbers.Length; i++) {
            var key = numbers[i];
            var j = i - 1;

            while (j >= 0 && numbers[j] > key) {
                numbers[j + 1] = numbers[j];
                j--;
            }
            numbers[j + 1] = key;
        }
        return numbers;
    }
}