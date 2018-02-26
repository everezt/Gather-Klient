using System.Text.RegularExpressions;


namespace Gather_Klient
{
    public class text_checker
    {
        public bool is_text_aZ09(string data)
        {
            Match match = Regex.Match(data, @"^[A-Za-z0-9]+$",
            RegexOptions.IgnoreCase);

            return match.Success;
        }

        public bool is_email(string data)
        {
            Match match = Regex.Match(data, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
            + "@"
            + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$",
            RegexOptions.IgnoreCase);

            return match.Success;
        }


        public bool is_empty(string data)
        {
            if (data == "")
                return true;
            else
                return false;
        }
    }
}
