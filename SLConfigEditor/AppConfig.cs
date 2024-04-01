namespace SLConfigEditor
{
    public class AppConfig
    {
        public string ConfigPath { get; set; } = "./";

        public string[] BannedNames { get; set; } = { };

        public string AutoBanAuditID { get; set; } = "";
    }
}