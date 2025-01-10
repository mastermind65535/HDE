# Source Generated with Decompyle++
# File: SocketProxy.pyc (Python 3.11)

from socket import *
from threading import Thread
from argparse import ArgumentParser
import time
import logging
import traceback
import os
if not os.path.exists('logs'):
    os.mkdir('logs')
ERROR_PAGE = '\n<!DOCTYPE html>\n<html>\n<head>\n    <title>Server Error</title>\n</head>\n<style>\n    p {\n        margin: 25px;\n    }\n    pre {\n        margin: 25px;\n    }\n</style>\n<body style="background-color:red;color:white;">\n    <h1>Server Error</h1>\n    <p>This Page is created by proxy server.</p>\n    <p>Your proxy server encountered a <u>critical error</u> while connecting to the remote server.</p>\n    <p>Please contact the proxy manager for assistance.</p>\n    <p>If the issue are not fixed, Pleaes type the url manually.</p>\n    <p>Error Message:</p>\n    <pre>{error_message}</pre>\n</body>\n</html>\n'
logging.basicConfig(level = logging.INFO, format = '%(asctime)s\t%(levelname)s - %(message)s')
logger = logging.getLogger('SocketProxy')
logger.setLevel(logging.INFO)
FILE_LOGGER = logging.FileHandler(f'''logs/{time.strftime('%Y-%m-%d-%H-%M')}.Log''')
FILE_LOGGER.setLevel(logging.INFO)
FILE_LOGGER.setFormatter(logging.Formatter('%(asctime)s - %(name)s - %(levelname)s - %(message)s'))
CONSOLE_LOGGER = logging.StreamHandler()
CONSOLE_LOGGER.setLevel(logging.INFO)
CONSOLE_LOGGER.setFormatter(logging.Formatter('%(asctime)s - %(name)s - %(levelname)s - %(message)s'))
logger.addHandler(FILE_LOGGER)
logger.addHandler(CONSOLE_LOGGER)

class SocketVPN:
    
    def __init__(self = None, PORT = None, chunk = None):
        self.OBJ = socket(AF_INET, SOCK_STREAM)
        self.OBJ.bind(('', int(PORT)))
        self.CHUNK = int(chunk)
        self.EstablishedResponse = b'HTTP/1.1 200 Connection established\r\n\r\n'
        self.STOP = False

    
    def Handler(self, ClientObj, ADDRESS):
        REQ = ClientObj.recv(self.CHUNK)
        logger.info(f'''REQUEST FROM [{ADDRESS[0]}]:{ADDRESS[1]} ->\t{REQ}''')
        (RemoteHost, RemotePort) = REQ.decode().split()[1].split(':')
        RemoteObj = socket(AF_INET, SOCK_STREAM)
        RemoteObj.connect((str(RemoteHost), int(RemotePort)))
        ClientObj.send(self.EstablishedResponse)
        RemoteThread = Thread(target = self.relay, args = (ClientObj, RemoteObj))
        ClientThread = Thread(target = self.relay, args = (RemoteObj, ClientObj))
        RemoteThread.start()
        ClientThread.start()
        return None
    # WARNING: Decompyle incomplete

    
    def relay(self, src, dst):
        if not self.STOP:
            DATA = src.recv(self.CHUNK)
            if not DATA:
                return None
            None.send(DATA)
    # WARNING: Decompyle incomplete

    
    def start(self):
        pass
    # WARNING: Decompyle incomplete


ARGUMENT = ArgumentParser()
ARGUMENT.add_argument('-p', '--port', type = int, default = 8080, help = 'Set Proxy Server Port')
ARGUMENT.add_argument('-c', '--chunk', type = int, default = 4096, help = 'Set Data Chunk')
arg = ARGUMENT.parse_args()
Server = SocketVPN(PORT = arg.port, chunk = arg.chunk)
Server.start()
