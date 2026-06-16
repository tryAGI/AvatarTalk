#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AvatarTalk.CLI.Commands;

internal static partial class CreateLiveKitSessionCommandApiCommand
{
    private static Option<global::AvatarTalk.AvatarName> Avatar { get; } = new(
        name: @"--avatar")
    {
        Description = @"Available avatar characters. Each avatar represents a different
person with distinct appearance and demographics.
",
        Required = true,
    };

    private static Option<global::AvatarTalk.Emotion?> Emotion { get; } = new(
        name: @"--emotion")
    {
        Description = @"Emotion state for the avatar. Controls facial expression during speech.
",
    };

    private static Option<global::AvatarTalk.Language?> Language { get; } = new(
        name: @"--language")
    {
        Description = @"Language code for text-to-speech. Determines the voice language
and pronunciation used for generating the avatar's speech.
",
    };
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

                    private static string FormatResponse(ParseResult parseResult, global::AvatarTalk.LiveKitSessionResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AvatarTalk.LiveKitSessionResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-live-kit-session", @"Create a LiveKit avatar session
Creates a new LiveKit session for real-time avatar interaction.
Returns session details including a participant token for joining the LiveKit room.
");
                        command.Options.Add(Avatar);
                        command.Options.Add(Emotion);
                        command.Options.Add(Language);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AvatarTalk.CreateLiveKitSessionRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AvatarTalk.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var avatar = parseResult.GetRequiredValue(Avatar);
                        var emotion = CliRuntime.WasSpecified(parseResult, Emotion) ? parseResult.GetValue(Emotion) : (__requestBase is { } __EmotionBaseValue ? __EmotionBaseValue.Emotion : default);
                        var language = CliRuntime.WasSpecified(parseResult, Language) ? parseResult.GetValue(Language) : (__requestBase is { } __LanguageBaseValue ? __LanguageBaseValue.Language : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateLiveKitSessionAsync(
                                    avatar: avatar,
                                    emotion: emotion,
                                    language: language,
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