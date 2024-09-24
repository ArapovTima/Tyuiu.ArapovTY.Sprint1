using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ArapovTY.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        {
            string res = "";
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == ' ')
                    res = res + value[i-1];
            }
            res = res + value[value.Length - 1];
            return res;
        }
    }
}
