using System.Collections.Generic;

namespace Kupo
{
    /// <summary>
    /// Player Information, this is mostly for game servers
    /// </summary>
    /// <typeparam name="T">Player Type</typeparam>
    public interface IPlayerInfo<T>
    {
        /// <summary>
        /// Player Object
        /// </summary>
        T playerObject { get; }

        /// <summary>
        /// Player Permmissions
        /// </summary>
        List<string> Permissions { get; }
    }
}
