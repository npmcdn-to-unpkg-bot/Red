#!/bin/bash

cd src

mono .paket/paket.bootstrapper.exe
mono .paket/paket.exe restore

xbuild Abc.sln /p:Configuration=Release
