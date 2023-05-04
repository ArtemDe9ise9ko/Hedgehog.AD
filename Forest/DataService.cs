namespace Forest
{
    public class DataService
    {
        public static int[] GetHedgehogsCount(string? input)
        {
            try
            {
                if (Validator.SquareCheck(input) && Validator.HasSpaceAfterComas(input))
                {
                    int[] values = Converter.ConvertInputValues(input);

                    if (values.Length == 3 && Validator.CheckValues(values))
                    {
                        return values;
                    }
                }

                throw new ArgumentException();
            }
            catch 
            {
                HistoryTemplate.NoValidCounterHedgehogsInfo();
                input = Console.ReadLine()!;

                return GetHedgehogsCount(input);
            }
        }


        public static int GetMainHedgehogColor(string? input)
        {
            try
            {
                input = input!.Trim(' ');

                var number = Convert.ToInt32(input);

                if (number >= 0 && number <= 2)
                {
                    return number;
                }

                throw new ArgumentException();
            }
            catch
            {
                HistoryTemplate.NoValidMainHedgehogInfo();
                input = Console.ReadLine()!;

                return GetMainHedgehogColor(input);
            }
        }
    }
}
