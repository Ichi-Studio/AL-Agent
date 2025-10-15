namespace ConsoleAppTest
{
    public class AppSettings
    {

        public AiConfig? AIConfig { get; set; }

    }

    public class AiConfig
    {
        public string? ApiKey { get; set; }

        public string? ModelId  { get; set; }

        public string? BaseUrl { get; set; }

    }
}
