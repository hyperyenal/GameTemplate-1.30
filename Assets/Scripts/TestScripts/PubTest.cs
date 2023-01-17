using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;


/// Publisher is reponsible for defining the parameter of the event
public class EArgs_SPACEPRESSED
{
    public int level;

    public string dateTime;
}

/// Register a event, saying that I will inform all the subscribers of this event when happens. GameMaster automatically creates the
/// Event manager of this game and can be used.
public class PubTest : MonoBehaviour
{
    #region GamePatterns
    private GlobalGameParams globalGameParams;
    private UIBroker uiBroker;
    #endregion

    void Awake()
    {
        globalGameParams = Resources.Load("GlobalGameParams") as GlobalGameParams;
        Assert.IsNotNull(globalGameParams);
        uiBroker = Resources.Load("UIBroker") as UIBroker;
        Assert.IsNotNull(uiBroker);
    }
    void Start()
    {
        GameMaster.Instance.DebugGameName(typeof(PubTest).FullName);
        globalGameParams.eventManager.RegisterPub("KEYSPACEPRESSED");

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            EArgs_SPACEPRESSED obj = new EArgs_SPACEPRESSED();
            obj.dateTime = System.DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy   HH:mm");
            obj.level = 78;
            gameMaster.eventManager.TriggerEvent("KEYSPACEPRESSED", JsonUtility.ToJson(obj));
        }
        */
    }
}
