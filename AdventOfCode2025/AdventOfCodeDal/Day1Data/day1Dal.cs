namespace AdventOfCodeDal.Day1Data
{
    public class day1Dal
    {
        public List<string> GetDay1Data()
        {
            var candidates = new[]
                {
                    Path.Combine(AppContext.BaseDirectory, "AdventOfCodeDal", "Day1Data", "day1Data.txt"),
                    Path.Combine(AppContext.BaseDirectory, "Day1Data", "day1Data.txt"),
                    Path.Combine(AppContext.BaseDirectory, "day1Data.txt"),
                    Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "AdventOfCodeDal", "Day1Data", "day1Data.txt")
                }
                .Select(Path.GetFullPath)
                .ToList();

            var file = candidates.FirstOrDefault(File.Exists);

            return File.ReadAllLines(file!).ToList();
        }
    }
}