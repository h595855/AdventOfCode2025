using System.Text.RegularExpressions;
using AdventOfCodeDal.Day1Data;

namespace AdventOfCodeLogic
{
    public class Day1Logic
    {
        private readonly Day1Dal _dal;

        public Day1Logic(Day1Dal dal)
        {
            _dal = dal;
        }

        public int Day1Part1()
        {
            int startingpoint = 50;
            int zeroCount = 0;
            
            var file = _dal.GetDay1Data();

            foreach (var line in file)
            {
                var (operation, numberPart) = parseInstruction(line);
                startingpoint = calculateSurpluss(startingpoint, numberPart, operation[0]);
                
                if(startingpoint == 0)
                    zeroCount++;
            }
            return zeroCount;
        }

        private int calculateSurpluss(int current, int next, char operation)
        {
           var step = ((next % 100) + 100) % 100;

           return operation switch
           {
               'R' => (current + step) % 100,
               'L' => ((current - step) % 100 + 100) % 100,
           };
        }
        
        private (string operation, int numberPart) parseInstruction(string instruction)
        {
            Regex re = new Regex(@"([a-zA-Z]+)(\d+)");
            Match result = re.Match(instruction);

            string operation = result.Groups[1].Value;
            int numberPart = int.Parse(result.Groups[2].Value);
            
            return (operation, numberPart);
        }
    }
}