# dotnet-maui-bug-build-release

* dotnet build -p:Configuration=Release -p:TargetFramework=net9.0-android -p:AndroidSdkDirectory=[YourAndroidSdkDirectory] -p:EmbedAssembliesIntoApk=true --verbosity d

Error: Microsoft.Android.Sdk.Aot.targets(110,5): error : Precompiling failed for DXMauiApp.dll with exit code 139.

* dotnet build -p:Configuration=Release -p:TargetFramework=net9.0-ios -p:RuntimeIdentifier=ios-arm64 --verbosity d

Error: Xamarin.Shared.Sdk.targets(1279,3): error : Failed to AOT compile DXMauiApp.dll, the AOT compiler exited with code 139.
