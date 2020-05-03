import base64
import hashlib
import Crypto
#import crypto.cipher
from Crypto import Random
from Crypto.Cipher import AES
import os
import os.path
from os import listdir
from os.path import isfile, join
import time
import sys
sys.path.append(r"D:\\Python\\")
sys.path.append(r"D:\\Python\\Lib\\")
sys.path.append(r"D:\\Python\\Crypto\\")
class AES_encryption:
    key = b'[EX\xc8\xd5\xbfI{\xa2$\x05(\xd5\x18\xbf\xc0\x85)\x10nc\x94\x02)j\xdf\xcb\xc4\x94\x9d(\x9e'


    def pad(self, s):
        return s + b"\0" * (AES.block_size - len(s) % AES.block_size)
    
    def encrypt(self, message,key, key_size=256):
        #message = self.pad(message)
        iv = Random.new().read(AES.block_size)
        cipher = AES.new(key, AES.MODE_CBC, iv)
        return iv + cipher.encrypt(message)
    def decrypt(self, ciphertext, key):
        iv = ciphertext[:AES.block_size]
        cipher = AES.new(key, AES.MODE_CBC, iv)
        plaintext = cipher.decrypt(ciphertext[AES.block_size:])
        return plaintext.rstrip(b"\0")
key = b'[EX\xc8\xd5\xbfI{\xa2$\x05(\xd5\x18\xbf\xc0\x85)\x10nc\x94\x02)j\xdf\xcb\xc4\x94\x9d(\x9e'
a=AES_encryption()
print(a.encrypt("sdknc",key))