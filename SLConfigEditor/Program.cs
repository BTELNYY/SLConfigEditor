using Newtonsoft.Json;
using SLConfigEditor;

namespace SLConfigEditor
{
    public class Program
    {
        private static WebApplication? webApp = null;

        public static WebApplication WebApp
        {
            get
            {
                if(webApp == null)
                {
                    throw new InvalidOperationException("Web Application is not set!");
                }
                return webApp;
            }
        }

        public const string ConfigPath = "./config.json";

        private static AppConfig? appConfig = null;

        public static AppConfig Configuration
        {
            get
            {
                if(appConfig == null)
                {
                    WebApp.Logger.LogWarning("Config is null!");
                    Configuration = new AppConfig();
                    return new AppConfig();
                }
                return appConfig;
            }
            set
            {
                AppConfig appliedValue = value;
                if(value == null)
                {
                    appliedValue = new AppConfig();
                }
                appConfig = appliedValue;
                string json = JsonConvert.SerializeObject(value);
                if (File.Exists(ConfigPath))
                {
                    File.Delete(ConfigPath);
                }
                File.WriteAllText(ConfigPath, json);
            }
        }

        public static AppConfig LoadAppConfig()
        {
            if(!File.Exists(ConfigPath))
            {
                AppConfig? config = JsonConvert.DeserializeObject<AppConfig>(File.ReadAllText(ConfigPath));
                if(config == null)
                {
                    Configuration = new AppConfig();
                }
                return Configuration;
            }
            Configuration = new AppConfig();
            return Configuration;
        }

        public static void Main(string[] args)
        {
            LoadAppConfig();
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            webApp = app;
            DataManager.Init();
            app.MapGet("/", () => "Hello World!");
            app.Run();
        }
    }
}