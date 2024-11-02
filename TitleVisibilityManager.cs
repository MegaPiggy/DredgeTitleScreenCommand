using CommandTerminal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TitleScreenCommand
{
    public class TitleVisibilityManager : MonoBehaviour
    {
        public GameObject titleScreenObject;

        private void Awake()
        {
            AddTerminalCommands();
        }

        private void OnDestroy()
        {
            RemoveTerminalCommands();
        }

        private void AddTerminalCommands()
        {
            if (Terminal.Shell != null)
            {
                Terminal.Shell.AddCommand("title", ToggleUI, 1, 1, "'title 0' turns the title ui off, 'title 1' turns the title ui back on");
            }
        }

        private void RemoveTerminalCommands()
        {
            if (Terminal.Shell != null)
            {
                Terminal.Shell.RemoveCommand("title");
            }
        }

        private void ToggleUI(CommandArg[] args)
        {
            bool visible = args[0].Int == 1;
            titleScreenObject.SetActive(visible);
        }
    }
}
