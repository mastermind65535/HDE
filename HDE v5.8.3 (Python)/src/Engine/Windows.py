import pefile

class WindowsEngine:
    def __init__(self, __file:str):
        self.__EXTAR = str(__file)
        self.__EXOBJ = pefile.PE(self.__EXTAR)

    def parse_DOS(self): return self.__EXOBJ.DOS_HEADER.dump_dict()
    def parse_NT(self): return self.__EXOBJ.NT_HEADERS.dump_dict()
    def parse_File(self): return self.__EXOBJ.FILE_HEADER.dump_dict()
    def parse_Optional(self): return self.__EXOBJ.OPTIONAL_HEADER.dump_dict()