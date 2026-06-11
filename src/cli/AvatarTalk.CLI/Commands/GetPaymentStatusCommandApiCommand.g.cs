#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AvatarTalk.CLI.Commands;

internal static partial class GetPaymentStatusCommandApiCommand
{
    private static Argument<string> Invoice { get; } = new(
        name: @"invoice")
    {
        Description = @"The Lightning invoice string to check",
    };

                    private static string FormatResponse(ParseResult parseResult, global::AvatarTalk.PaymentStatusResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AvatarTalk.PaymentStatusResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-payment-status", @"Check Lightning payment status
Check the payment status of a Lightning Network invoice.
");
                        command.Arguments.Add(Invoice);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var invoice = parseResult.GetRequiredValue(Invoice);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetPaymentStatusAsync(
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