#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AvatarTalk.CLI.Commands;

internal static partial class GenerateVideoCommandApiCommand
{
    private static Option<global::AvatarTalk.GenerateVideoStream?> Stream { get; } = new(
        name: @"--stream")
    {
        Description = @"When set to ""true"", returns a streaming MP4 video response instead of JSON.
The response Content-Type will be video/mp4.
",
    };

    private static Option<string> Text { get; } = new(
        name: @"--text")
    {
        Description = @"The text for the avatar to speak. Will be converted to speech using TTS.",
        Required = true,
    };

    private static Option<global::AvatarTalk.AvatarName> Avatar { get; } = new(
        name: @"--avatar")
    {
        Description = @"Available avatar characters. Each avatar represents a different
person with distinct appearance and demographics.
",
        Required = true,
    };

    private static Option<global::AvatarTalk.Emotion> Emotion { get; } = new(
        name: @"--emotion")
    {
        Description = @"Emotion state for the avatar. Controls facial expression during speech.
",
        Required = true,
    };

    private static Option<global::AvatarTalk.Language?> Language { get; } = new(
        name: @"--language")
    {
        Description = @"Language code for text-to-speech. Determines the voice language
and pronunciation used for generating the avatar's speech.
",
    };

    private static Option<bool?> Delayed { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--delayed",
        description: @"When true, the request is processed asynchronously.
The response will include a task ID for polling the result.
");
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::AvatarTalk.InferenceResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AvatarTalk.InferenceResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"generate-video", @"Generate avatar video
Generate a lip-synced avatar video from text. The API uses text-to-speech
to create audio and synchronizes avatar lip movements with the generated audio.
Standard requests return a JSON response with video URLs.
Set the stream query parameter to true for streaming MP4 video response.
");
                        command.Options.Add(Stream);
                        command.Options.Add(Text);
                        command.Options.Add(Avatar);
                        command.Options.Add(Emotion);
                        command.Options.Add(Language);
                        command.Options.Add(Delayed);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AvatarTalk.InferenceRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AvatarTalk.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var stream = parseResult.GetValue(Stream);
                        var text = parseResult.GetRequiredValue(Text);
                        var avatar = parseResult.GetRequiredValue(Avatar);
                        var emotion = parseResult.GetRequiredValue(Emotion);
                        var language = CliRuntime.WasSpecified(parseResult, Language) ? parseResult.GetValue(Language) : __requestBase is not null ? __requestBase.Language : default;
                        var delayed = CliRuntime.WasSpecified(parseResult, Delayed) ? parseResult.GetValue(Delayed) : __requestBase is not null ? __requestBase.Delayed : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GenerateVideoAsync(
                                    stream: stream,
                                    text: text,
                                    avatar: avatar,
                                    emotion: emotion,
                                    language: language,
                                    delayed: delayed,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::AvatarTalk.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}