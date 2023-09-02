using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace One_hand_bandit
{
    public enum Result
    {
        gold, berry, x
    }

    internal class Bandit
    {
    

        public event EventHandler<ResultEventArgs>? Spinned;
        public int summ { get; set; }
        public void Rolling()
        {
            Random rnd = new Random();
            List<string> slots = new List<string> { "1", "2", "3" };

            for (int i = 0; i < slots.Count; i++)
            {
                switch (rnd.Next(1, 4))
                {
                    case 1:
                        slots[i] = Result.gold.ToString();
                        break;
                    case 2:
                        slots[i] = Result.berry.ToString();
                        break;
                    case 3:
                        slots[i] = Result.x.ToString();
                        break;
                    default:
                        throw new Exception("Invalid cell number");
                }
            }

            bool result = (slots[0] == slots[1]&& slots[1] == slots[2]);
            if (result)
            {
                if (slots[0] == "gold") summ += 500;
                if (slots[0] == "berry") summ += 200;
                if (slots[0] == "x") summ -= 500;
            }
            else
            {
                if ((slots[0] != slots[1]) && (slots[1] != slots[2]) && (slots[0] != slots[2])) { summ -= 100; }
                else if ((slots[0] == slots[1]) && (slots[1] == "x")) summ -= 100;
                else if ((slots[0] == slots[2]) && (slots[2] == "x")) summ -= 100;
                else if ((slots[1] == slots[2]) && (slots[1] == "x")) summ -= 100;
                else { summ += 50; }
            }

            Spinned?.Invoke(this, new ResultEventArgs(slots, summ));

        }
    }

    public class ResultEventArgs: EventArgs
    {
        public List<string> result { get; }

        public int Summ { get; }

        public ResultEventArgs(List<string> res, int summ) { result = res; Summ = summ; }

    }
}
