using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace tco14
{
    public class PackingBallsDiv2
    {
        public int minPacks(int R, int G, int B)
        {
            if (R == G && G == B)
                return R;

            var colors = new List<int>() {R, G, B};
            colors.Sort();
            var sets = new List<int>();
            
            sets.Add(colors[0]);

            var remainingSecondColor = calculeNumberofSets(colors[1] - colors[0], sets, 2);            
            var remainingThirdColor = calculeNumberofSets(colors[2] - colors[0], sets, 2);

            sets.Add(getNumberOfSets(remainingSecondColor, 1));
            remainingThirdColor -= sets.Last();

            sets.Add(getNumberOfSets(remainingThirdColor, 1));

            return sets.Sum();
        }

        private int calculeNumberofSets(int color, List<int> sets, int limit = 1)
        {
            for (int i = 3; i > limit - 1; i--)
            {
                sets.Add(getNumberOfSets(color, i));
                color -= sets.Last()*i;
            }
            return color;
        }

        private int getNumberOfSets(int color, int numberOfBalls = 3)
        {
            int result = 0;
            while (color >= numberOfBalls)
            {
                color = color - numberOfBalls;
                result++;
            }
            return result;
        }

    }
}
