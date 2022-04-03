#!/bin/bash

# Start netdata
/usr/sbin/netdata
  
# Start nodeJS
dotnet Blazor-Service-GuessMyUI.dll