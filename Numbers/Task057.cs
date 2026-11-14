namespace Lessons.Numbers;

/*
 * Կազմել հետևյալ խնդիրների լուծման ծրագրերը ։
 * 56․ y փոփոխականին վերագրել 0 արժեքը, եթե տրված n բնական թիվը 4-ի աստիճան չէ,
 * հակառակ դեպքում 1 արժեքը ։ Տպել y-ի արժեքը ;
 */
public class Task057 {
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