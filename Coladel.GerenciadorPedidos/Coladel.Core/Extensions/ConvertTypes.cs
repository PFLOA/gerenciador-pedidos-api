namespace A4S.Core.Extensions
{
    public static class ConvertTypes
    {
        public static decimal ToDecimal(this string valor)
        {
            decimal res = 0;

            if (decimal.TryParse(valor, out res))
            {
                return res;
            }

            return res;
        }

        public static decimal ToInteiro(this string valor)
        {
            int res = 0;

            if (int.TryParse(valor, out res))
            {
                return res;
            }

            return res;
        }
    }
}
