#!/bin/bash/
cd ~/Documents/Visual\ Studio\ 2017/Projects/Team_Project_Maze/

read -p "Do you need to add? (y or n): " add
if [[ "$add" == *y* ]]; then
read -p "Add file: " file
git add $file
fi 

read -p "Do you need to commit? (y or n): " commitd
if [[ "$commitd" == *y* ]]; then
read -p "Commit: " commit
git commit -m $commit
fi

git push
read -n 1 -p "Press any key to continue"
	
