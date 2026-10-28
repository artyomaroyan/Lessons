namespace Lessons.ThreeNumber;

public static class Task002 {
    public static void Main() {
        Console.WriteLine("Enter first number");
        var a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        var b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third number");
        var c = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"Smallest: {FindSmallest(a, b, c)}");
    }

    private static int FindSmallest(int a, int b, int c) {
        return a < b
            ? (a < c ? a : c)
            : (b < c ? b : c);
        // return (a < b && a < b) ? a
        //     : (b < a && b < c) ? b
        //     : c;
    }
}