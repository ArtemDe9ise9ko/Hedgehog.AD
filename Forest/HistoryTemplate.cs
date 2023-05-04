namespace Forest
{
    public class HistoryTemplate
    {
        public static void NoValidCounterHedgehogsInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Введено невiрне значення. Спробуйте ввести данi як у прикладi.");
            HedgehogsCounterInfo();
        }
        public static void NoValidMainHedgehogInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Введено невiрне значення. Вводити варто тiльки числа вiд 0 до 2.");
            SetMainColorHedgehogs();
        }
        public static void MainPartInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Аж раптом один їжак став поважним, a його погляди стали абсолютно новаторськими.");
            Console.WriteLine("У лiсi наближаються змiни..");
        }
        public static void BeginningPartInfo()
        {
            Console.Write("Але загалом їх можна роздiлити на ");
            ColorSwitcherByText(ConsoleColor.Red, "червоних");
            Console.Write(", ");
            ColorSwitcherByText(ConsoleColor.Green, "зелених");
            Console.Write(" та ");
            ColorSwitcherByText(ConsoleColor.Blue, "синiх");
            Console.Write(" за поглядами.");
            Console.WriteLine();
        }
        public static void SetMainColorHedgehogs()
        {
            Console.WriteLine();
            Console.WriteLine("Кольори мiстяться пiд числами:");
            Console.WriteLine();
            ColorSwitcherByText(ConsoleColor.Red, "Червоний - ");
            Console.WriteLine("0");
            ColorSwitcherByText(ConsoleColor.Green, "Зелений - ");
            Console.WriteLine("1");
            ColorSwitcherByText(ConsoleColor.Blue, "Синiй - ");
            Console.WriteLine("2");
            Console.WriteLine();
            Console.Write("Встанови номер кольору поважного їжачка: ");
        }

        public static void HedgehogsCounterInfo()
        {
            Console.WriteLine();
            Console.Write("Программа приймає кiлькiсть їжакiв у виглядi масиву, наприклад: ");
            Console.Write("[");
            ColorSwitcherByText(ConsoleColor.Red, "8");
            Console.Write(", ");
            ColorSwitcherByText(ConsoleColor.Green, "1");
            Console.Write(", ");
            ColorSwitcherByText(ConsoleColor.Blue, "9");
            Console.Write("]");
            Console.WriteLine();

            Console.Write("Означає ");
            ColorSwitcherByText(ConsoleColor.Red, "8 червоних");
            Console.Write(", ");
            ColorSwitcherByText(ConsoleColor.Green, "1 зелений");
            Console.Write(" i ");
            ColorSwitcherByText(ConsoleColor.Blue, "9 синiх");
            Console.WriteLine(" їжачкiв.");
            Console.WriteLine();
            Console.Write("Введiть кiлькiсть їжачкiв: ");
        }

        public static void GetColorsState(int mainHedgehogsColor, out ColorState colorState)
        {
            colorState = new ColorState();

            switch (mainHedgehogsColor)
            {
                case 0:
                    colorState.First = "зеленого";
                    colorState.Second = "синього";
                    colorState.Main = "червоного";
                    colorState.ColorFirst = ConsoleColor.Green;
                    colorState.ColorSecond = ConsoleColor.Blue;
                    colorState.ColorMain = ConsoleColor.Red;
                    break;
                case 1:
                    colorState.First = "червоного";
                    colorState.Second = "синього";
                    colorState.Main = "зеленого";
                    colorState.ColorFirst = ConsoleColor.Red;
                    colorState.ColorSecond = ConsoleColor.Blue;
                    colorState.ColorMain = ConsoleColor.Green;
                    break;
                case 2:
                    colorState.First = "червоного";
                    colorState.Second = "зеленого";
                    colorState.Main = "синього";
                    colorState.ColorFirst = ConsoleColor.Red;
                    colorState.ColorSecond = ConsoleColor.Green;
                    colorState.ColorMain = ConsoleColor.Blue;
                    break;
            }
        }

        public static void ColorSwitcherByText(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }
    }
}
