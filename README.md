[![Build status](https://ci.appveyor.com/api/projects/status/ckd6fk0x95e0ot0x?svg=true
)](https://ci.appveyor.com/project/jzeferino/xamarin-android-switchbutton) [![NuGet](https://img.shields.io/nuget/v/Xamarin.Android.SwitchButton.svg?label=NuGet)](https://www.nuget.org/packages/Xamarin.Android.SwitchButton/)

Xamarin.Android.SwitchButton
===================

This is a Xamarin Android Binding for the [SwitchButton](https://github.com/kyleduo/SwitchButton).

This project provides you a convenient way to use and customise a SwitchButton widget in Android. 
With just resources changed and attrs set, you can create a lifelike SwitchButton of Android 5.0+, iOS, MIUI, or Flyme and so on.

<p align="center">
  <img src="https://github.com/kyleduo/SwitchButton/blob/master/preview/demo_140.jpg?raw=true"/>
</p>

## Usage

### Step 1

Install NuGet [package](https://www.nuget.org/packages/Xamarin.Android.SwitchButton/).

### Step 2

Define `xmlns:app` in your root view.

```xml
xmlns:sw="http://schemas.android.com/apk/res-auto"
```

Add the `SwitchButton` to your layout:

```xml
<com.kyleduo.switchbutton.SwitchButton
    android:id="@+id/sw"
    android:layout_width="wrap_content"
    android:layout_height="wrap_content"
    sw:kswThumbColor="@color/white"
    sw:kswThumbMargin="6dp"/>
```

### Step 3

```c#
protected override void OnCreate(Bundle savedInstanceState)
{
    base.OnCreate(savedInstanceState);

    _switch = FindViewById<SwitchButton>(Resource.Id.sw);
    _switch.CheckedChange += (sender, e) => Toast.MakeText(this, $"isChecked {e.IsChecked}", ToastLength.Short).Show();
}  
```
Run and play with the [sample](https://github.com/jzeferino/Xamarin.Android.SwitchButton/tree/master/Xamarin.Android.SwitchButton.Sample).

### License
[MIT Licence](LICENSE) 
