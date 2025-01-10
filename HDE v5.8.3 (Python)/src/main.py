from Engine import Windows
from Engine import Linux
from Engine import Android
from Engine import MacOS
from Engine import iOS

from Arch import x86
from Arch import x64
from Arch import arm
from Arch import arm64

import traceback
import os
import sys

__extar = None
__tname = None
Local_Version = "5.8.3"

settings = {}

class DefaultSetting:
    def __init__(self):
        self.Settings = {
        }
        self.run()
    def run(self):
        for setting in self.Settings:
            settings[setting] = self.Settings[setting]

class Shell:
    class ex:
        def load(*args):
            if len(args) > 0 and args[0] == "help":
                return '''Set local variable'''
            try:
                target = str(args[0])
                if not os.path.exists(target):
                    print(f"[-] Executable file not found: {target}")
                    return
                target = target.replace("\\", "/")
                __extar = target
                __tname = target.split("/")[-1]
                print(f"[+] Executable file loaded: {target}")
            except:
                raise
    
    class var:
        def set(*args):
            if len(args) > 0 and args[0] == "help":
                return '''Set local variable'''
            try:
                target = str(args[0])
                value = str(args[1])
                if target in settings:
                    old = settings[target]
                    settings[target] = value
                    print(f"[+] Variable successfully changed: {old} --> {value}")
                elif not target in settings:
                    print(f"[-] Variable change failed: variable not exists")
                else:
                    print(f"[-] Variable change failed: Unknown")
            except:
                raise
        def print(*args):
            if len(args) > 0 and args[0] == "help":
                return '''print local variable. Type 'all' to see all local variables'''
            try:
                target = str(args[0])
                if target in settings:
                    print(f"{target}{' ' * (32 - len(str(target)))}: {settings[target]}")
                elif target == "all":
                    for key in settings:
                        print(f"{key}{' ' * (32 - len(str(key)))}: {settings[key]}")
                elif not target in settings:
                    print(f"[-] Variable print failed: variable not exists")
                else:
                    print(f"[-] Variable print failed: Unknown")
            except:
                raise
        def reset(*args):
            if len(args) > 0 and args[0] == "help":
                return '''Reset local variables'''
            DefaultSetting()

class Handler:
    def __init__(self, command):
        self.COMMAND = str(command)
        self.ObjectSplit = "."
        self.ArgumentsSplit = " "
        self.arguments = []
        self.object = Shell
    def execute(self):
        Type = self.COMMAND.split(self.ObjectSplit)[0]
        Func = self.COMMAND.split(self.ObjectSplit)[1].split(self.ArgumentsSplit)[0]
        arguments = self.COMMAND.split(self.ArgumentsSplit)[1:]
        getattr(getattr(self.object, Type), Func)(*arguments)

if __name__ == "__main__":
    DefaultSetting()
    while True:
        try:
            command = str(input(f"HDE: [{__tname}] > "))
            if command == "clear" or command == "cls":
                os.system("cls" if os.name == "nt" else "clear")
            elif command == "exit":
                break
            elif command == "help":
                for Type in Shell.__dict__:
                    if not Type.startswith("__"):
                        print(f"[{Type}]")
                        commands = getattr(Shell, Type).__dict__
                        tabSize = max(len(key) for key in commands.keys()) + 15
                        for func in commands:
                            if not func.startswith("__"):
                                print(f"{Type}.{func}{' ' * (tabSize - len(f'{Type}.{func}'))}{getattr(getattr(Shell, Type), func)('help')}")
                        print()
            else:
                obj = Handler(command=command)
                obj.execute()
        except:
            print(f"{traceback.format_exc()}")