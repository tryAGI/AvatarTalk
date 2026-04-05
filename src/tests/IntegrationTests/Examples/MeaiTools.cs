/*
order: 20
title: MEAI Tools
slug: meai-tools

Using AvatarTalk as AIFunction tools with any Microsoft.Extensions.AI IChatClient.
*/

namespace AvatarTalk.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_CreateTools()
    {
        using var client = GetAuthenticatedClient();

        //// Create AIFunction tools from the AvatarTalk client.
        var generateVideoTool = client.AsGenerateVideoTool();
        var createSessionTool = client.AsCreateLiveKitSessionTool();
        var deleteSessionTool = client.AsDeleteLiveKitSessionTool();
        var paymentStatusTool = client.AsGetPaymentStatusTool();

        //// Verify all tools are created with the expected names.
        generateVideoTool.Name.Should().Be("AvatarTalk_GenerateVideo");
        createSessionTool.Name.Should().Be("AvatarTalk_CreateLiveKitSession");
        deleteSessionTool.Name.Should().Be("AvatarTalk_DeleteLiveKitSession");
        paymentStatusTool.Name.Should().Be("AvatarTalk_GetPaymentStatus");

        //// These tools can be passed to any IChatClient for function calling.
        var tools = new[] { generateVideoTool, createSessionTool, deleteSessionTool, paymentStatusTool };
        tools.Should().HaveCount(4);
    }
}
