using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

namespace Kupo
{
    public class KupoConsole : MonoBehaviour, IConsole
    {
        private List<IConsoleCommand> consoleCommands = new List<IConsoleCommand>();

        public InputField InputField;

        public void ProcessCommand(string Command)
        {
            var input = Command;
            InputField.text = "";

            var textSplit = input.Split(' ');

            var h = new string[textSplit.Length - 1];
            for (int i = 0; i < h.Length; i++)
            {
                if (i != 0)
                {
                    h[i - 1] = textSplit[i];
                }
            }


            foreach (var cmd in consoleCommands)
            {
                if (cmd.Name == textSplit[0])
                {
                    cmd.Invoke(this.gameObject, h, out var data);
                }
            }

            Debug.Log("COMMAND GO BRRRRRRRR");

        }

        public void RegisterCommand(IConsoleCommand command)
        {
            consoleCommands.Add(command);
        }

        void Start()
        {
        
        }


        void Update()
        {
        
        }
    }
}
