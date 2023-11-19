using System.Text.RegularExpressions;

namespace Submission_of_Applications_Тепляков.Classes
{
    public class CheckRegex
    {
        public static bool Match(string Pattern, string Input)
        {
            Match m = Regex.Match(Input, Pattern);
            return m.Success;
        }
    }
}
