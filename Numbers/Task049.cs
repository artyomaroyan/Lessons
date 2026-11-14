namespace Lessons.Numbers;

/*
 * Կազմել հետևյալ խնդիրների լուծման ծրագրերը ։
 * 49․Տպել բոլոր այն եռանիշ թվերի արտադրյալը, որոնք 3-ի բաժանելիս կմնա 1 մնացորդ, իսկ 4-ի բաժանելիս՝2 մնացորդ ;
 */
public class Task049 {
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