using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBaseTests
{
    public static void InitFireBase()
    {
        Debug.Log("Firebase Init started");
    }

    public static void DummyLogMessage()
    {
        Firebase.Analytics.FirebaseAnalytics
                .LogEvent("DummyLogEntry", "GameName", "GameTemplate_1.30");
    }
}

