#!/usr/bin/python

import os
import sys


if len(sys.argv) < 3:
	print("Usage: python ChCredMaker.py <User List> <Pass List>")
	sys.exit(1)

userlistPath:str = sys.argv[1]
passlistPath:str = sys.argv[2]
outputPath:str = "cred.txt"

if not os.path.exists(userlistPath):
	sys.exit("[-] User List not found!")

if not os.path.exists(passlistPath):
	sys.exit("[-] Password List not found!")

with open(userlistPath, "r") as frUserList:
	usersList = frUserList.read().splitlines()
	frUserList.close()

with open(passlistPath, "r") as frPassList:
	passLists = frPassList.read().splitlines()
	frPassList.close()

TotalUserList:int = len(usersList)
TotalPassList:int = len(passLists)


print(f"[+] Total users list: {TotalUserList}")
print(f"[+] Total password list: {TotalPassList}")
print(f"[+] Using {os.path.basename(userlistPath)}, {os.path.basename(passlistPath)}")
print("[+] Start generating credentials")
print('-'*50)

cred = open(outputPath, "w").write("")

count_created:int = 0
with open(outputPath, "a") as fwout:
	for user in usersList:
		user = user.strip()
		for password in passLists:
			password = password.strip()
			combo = f"{user};{password}"
			fwout.write(combo+"\n")
			count_created += 1
			print("[+]", count_created, "count of credentials generated", end="\r", flush=True)

	fwout.close()


print("\n[+] Your credentials has been generated successfully")
