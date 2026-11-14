namespace Lessons.Numbers;

/*
 * Կազմել հետևյալ խնդիրների լուծման ծրագրերը ։
 * 55․ t տրամաբանական տիպի փոփոխականին կվերագրի true արժեքը ,
 * եթե տրված n բնական թիվը 3-ի աստիճան է , հակառակ դեպքում ՝ false :
 */
public class Task056 {
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