#!/bin/bash
dir=$1;

dotnet new console -o "$dir";
cd "$dir";
mv Program.cs "$dir.cs";
