namespace AdventOfCodeDal.Day2Data
{
    public class Day2Dal
    {
        public List<string> GetDay2Data()
        {
            var assemblyDir = Path.GetDirectoryName(typeof(Day2Dal).Assembly.Location) ?? AppContext.BaseDirectory;

            var candidates = new[]
            {
                Path.GetFullPath("*/day2Data.txt")
            }
            .Select(Path.GetFullPath)
            .Distinct()
            .ToList();

            var file = candidates.FirstOrDefault(File.Exists);

            if (file != null) return File.ReadAllLines(file).ToList();
            
            var tried = string.Join(Environment.NewLine, candidates);
            throw new FileNotFoundException($"Could not find `day2Data.txt`. Tried the following paths:{Environment.NewLine}{tried}");

        }
    }
}