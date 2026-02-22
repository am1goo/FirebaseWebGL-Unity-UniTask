# Firebase for Unity WebGL (UniTask Extensions)
Extensions for original Firebase for Unity WebGL package.

## Features
- callback-based API turned to be async/await API

## Requirements
- **Firebase for Unity WebGL** package: [com.am1goo.firebase.webgl](https://github.com/am1goo/FirebaseWebGL-Unity)
- **UniTask** package: [com.cysharp.unitask](https://github.com/Cysharp/UniTask)

## Installation
##### via Unity Package Manager
The latest version can be installed via [package manager](https://docs.unity3d.com/Manual/upm-ui-giturl.html) using following git URL:
```
https://github.com/am1goo/FirebaseWebGL-Unity-UniTask.git#0.6.0
```

## How to use
#### Create a Firebase App
```csharp
private FirebaseWebGL.FirebaseApp app;

void Awake()
{
    app = FirebaseWebGL.FirebaseApp.DefaultInstance();
}
```
#### Initialize installed modules
```csharp
async UniTask InitializeAsync(CancellationToken cancellationToken)
{
    if (app.Analytics != null)
    {
        try
        {
            await app.Analytics.InitializeAsync(cancellationToken);
            Debug.Log($"Initialized: {isInitialized}");
        }
        catch (Exception ex)
        {
            Debug.LogException(ex);
        }
    }
}
```

#### Do what you want as same as you do it in official plugin (or kind of similar way)
```csharp
...
        app.Analytics.LogEvent("my event");
...
```

## Tested in
- Unity 2020.3.x

## Contribute
Contribution in any form is very welcome. Bugs, feature requests or feedback can be reported in form of Issues.
