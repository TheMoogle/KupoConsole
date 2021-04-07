using UnityEngine;
using System.Collections.Generic;

namespace Kupo
{
    /// <summary>
    /// Interface for console Command
    /// </summary>
    public interface IConsoleCommand
    {
        /// <summary>
        /// Permmsions required to use
        /// </summary>
        List<string> Permissions { get; }

        /// <summary>
        /// Command Name you type into Console.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Description of what the Command does.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// If command shows up or is autofilled.
        /// </summary>
        bool Hidden { get; }

        /// <summary>
        /// Invokes the Command
        /// </summary>
        /// <param name="invoker">Object that invoked the Command.</param>
        /// <param name="args">Arguments that the command uses.</param>
        /// <param name="output">Data the Command Returns</param>
        void Invoke<T>(T invoker, string[] args, out CmdResponse output);
    }
}
