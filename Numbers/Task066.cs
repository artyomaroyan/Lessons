namespace Lessons.Numbers;

/*
 * Կազմել հետևյալ խնդիրների լուծման ծրագրերը ։
 * 66․ արտածել true , եթե թվի կենտ համարով թվանշանների գումարը հավասար է զույգ համարով թվանշանների գումարին, հակառակ դեպքում ` false;
 */
public class Task066 {
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