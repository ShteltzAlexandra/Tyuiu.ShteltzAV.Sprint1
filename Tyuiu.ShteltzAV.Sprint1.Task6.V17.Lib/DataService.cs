using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShteltzAV.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            if (string.IsNullOrEmpty(value))
            { 
                return false; 
            }

            value = value.Replace(" ", "");
            value = value.ToLower();
            string reversed = new string(value.Reverse().ToArray());

            if (reversed == value)
            {
                return true;

            }

            else
            {
                return false;
            }


        }
    }
}
