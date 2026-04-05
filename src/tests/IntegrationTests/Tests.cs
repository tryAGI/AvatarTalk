namespace AvatarTalk.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static AvatarTalkClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("AVATARTALK_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("AVATARTALK_API_KEY environment variable is not found.");

        var client = new AvatarTalkClient(apiKey);
        
        return client;
    }
}
