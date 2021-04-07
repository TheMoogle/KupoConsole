
namespace Kupo
{
    /// <summary>
    /// Console Implementation
    /// </summary>
    public interface IConsole
    {
        /// <summary>
        /// Registers Command into the Console
        /// </summary>
        /// <param name="command">The Command</param>
        void RegisterCommand(IConsoleCommand command);

        /// <summary>
        /// Fuction for either sending command to server or executing
        /// </summary>
        /// <param name="Command">Command Text</param>
        void ProcessCommand(string Command);
    }
}
