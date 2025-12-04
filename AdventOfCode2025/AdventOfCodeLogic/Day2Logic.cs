using AdventOfCodeDal.Day2Data;

namespace AdventOfCodeLogic
{
    public class Day2Logic
    {

        public int  Day2Part1()
        {
            Day2Dal day2Dal = new Day2Dal();
            var data = day2Dal.GetDay2Data();
            int totalInvalidIds = 0;

            foreach (var range  in data)
            {
               // split range into two parts split by "-" 
               // List all numbers in the range
               // Summerize numbers which have repeated digits
               var parts = range.Split('-');
               int start = int.Parse(parts[0]);
               int end = int.Parse(parts[1]);
               
            }
            return totalInvalidIds;
        }
    }
}