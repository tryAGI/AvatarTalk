#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AvatarTalk.CLI.Commands;

internal static partial class GenerateLightningVideoCommandApiCommand
{
    private static Option<string> Invoice { get; } = new(
        name: @"--invoice")
    {
        Description = @"The Lightning invoice that has been paid",
        Required = true,
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
        var command = new Command(@"generate-lightning-video", @"Generate video after Lightning payment
Generate the avatar video after a Lightning Network invoice has been paid.
Use the invoice from the request-video endpoint.
");
                        command.Options.Add(Invoice);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var invoice = parseResult.GetRequiredValue(Invoice);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GenerateLightningVideoAsync(
                                    invoice: invoice,
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