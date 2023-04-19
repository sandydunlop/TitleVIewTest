This application looks as expected with net6.0, but the title goes off the top of the window/screen with net7.0.

This has been reproduced on: macOS, iPhone simulator, physical iPhone.

On the Android virtual device, the net6.0 and net7.0 versions look identical, but the bottom half of the TitleView text missing.



The setting to build the project with net7.0or net6.0 is in FlyOutDemo.csproj at line 16.

The comment above it has the two settings for reproducing the issue.


