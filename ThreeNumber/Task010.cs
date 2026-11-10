namespace Lessons.ThreeNumber;

/*
 * Տրված են իրարից տարբեր a, b c թվերը ։ Կազմել ծրագրեր որոնք
 * 10. տրված թվերն կարտածեն ըստ նվազման կարգի հաջորդականության։
 */
public class Task010 {
    public static void Main() {
        Console.WriteLine("Enter first number");
        var a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        var b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third number");
        var c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Result: {string.Join(", ", Solution(a, b, c))}");
    }

    private static int[] Solution(int a, int b, int c) {
        int[] array = [a, b, c];
        for (var i = 1; i < array.Length; i++) {
            var key = array[i];
            var j = i - 1;

            while (j >= 0 && array[j] < key) {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
        return array;
    }
}