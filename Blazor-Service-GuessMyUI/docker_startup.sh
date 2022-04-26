#!/bin/bash

# Start netdata
/usr/sbin/netdata

# Start NET
dotnet Blazor-Service-GuessMyUI.dll
