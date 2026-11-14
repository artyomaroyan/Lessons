namespace Lessons.Numbers;

/*
 * Կազմել հետևյալ խնդիրների լուծման ծրագրերը ։
 * 44․ Տպել բոլոր այն բնական թվերի արտադրյալը, որոնց վրա տրված n թիվը բաժանելիս կմնա 3 մնացորդ ;
 */
public class Task044 {
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