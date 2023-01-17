using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadGameLevels : MonoBehaviour
{
    private GlobalGameParams globalGameParams;
    void Start()
    {
        globalGameParams = Resources.Load("GlobalGameParams") as GlobalGameParams;
        Debug.Log(globalGameParams.GetGameLevel(1).name);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
