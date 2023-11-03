public static class Divisors {
    /// <summary>
    /// Entry point for the Divisors class
    /// </summary>
    public static void Run() {
        List<int> list = FindDivisors(80);
        Console.WriteLine("<List>{" + string.Join(", ", list) + "}"); // <List>{1, 2, 4, 5, 8, 10, 16, 20, 40}
        List<int> list1 = FindDivisors(79);
        Console.WriteLine("<List>{" + string.Join(", ", list1) + "}"); // <List>{1}
    }

    private static List<int> FindDivisors(int number) {
        List<int> results = new List<int>();
        int count = 0;
        for (int i = 1; i < (number/2+1); ++i) {
            if (number % i == 0) {
                results.Add(i);
            }
            count++;
        }
        Console.WriteLine(count);
        return results;
    }
}