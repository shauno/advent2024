namespace advent.Days;

public class Day1 {
    public static int Answer() {

        String? line;
        List<int> one = [];
        List<int> two = [];

        StreamReader sr = new("./Days/input.txt");
        while (!sr.EndOfStream)
        {
            line = sr.ReadLine();
            one.Add(Int32.Parse(line.Split("   ")[0]));
            two.Add(Int32.Parse(line.Split("   ")[1]));
        }
        sr.Close();

        one.Sort();
        two.Sort();

        int diff = 0;
        foreach (var (x, y) in one.Zip(two))
        {
            diff += Math.Abs(x - y);
        }

        return diff;
    }
}
