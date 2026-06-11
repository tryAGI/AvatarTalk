#nullable enable

using System.CommandLine;

namespace AvatarTalk.CLI.Commands;

internal static class DefaultApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"default", @"default endpoint commands.");
                         command.Subcommands.Add(CreateLiveKitSessionCommandApiCommand.Create());
                         command.Subcommands.Add(DeleteLiveKitSessionCommandApiCommand.Create());
                         command.Subcommands.Add(GenerateLightningVideoCommandApiCommand.Create());
                         command.Subcommands.Add(GenerateVideoCommandApiCommand.Create());
                         command.Subcommands.Add(GetPaymentStatusCommandApiCommand.Create());
                         command.Subcommands.Add(ListPaymentsCommandApiCommand.Create());
                         command.Subcommands.Add(RequestVideoByAudioCommandApiCommand.Create());
                         command.Subcommands.Add(RequestVideoByTextCommandApiCommand.Create());
        return command;
    }
}