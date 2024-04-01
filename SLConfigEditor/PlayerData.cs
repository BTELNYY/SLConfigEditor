namespace SLConfigEditor
{
    public class Player
    {
        public string ID { get; set; } = "";

        public bool IsIP { get; set; } = false;

        public MuteType Muted { get; set; } = MuteType.None;

        public bool IsBanned { get; set; } = false;

        public BanDetails? IDBanDetails { get; set; }

        public BanDetails? IPBanDetails { get; set; }

        public void PardonBan()
        {

        }

        public void PardonMute()
        {

        }

        public void Ban(string reason, long until)
        {

        }

        public void Mute(MuteType type)
        {

        }
    }

    public enum MuteType
    {
        None,
        Intercom,
        All
    }
}
