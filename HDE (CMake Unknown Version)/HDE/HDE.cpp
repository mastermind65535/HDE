#include "HDE.h"

#include <iostream>
#include <fstream>
#include <string>
#include <map>
#include <vector>
#include <iomanip>
#include <sstream>

/*
|-------------------------|--------------------------|-----------------------|-----------------------|-----------------------|
[                                             EXECUTABLE FILE STRUCTURE BASED ON OS                                          ]
|-------------------------|--------------------------|-----------------------|-----------------------|-----------------------|
| Operating System        | Windows                  | Linux                 | Android               | iOS                   |
|-------------------------|--------------------------|-----------------------|-----------------------|-----------------------|
| Primary Header Type     | DOS MZ Header            | ELF Header            | ELF Header            | Mach-O Header         |
| Magic Number            | MZ (0x5A4D)              | \x7FELF               | \x7FELF               | 0xfeedface (32-bit)   |
|                         |                          |                       |                       | 0xfeedfacf (64-bit)   |
| Secondary Header Type   | PE Header                | Program Header Table  | DEX                   | Load Commands         |
| Secondary Signature     | PE\0\0                   | None                  | dex\0                 | None                  |
| Extensions              | .exe, .dll               | None, .out, .so       | .dex, .so, .apk       | .app, .dylib, .ipa    |
|-------------------------|--------------------------|-----------------------|-----------------------|-----------------------|



                          | MS-DOS Header            | ELF Header            |                       | Mach-O Header         |
                          |--------------------------|-----------------------|                       |-----------------------|
                          | File Header              | Program Header        |                       | Load Commands         |
                          |                          |                       |                       | Segment Command       |
                          |--------------------------|-----------------------|                       | Segment Sections      |
                          | Optional Header          | Section               |                       |-----------------------|
                          |                          | .interp               |                       | __TEXT Segment        |
                          |--------------------------| .init                 |                       | .text                 |
                          | Section Header           | .plt                  |                       | .cstring              |
                          |                          | .text    Code Section |                       | .literal4             |
                          |                          | .fini                 |                       |-----------------------|
                          |                          | .rodata               |                       | __DATA Segment        |
                          |--------------------------| .data                 |                       | .data                 |
                          | Section                  | .shstrtab             |                       | .bss                  |
                          | .text       Code Section |-----------------------|                       | .rodata               |
                          | .data                    | Section Header        |                       |-----------------------|
                          | .bss                     |                       |                       | __LINKEDIT Segment    |
                          | .rdata                   |                       |                       | .dynsym               |
                          | .idata                   |                       |                       | .dynstr               |
                          | .edata                   |-----------------------|                       | .symtab               |
                          | .reloc                   |                                               [ .strtab               ]
                          | .rsrc                    |                                               [-----------------------]
                          | .pdata                   |                                               [ __TEXT Executable Code]
                          | .tls                     |                                               [ .text                 ]
                          |--------------------------|                                               [ .literal4             ]
                                                                                                     [-----------------------]
                                                                                                     [ Other Segment         ]
                                                                                                     [ .debug                ]
                                                                                                     [ .const                ]
                                                                                                     [ .dtrace               ]
                                                                                                     [-----------------------]



*/

int main(int argc, char* argv[])
{
    std::vector<std::string> args(argv, argv + argc);
    std::string _TARGET = args[1];
	while (true) {
        std::string _cmd;
        std::cout << "HDE: [] >"; std::cin >> _cmd;
        std::cout << _cmd << std::endl;
	}
	return 0;
}
