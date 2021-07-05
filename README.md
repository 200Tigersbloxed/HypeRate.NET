# HypeRate.NET
.NET Implementation for HypeRate.IO

# Working with HypeRate.NET
For how to work with HypeRate.NET.

## Getting Started

First, go to the [Releases Page](https://github.com/200Tigersbloxed/HypeRate.NET/releases/) and download the merged dll. This dll will be your library.

Now, you'll need to import this into your project. As of 7/5/2021, the project is built under .NET 4.8, but it should compatible with any .NET version, even .NET Core.
Once you have the project created, require the dll as a dependency.

## Creating a new Listener

Now that we have our dll imported, we need a listener, right? First, at the top of your code, make sure you're referencing HypeRate.NET.

```cs
using HypeRate.NET;
```

Now to create a new listener, implement this at the start of your code.

```cs
string sessionId = "1234";
HeartRate hypeRate = new HeartRate(sessionId);
```

Here, we're creating a new HeartRate listener and passing our `sessionId` as the only parameter. 
Do note that if this parameter changes, you'll have to recreate the HeartRate Listener.

## Subscribing to Data

Now that we have our listener created, we have to Subscribe to the Data to be able to read it.

```cs
hypeRate.Subscribe();
```

This script references our created HeartRate Listener that we created above and has it Subscribe to data. This means that we will begin listening for WebSocket traffic from HypeRate's socket.

## Reading Data

Since HypeRate only gets your HeartRate, let's get the HeartRate. Note that for this to work, you must be Subscribed to data!

```cs
exampleInt = hypeRate.HR;
```

Here, `exampleInt` is an example variable that is an `int` and `hypeRate.HR` is the last recorded HeartRate. This can be cast to a string as well if you want to:

```
exampleInt = hypeRate.HR;
string heartRateText = exampleInt.ToString();
```

## Unsubscribing from Data

Once you're done reading Data, be sure to Unsubscribe from it.

```cs
hypeRate.Unsubscribe();
```

This should be called whenever you aren't actively reading HeartRate data or you won't be for a while. It wouldn't hurt to leave it on, but if you want to save resources, it is recommended.

## Unity Notes

Since HypeRate.NET uses `System.Timers` to function, it is **NOT** recommended to test HypeRate.NET in the Editor. If you do decide to use HypeRate.NET in the Unity Editor for testing, please be sure to unsubscribe from data, otherwise, it'll keep looping.

# Building HypeRate.NET from source
For developers who want to make changes

## Dependencies

HypeRate.NET requires the following NuGet Dependencies:

+ [Newtonsot.Json](https://www.nuget.org/packages/Newtonsoft.Json/)

HypeRate.NET requires the following external Dependencies:

+ [websocket-sharp](https://github.com/sta/websocket-sharp)

HypeRate.NET requires the following internal Dependencies:

+ System
+ System.Timers

## Building

Download the latest source code, of course, and open the .vs file in a preferred IDE. (I used VS2019)

Import the Dependencies, as seen above.

Build HypeRate.NET first, then HypeRate.NET.Test.
