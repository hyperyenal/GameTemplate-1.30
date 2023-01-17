using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Assertions;


public enum ScreenNames
{
    TutorScr,
    StartScr,
    SuccessScr,
    FailScr,
    PlayScr,
    NoScr
}


public class CanvasMan : MonoBehaviour
{
    List<CanvasController> canvasControllerList;
    CanvasController lastActiveCanvas;
    CanvasController activeScreen;

    #region GamePatterns
    private GlobalGameParams globalGameParams;

    private UIBroker uiBroker;
    #endregion

    public GameObject joyStick;

    void Awake()
    {
        globalGameParams = Resources.Load("GlobalGameParams") as GlobalGameParams;
        Assert.IsNotNull(globalGameParams);
        uiBroker = Resources.Load("UIBroker") as UIBroker;
        Assert.IsNotNull(uiBroker);

        canvasControllerList = GetComponentsInChildren<CanvasController>().ToList();
        canvasControllerList.ForEach(x => x.gameObject.SetActive(false));

        uiBroker.OnDelegateSwitchCanvas += SwitchCanvas;
        uiBroker.OnDelegateEnableJoyStickPanel += EnableJoyStickPanel;

        joyStick.SetActive(false);
    }

    void Start()
    {
        SwitchCanvas(ScreenNames.TutorScr);
    }

    public void SwitchCanvas(ScreenNames screenName)
    {
        if (lastActiveCanvas != null)
        {
            lastActiveCanvas.gameObject.SetActive(false);
        }
        if (screenName == ScreenNames.NoScr) return;

        activeScreen = canvasControllerList.Find(x => x.screenName == screenName);
        if (activeScreen != null)
        {
            activeScreen.gameObject.SetActive(true);
            lastActiveCanvas = activeScreen;
        }
    }

    private void EnableJoyStickPanel(bool enable)
    {
        joyStick.SetActive(enable);
    }
}
