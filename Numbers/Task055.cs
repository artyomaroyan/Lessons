namespace Lessons.Numbers;

/*
 * Կազմել հետևյալ խնդիրների լուծման ծրագրերը ։
 * 54․ Տպել այն ամենափոքր եռանիշ թիվը, որի քառակուսի արմատը մեծ է տրված n բնական թվից ;
 */
public class Task055 {
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