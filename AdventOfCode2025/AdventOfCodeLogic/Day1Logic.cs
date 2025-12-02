using AdventOfCodeDal.Day1Data;

namespace AdventOfCodeLogic
{
    public class Day1Logic
    {
        private readonly day1Dal _dal;

        public Day1Logic(day1Dal dal)
        {
            _dal = dal;
        }

        public int day1Part1()
        {
            var file = _dal.GetDay1Data();

            foreach (var line in file)
            {
                Console.WriteLine(line);
            }
            return 32;
        }
    }
}