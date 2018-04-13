#!/bin/bash
	cd ~/source/repos/Programming-Team-Project/
	read -p "Do you need to add (y or n): " add
	read -p "Do you need to commit: " commit
	if($add == y){
	read -p "File name of file adding: " file
	git add $file
	}
	if($commit == y){
	read -p "Commit: " commit
	git commit -m $commit
	}
	git push
	read -n 1 -p "Press any key to continue"