using Discord.Commands;
using System.Threading.Tasks;

namespace $safeprojectname$.Modules
{
    [Group("groupname_changethis")]
    public class $safeitemname$ : ModuleBase<SocketCommandContext>
    {
        [Command]  // default command
        public async Task DefaultAsync()
            => await ReplyAsync("This is the default command for this group.");

        [Command("help")]
        public async Task HelpAsync()
            => await ReplyAsync("Help string for this command.");
    }
}
