namespace Lessons.Numbers;

/*
 * Կազմել հետևյալ խնդիրների լուծման ծրագրերը ։
 * 43․ Տպել բոլոր այն բնական թվերի գումարը, որորնց վրա տրված n բնական թիվը բաժանելիս կմնա 2 մնացորդ ;
 */
public class Task043 {
    public static void Main() {
        var num = Random.Shared.Next(1, 20);
        Console.WriteLine($"number: {num}");
        Console.WriteLine($"Result: {Solution(num)}");
    }

    private static int Solution(int n) {
        //TODO: complete task
        return 1;
    }
}