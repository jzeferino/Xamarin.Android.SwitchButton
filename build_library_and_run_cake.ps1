cd Android.SwitchButton\SwitchButton\
ls
.\gradlew library:clean library:assembleRelease -x lint --stacktrace
cp library\build\outputs\aar\library-release.aar ..\..\Xamarin.Android.SwitchButton\Jars\
cd ..\..\
.\build.ps1 -v diagnostic 