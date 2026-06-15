#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AvatarTalk.CLI.Commands;

internal static partial class RequestVideoByTextCommandApiCommand
{
    private static Option<string> Text { get; } = new(
        name: @"--text")
    {
        Description = @"The text for the avatar to speak",
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

                    private static string FormatResponse(ParseResult parseResult, global::AvatarTalk.LightningInvoiceResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AvatarTalk.LightningInvoiceResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"request-video-by-text", @"Request video via Lightning Network (text)
Request an avatar video generation using Bitcoin Lightning Network payment.
Provide text to generate a Lightning invoice for payment.
");
                        command.Options.Add(Text);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AvatarTalk.LightningTextRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AvatarTalk.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var text = parseResult.GetRequiredValue(Text);
                        var avatar = parseResult.GetRequiredValue(Avatar);
                        var emotion = parseResult.GetRequiredValue(Emotion);
                        var language = CliRuntime.WasSpecified(parseResult, Language) ? parseResult.GetValue(Language) : (__requestBase is { } __LanguageBaseValue ? __LanguageBaseValue.Language : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.RequestVideoByTextAsync(
                                    text: text,
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