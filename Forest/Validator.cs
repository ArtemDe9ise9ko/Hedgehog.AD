namespace Forest
{
    public class Validator
    {
        public static bool HasSpaceAfterComas(string? value)
        {
            return value!.Contains(", ") && value.Where(x => char.IsWhiteSpace(x)).Count() == 2;
        }
        public static bool CheckValues(int[] hedgehogs)
        {
            return !hedgehogs.Any(x => x < Int32.MaxValue && x < 0) && hedgehogs.Sum(i => (long)i) <= int.MaxValue && hedgehogs.Sum(i => (long)i) >= 1;
        }
        public static bool SquareCheck(string? value)
        {
            return value!.StartsWith("[") && value.EndsWith("]") && value.Count(c => c == '[') == 1 && value.Count(c => c == '[') == 1;
        }
        public static bool ZeroCheck(int[] hedgehogsCount)
        {
            return hedgehogsCount[0] == 0 && hedgehogsCount[1] == 0 || hedgehogsCount[0] == 0 && hedgehogsCount[2] == 0 || hedgehogsCount[1] == 0 && hedgehogsCount[2] == 0;
        }
        public static bool IsMultipleOfThree(int number)
        {
            return (number % 3 == 0);
        }
    }
}
