namespace Lessons.ThreeDigit;

/*
 * Տրված է եռանիշ թիվ ։ Կազմել հետևյալ խնդիրների ծրագրերն ։
 * 29․ Արտածել եռանիշ թվի թվանշանները ըստ աճման կարգի հաջորդականության ;
 */
public class Task029 {
    public static void Main() {
        var num = Random.Shared.Next(100, 1000);
        Console.WriteLine($"number: {num}");
        if (num is <= 99 or > 999) {
            Console.Error.WriteLine("Number is not a three digit. Please enter three digit number between 100 & 999");
            return;
        }
        Console.WriteLine($"Result: {string.Join(",", Solution(num))}");
    }

    private static int[] Solution(int number) {
        var hundreds = number / 100;
        var tens = (number / 10) % 10;
        var units = number % 10;

        int[] array = [hundreds, tens, units];
        for (var i = 1; i < array.Length; i++) {
            var key = array[i];
            var j = i - 1;

            while (j >= 0 && array[j] > key) {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
        return array;
    }
}