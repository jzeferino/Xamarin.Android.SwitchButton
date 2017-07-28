#!/bin/bash
cd Android.SwitchButton/SwitchButton/
# build release bypassing lint
./gradlew library:clean library:assembleRelease -x lint
cp library/build/outputs/aar/library-release.aar ../../Xamarin.Android.SwitchButton/Jars/
cd ../../
./build.sh