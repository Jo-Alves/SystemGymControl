namespace Bussiness
{
    class ValidateEmail
    {
        public static bool Validate(string Email)
        {
            bool validate = false;
            int analyzed = Email.IndexOf("@");
            if (analyzed > 0)
            {
                if (Email.IndexOf("@", analyzed + 1) > 0)
                {
                    return validate;
                }
                int i = Email.IndexOf(".", analyzed);
                if (i - 1 > analyzed)
                {
                    if (i + 1 < Email.Length)
                    {
                        string r = Email.Substring(i + 1, 1);
                        if (r != ".")
                        {
                            validate = true;
                        }
                    }
                }
            }
            return validate;
        }
    }
}
