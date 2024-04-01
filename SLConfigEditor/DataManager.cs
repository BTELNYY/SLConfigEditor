namespace SLConfigEditor
{
    public static class DataManager
    {
        public static string FilePath { get; private set; } = "";

        public const string IpBanFile = "IpBans.txt";

        public const string IdBanFile = "UserIdBans.txt";

        public const string MuteFile = "mutes.txt";

        public static void Init()
        {
            FilePath = Program.Configuration.ConfigPath;
            if(!File.Exists(FilePath + IpBanFile)) 
            {
                Program.WebApp.Logger.LogError("Can't find IPBan file.");
            }
            if(!File.Exists(FilePath + IdBanFile))
            {
                Program.WebApp.Logger.LogError("Can't find ID Ban file.");
            }
            if(!File.Exists(FilePath + MuteFile))
            {
                Program.WebApp.Logger.LogError("Can't find mute file.");
            }
        }
    }
}
