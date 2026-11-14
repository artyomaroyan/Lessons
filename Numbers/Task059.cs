namespace Lessons.Numbers;

/*
 * Կազմել հետևյալ խնդիրների լուծման ծրագրերը ։
 * 58․ հաշվել և արտածել թվի թվանշանների գումարը,
 */
public class Task059 {
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