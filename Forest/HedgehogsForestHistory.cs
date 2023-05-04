namespace Forest
{
    public class HedgehogsForestHistory
    {
        private int _mainHedgehogsColor;
        public void HistoryOfHedgehogs()
        {
            BeginningPart();
            MainPart();
            EndingPart();
        }
        private void BeginningPart()
        {
            Console.WriteLine("Це лiс новаторських їжачкiв!");
            Console.WriteLine("Кожен має свої погляди i думки...");
            Console.WriteLine("Комусь подобаються червонi яблука, а хтось полюбляє зеленi, майже як в людей.");
            HistoryTemplate.BeginningPartInfo();

            Console.WriteLine("Лiс великий i може вмiстити в собi їжакiв кожного погляду вiд 0 до 2 147 483 647.");
            Console.WriteLine("Важливо додати, що сума усiх їжакiв має бути мiж 1 до 2 147 483 647.");
            Console.WriteLine("Отже для початку треба встановити скiльки в лiсi їжакiв..");
        }
        private void MainPart()
        {
            HistoryTemplate.HedgehogsCounterInfo();
            int[] hedgehogsCount = DataService.GetHedgehogsCount(Console.ReadLine());

            HistoryTemplate.MainPartInfo();
            HistoryTemplate.SetMainColorHedgehogs();
            _mainHedgehogsColor = DataService.GetMainHedgehogColor(Console.ReadLine());

            IMeetingGround _meetingGround = new MeetingGround();
            _meetingGround.MeetingsCalculation(hedgehogsCount, _mainHedgehogsColor);
        }
        private void EndingPart()
        {
            HistoryTemplate.GetColorsState(_mainHedgehogsColor, out ColorState colorState);
            var meetingCounter = MeetingsInstance.GetInstance().GetMeetingCounter();

            Console.WriteLine();
            Console.WriteLine("Тепер усi їжаки в лiсi хочуть мати його погляди.");
            Console.Write($"Їм дуже цiкаво за скiльки зустрiчей усi їжаки будуть ");
            HistoryTemplate.ColorSwitcherByText(colorState.ColorMain, colorState.Main);
            Console.WriteLine($" кольору.");
            Console.Write($"Для цього їм потрiбно щоб їжачки ");
            HistoryTemplate.ColorSwitcherByText(colorState.ColorFirst, colorState.First);
            Console.Write(" i ");
            HistoryTemplate.ColorSwitcherByText(colorState.ColorSecond, colorState.Second);
            Console.WriteLine(" кольору зустрiлися i нiяк iнакше.");
            Console.WriteLine();

            if(meetingCounter == -1)
            {
                Console.WriteLine("Завдяки розрахункам вони зрозумiли що це неможливо, адже для цього не висатчило їжачкiв рiзних кольорiв...");
                Console.WriteLine("Наступного разу спробуйте використовувати кратнi числа 3.");
                Console.WriteLine();
                Console.Write("Їх прилад показав число: ");
                HistoryTemplate.ColorSwitcherByText(colorState.ColorMain, meetingCounter.ToString());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Плак-Плак. :(");
            }
            else
            {
                Console.WriteLine("Завдяки розрахункам вони зрозумiли що це цiлком можливо!!!");
                Console.WriteLine();
                Console.Write("Їх прилад показав число: ");
                HistoryTemplate.ColorSwitcherByText(colorState.ColorMain, meetingCounter.ToString());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Нарештi у їжакiв наступить гармонiя. :)");
            }

            Console.ReadKey();
        }
    }
}
