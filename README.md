Fontysfaction
=============

Fontysfaction is an Open Source Xamarin Android library that allows developers to easily create applications with custom fonts. Feel free to use it all you want in your Android apps provided that you cite this project and include the license in your app.


![Screenshot](https://raw.github.com/FattoriniLuca/Fontysfaction/master/screen-app.png)


Setup
-----
__1.__ In Xamarin, import the library as an Android library project. Now you can build it and export as DLL.

__2.__ Then, add Fontysfaction dll as a dependency to your existing project.

__3.__ At Last quick setup your application class and you are good to go!

```C#
[Application]
class MyApplication: Application
{

    public override void OnCreate ()
    {
        base.OnCreate ();
		
        //Create a base FontyConfiguration and initialize FontyLoader
        FontyConfiguration configuration = new FontyConfiguration () {
            Extension = ".ttf",
            FontEntityClazz = typeof(MyFontyEntity),
            SourceTypo = FontySourceTypo.assets
        };
		
        FontyLoader.GetInstance ().Init (configuration);
    }
}
```

Configuration
-----
All options in FontyConfiguration builder are optional. Use only those you really want to customize.
```C#
FontyConfiguration configuration = new FontyConfiguration () {
    Extension = ".ttf",
    FontEntityClazz = typeof(MyFontyEntity),
    SourceTypo = FontySourceTypo.assets,
    Path = "base_path"
};
```

FontyEntity
-----
You can configure your FontyEntity via Annotations, only required one is @FontyEntity!
![Screenshot](https://raw.github.com/FattoriniLuca/Fontysfaction/master/test-configuration.png) 
```c#
[FontyEntity]
[FontyPath (Value = "fonts")]
public class MyFontyEntity
{
    [FontyIdentifier (Value = FontyTypo.regular)]
    [FontyName (Value = "MyFont-Regular")]
    [FontyPath (Value = "myFont")]
    public String regular;

    [FontyIdentifier (Value = FontyTypo.bold)]
    [FontyName (Value = "MyFont-Bold")]
    [FontyPath (Value = "myFont")]
    public String bold;

    [FontyIdentifier (Value = FontyTypo.light)]
    [FontyName (Value = "MyFont-Light")]
    [FontyPath (Value = "myFont")]
    public String light;

    [FontyIdentifier (Value = FontyTypo.regular_italic)]
    [FontyName (Value = "MyFont-Regular-Italic")]
    [FontyPath (Value = "myFont")]	
    public String regular_italic;

    [FontyIdentifier (Value = FontyTypo.bold_italic)]
    [FontyName (Value = "MyFont-Bold-Italic")]
    [FontyPath (Value = "myFont")]
    public String bold_italic;

    [FontyIdentifier (Value = FontyTypo.light_italic)]
    [FontyName (Value = "yFont-Light-Italic")]
    [FontyPath (Value = "myFont")]
    public String light_italic;
}
```

XML Usage
-----
If you decide to use Fontysfaction as a view, you can define it in your xml layouts like this:
```xml
<Florismart.Fontisfaction.Droid.View.FontyTextView
    xmlns:fonty="http://schemas.android.com/apk/res-auto"
    android:layout_width="wrap_content"
    android:layout_height="wrap_content"
    android:text="Hey, this is a regular TextView Fontysfaction"
    fonty:font="regular" />

<Florismart.Fontisfaction.Droid.View.FontyButton
    xmlns:fonty="http://schemas.android.com/apk/res-auto"
    android:layout_width="wrap_content"
    android:layout_height="wrap_content"
    android:text="Hey, this is a bold Button Fontysfaction!"
    fonty:font="bold" />
    
<Florismart.Fontisfaction.Droid.View.EditText
    xmlns:fonty="http://schemas.android.com/apk/res-auto"
    android:layout_width="wrap_content"
    android:layout_height="wrap_content"
    android:text="Hey, this is a regular-italic EditText Fontysfaction!"
    fonty:font="regular_italic" />
```
