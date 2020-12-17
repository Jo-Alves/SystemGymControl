namespace SystemGymControl
{
    class FormatValueDecimal
    {
        // A função RemoveDollarSignGetValue() remover o Cifrão e retorna somente o valor

        public static string RemoveDollarSignGetValue(string value)
        {
            int lenghtValue = value.Length;
            return value.Substring(3, lenghtValue - 3);
        }
    }
}
