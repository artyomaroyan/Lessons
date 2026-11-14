namespace Lessons.Numbers;

/*
 * Կազմել հետևյալ խնդիրների լուծման ծրագրերը ։
 * 47․ Տպել բոլոր այն եռանիշ թվերի գումարը , որոնք բազմապատիկ չեն 5 թվին ;
 */
public class Task047 {
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