namespace Forest
{
    public class MeetingGround : IMeetingGround
    {
        public void MeetingsCalculation(int[] hedgehogsCount, int mainHedgehogsColor)
        {
            if(Validator.ZeroCheck(hedgehogsCount))
            {
                MeetingsInstance.GetInstance().SetMeetingCounter(-1);
                return;
            }

            var reds = hedgehogsCount[0];
            var greens = hedgehogsCount[1];
            var blues = hedgehogsCount[2];

            switch (mainHedgehogsColor)
            {
                case 0:
                    Мeeting(greens, blues);
                    break;
                case 1:
                    Мeeting(reds, blues);
                    break;
                case 2:
                    Мeeting(reds, greens);
                    break;
            }
        }
        private void Мeeting(int firstGroup, int secondGroup)
        {
            if(firstGroup == secondGroup)
            {
                MeetingsInstance.GetInstance().SetMeetingCounter(firstGroup);
                return;
            }
            if(firstGroup > secondGroup) 
            {
                var remainingHedgehogs = firstGroup-secondGroup;

                if(!Validator.IsMultipleOfThree(remainingHedgehogs))
                {
                    MeetingsInstance.GetInstance().SetMeetingCounter(-1);
                    return;
                } 

                MeetingsInstance.GetInstance().SetMeetingCounter(secondGroup + remainingHedgehogs);
                return;
            }
            if(secondGroup > firstGroup)
            {
                var remainingHedgehogs = secondGroup-firstGroup;

                if(!Validator.IsMultipleOfThree(remainingHedgehogs))
                {
                    MeetingsInstance.GetInstance().SetMeetingCounter(-1);
                    return;
                }

                MeetingsInstance.GetInstance().SetMeetingCounter(firstGroup + remainingHedgehogs);
                return;
            }
        }
    }
    public interface IMeetingGround
    {
        void MeetingsCalculation(int[] hedgehogsCount, int mainHedgehogsColor);
    }
}
