namespace Forest
{
    public class Converter
    {
        public static int[] ConvertInputValues(string? value)
        {
            return value!.Trim('[', ']', ' ').Split(',').Select(s => int.Parse(s.Trim())).ToArray();
        }
    }
}
