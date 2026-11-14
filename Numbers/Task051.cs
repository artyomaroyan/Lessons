namespace Lessons.Numbers;

/*
 * Կազմել հետևյալ խնդիրների լուծման ծրագրերը ։
 * 51․ Տպել ամենափոքր քառանիշ թիվը, որը 26-ով բազմապատկելիս դառնում է բնական թվի քառակուսի ;
 */
public class Task051 {
    public static void Main() {
        var num = Random.Shared.Next(1, 1_000_000);
        Console.WriteLine($"number: {num}");
        Console.WriteLine($"Result: {Solution(num)}");
    }

    private static int Solution(int n) {
        //TODO: complete task
        return 1;
    }
}