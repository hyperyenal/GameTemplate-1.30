using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;

public enum ButtonActions
{
    RESTART,
    SKIPLEVEL,
    START,
    NEXTLEVEL,
    ENDTUTOR
}



[RequireComponent(typeof(Button))]
public class ButtonActionsMan : MonoBehaviour
{
    #region GamePatterns
    private GlobalGameParams globalGameParams;
    private UIBroker uiBroker;
    #endregion

    public ButtonActions buttonAction;
    Button menuButton;
    void Awake()
    {
        globalGameParams = Resources.Load("GlobalGameParams") as GlobalGameParams;
        Assert.IsNotNull(globalGameParams);
        uiBroker = Resources.Load("UIBroker") as UIBroker;
        Assert.IsNotNull(uiBroker);
    }

    void Start()
    {
        menuButton = GetComponent<Button>();
        menuButton.onClick.AddListener(OnButtonClicked);
    }

    void OnButtonClicked()
    {
        switch (buttonAction)
        {
            case ButtonActions.ENDTUTOR:
                uiBroker.SwitchCanvas(ScreenNames.StartScr);
                break;
            case ButtonActions.START:
                uiBroker.SwitchCanvas(ScreenNames.PlayScr);
                uiBroker.EnableJoyStickPanel(true);
                GameMaster.Instance.PlayLevel();
                break;
            case ButtonActions.NEXTLEVEL:
                GameMaster.Instance.level++;
                uiBroker.SwitchCanvas(ScreenNames.StartScr);
                break;
            case ButtonActions.SKIPLEVEL:
                GameMaster.Instance.level++;
                uiBroker.SwitchCanvas(ScreenNames.StartScr);
                break;
            case ButtonActions.RESTART:
                uiBroker.SwitchCanvas(ScreenNames.StartScr);
                break;

        }
    }
}


