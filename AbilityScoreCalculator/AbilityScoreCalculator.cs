using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityScoreCalculator
{
    class AbilityScoreCalculator
    {
        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;

        public void CalculateAbilityScore()
        {
            double divided = RollResult / DivideBy; //dzielenie wyniku rzutu przez pole DivideBy

            int added = AddAmount += (int)divided; //dodawanie AddAmount do wyniku dzielenia

            if (added < Minimum)  //jeśli wynik jest z niski użyj Minimum
            {
                Score = Minimum;
            }
            else
            {
                Score = added;
            }
        }

    }
}
