namespace LibrarySystem.Application.Validators.Helper
{
    public static class ValidatorsHelper
    {
        internal static bool IsAlphaOnly(string input)
        {
            return !string.IsNullOrEmpty(input) && input.All(char.IsLetter);
        }

        internal static bool IsValidISBN(string isbn)
        {
            isbn = isbn.Replace(" ", "").Replace("-", "");

            if (isbn.Length == 10 || isbn.Length == 13)
            {
                if (isbn.All(char.IsDigit))
                {
                    if (isbn.Length == 10)
                    {
                        int sum = 0;
                        for (int i = 0; i < 9; i++)
                        {
                            sum += (i + 1) * int.Parse(isbn[i].ToString());
                        }

                        int remainder = sum % 11;
                        int checkDigit = (11 - remainder) % 11;

                        return checkDigit == int.Parse(isbn[9].ToString()) || (isbn[9] == 'X' && remainder == 1);
                    }
                    else if (isbn.Length == 13)
                    {
                        int sum = 0;
                        for (int i = 0; i < 12; i++)
                        {
                            sum += (i % 2 == 0 ? 1 : 3) * int.Parse(isbn[i].ToString());
                        }

                        int checkDigit = (10 - (sum % 10)) % 10;

                        return checkDigit == int.Parse(isbn[12].ToString());
                    }
                }
            }

            return false;
        }

        internal static bool IsValidPublicationYear(int year) => year >= 1900 && year <= DateTime.Now.Year;
        
    }
}
