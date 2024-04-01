namespace SLConfigEditor
{
    public class BanDetails
    {
        public override string ToString()
        {
            return string.Concat(new string[]
            {
            OriginalName.Replace(";", ":"),
            ";",
            Id.Replace(";", ":"),
            ";",
            Convert.ToString(this.Expires),
            ";",
            Reason.Replace(";", ":"),
            ";",
            Issuer.Replace(";", ":"),
            ";",
            Convert.ToString(this.IssuanceTime)
            });
        }

        public void Deserialize(string str)
        {
            string[] strs = str.Split(";");
            OriginalName = strs[0];
            Id = strs[1];
            Expires = Convert.ToInt64(strs[2]);
            Reason = strs[3];
            Issuer = strs[4];
            IssuanceTime = Convert.ToInt64(strs[5]);
        }

        public string OriginalName { get; set; } = "";

        public string Id { get; set; } = "";

        public long Expires { get; set; }

        public string Reason { get; set; } = "";

        public string Issuer { get; set; } = "";

        public long IssuanceTime { get; set; }
    }
}