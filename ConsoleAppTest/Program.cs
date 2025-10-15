//配置适配兼容OpenAI 服务
var appSettings = new AppSettings();

var apiKey = new ApiKeyCredential(appSettings.AIConfig?.ApiKey!);

var endPoint = new OpenAIClientOptions { Endpoint = new Uri(appSettings.AIConfig?.BaseUrl!) };

string? Instructions = "你是一名拥有丰富实战经验的 Microsoft Dynamics 365 Business Central 专家，熟悉其核心模块、配置、开发与最佳实践。";

string? agentName = "Zer0";


//创建Agent
AIAgent agent = new OpenAIClient(apiKey,endPoint).GetChatClient(appSettings.AIConfig?.BaseUrl).CreateAIAgent(Instructions,agentName);


//创建对话线程
var thread = agent.GetNewThread();

