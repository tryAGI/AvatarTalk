/*
order: 10
title: Video Generation
slug: video-generation

Basic example showing how to create a client and generate an avatar video from text.
*/

namespace AvatarTalk.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GenerateVideo()
    {
        //// Create an AvatarTalk client using your API key.
        using var client = GetAuthenticatedClient();

        //// Generate a lip-synced avatar video from text.
        var response = await client.GenerateVideoAsync(
            text: "Hello, welcome to AvatarTalk!",
            avatar: AvatarName.EuropeanMan,
            emotion: Emotion.Happy,
            language: Language.En);

        response.Should().NotBeNull();
        response.Status.Should().NotBeNullOrEmpty();
        response.Mp4Url.Should().NotBeNullOrEmpty();
    }
}
