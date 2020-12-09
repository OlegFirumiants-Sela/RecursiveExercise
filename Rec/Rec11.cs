using System.Text;

namespace Rec
{
    public class Rec11
    {
        public string RunRec(string number, char num1, char num2)
        {
            if (number.Length < 2)
                return number;
            if (number[0] == num1 && number[1] == num2)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(num2);
                sb.Append(num1);
                sb.Append(number.Substring(2));
                number = sb.ToString();
            }
            else if (number[0] == num2 && number[1] == num1)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(num1);
                sb.Append(num2);
                sb.Append(number.Substring(2));
                number = sb.ToString();
            }
            return number[0] + RunRec(number.Substring(1), num1, num2);
        }
    }
}
