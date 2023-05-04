namespace Forest
{
    public class MeetingsInstance
    {
        private static MeetingsInstance _instance = null!;
        private int MeetingCounter { get; set; }
        public static MeetingsInstance GetInstance()
        {
            return _instance == null ? _instance = new MeetingsInstance() : _instance;
        }
        public int GetMeetingCounter()
        {
            return MeetingCounter;
        }
        public void SetMeetingCounter(int meetingCounter)
        {
            MeetingCounter = meetingCounter;
        }
    }
}
