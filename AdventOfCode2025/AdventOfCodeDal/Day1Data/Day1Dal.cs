using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AdventOfCodeDal.Day1Data
{
    public class Day1Dal
    {
        public List<string> GetDay1Data()
        {
            var assemblyDir = Path.GetDirectoryName(typeof(Day1Dal).Assembly.Location) ?? AppContext.BaseDirectory;

            var candidates = new[]
            {
                Path.GetFullPath(@"C:\Users\beide\RiderProjects\AdventOfCode2025\AdventOfCode2025\AdventOfCodeDal\Day1Data\day1Data.txt")
            }
            .Select(Path.GetFullPath)
            .Distinct()
            .ToList();

            var file = candidates.FirstOrDefault(File.Exists);

            if (file == null)
            {
                var tried = string.Join(Environment.NewLine, candidates);
                throw new FileNotFoundException($"Could not find `day1Data.txt`. Tried the following paths:{Environment.NewLine}{tried}");
            }

            return File.ReadAllLines(file).ToList();
        }
    }
}