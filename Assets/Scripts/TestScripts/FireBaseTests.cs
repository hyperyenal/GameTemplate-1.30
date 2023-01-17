using System.Collections;
using System.Collections.Generic;
using Firebase;
using Firebase.Analytics;
using UnityEngine;

public class FireBaseTests
{
    static Firebase.FirebaseApp app;

    public static void InitFireBase()
    {
        Debug.Log("Firebase Init started");
        Firebase
            .FirebaseApp
            .CheckAndFixDependenciesAsync()
            .ContinueWith(task =>
            {
                var dependencyStatus = task.Result;
                if (dependencyStatus == Firebase.DependencyStatus.Available)
                {
                    // Create and hold a reference to your FirebaseApp,
                    // where app is a Firebase.FirebaseApp property of your application class.
                    app = Firebase.FirebaseApp.DefaultInstance;
                    FirebaseAnalytics.SetAnalyticsCollectionEnabled(true);

                    // Set a flag here to indicate whether Firebase is ready to use by your app.
                }
                else
                {
                    UnityEngine
                        .Debug
                        .LogError(System
                            .String
                            .Format("Could not resolve all Firebase dependencies: {0}",
                            dependencyStatus));
                    // Firebase Unity SDK is not safe to use here.
                }
            });
    }

    public static void DummyLogMessage()
    {
        //Firebase.Analytics.FirebaseAnalytics
        //        .LogEvent("DummyLogEntry", "GameName", "GameTemplate_1.30");
    }
}
