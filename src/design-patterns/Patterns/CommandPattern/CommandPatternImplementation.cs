using design_patterns.Patterns.CommandPattern.Abstract;
using design_patterns.Patterns.CommandPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.CommandPattern
{
    public static class CommandPatternImplementation
    {
        public static void Run()
        {
            Light light = new Light();
            ICommand lightOnCommand = new LightOnCommand(light);
            ICommand lightOffCommand = new LightOffCommand(light);

            GarageDoor garageDoor = new GarageDoor();
            ICommand garagaDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);
            ICommand garageDoorCloseCommand = new GarageDoorCloseCommand(garageDoor);

            SingleRemoteControl remoteControl = new SingleRemoteControl();
            remoteControl.SetCommand(0, lightOnCommand, lightOffCommand);
            remoteControl.SetCommand(1, garagaDoorOpenCommand, garageDoorCloseCommand);

            remoteControl.OnButtonWasPressed(0);
            remoteControl.OnButtonWasPressed(1);
            remoteControl.Undo();
            remoteControl.OffButtonWasPressed(0);

            MacroCommand macroOnCommand = new MacroCommand(new List<ICommand> { new LightOnCommand(light), new GarageDoorCloseCommand(garageDoor) });
            MacroCommand macroOffCommand = new MacroCommand(new List<ICommand> { new LightOffCommand(light), new GarageDoorOpenCommand(garageDoor) });
            remoteControl.SetCommand(2, macroOnCommand, macroOffCommand);
            remoteControl.OnButtonWasPressed(2);
        }
    }
}
