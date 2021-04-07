using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kupo
{
    /// <summary>
    /// Command Response Data
    /// </summary>
    public struct CmdResponse
    {
        /// <summary>
        /// what the player sees
        /// </summary>
        public string PlayerResponse { get; private set; }

        /// <summary>
        /// what game logs or server console sees
        /// </summary>
        public string ConsoleResponse { get; private set; }

        public object ExtraData { get; private set; }

    }
}
