using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

/// I am registering my OnKeySpacePressed func for KEYSPACEPRESSED event. Whenever this event is published
/// my OnKeySpacePressed func will be executed
public class SubTest : MonoBehaviour
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
        GameMaster.Instance.DebugGameName(typeof(SubTest).FullName);
        globalGameParams.eventManager.RegisterSub("KEYSPACEPRESSED", OnKeySpacePressed);
    }

    public void OnKeySpacePressed(object sender, string eArgs)
    {
        EArgs_SPACEPRESSED obj = JsonUtility.FromJson<EArgs_SPACEPRESSED>(eArgs);
        Debug.LogFormat("SubTest : dateTime: {0} Level: {1}", obj.dateTime, obj.level);
    }
    void Update()
    {

    }
}
