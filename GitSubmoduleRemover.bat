@echo off
set /p submodule_path="Enter the relative path to the submodule (e.g. path/to/submodule): "

git submodule deinit -f -- %submodule_path%
git rm -rf .git/modules/%submodule_path%
git rm -f %submodule_path%
git commit -m "Removed submodule %submodule_path%"