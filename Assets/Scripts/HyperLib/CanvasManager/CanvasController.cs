using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Assertions;

public class CanvasController : MonoBehaviour
{
    #region GamePatterns
    private GlobalGameParams globalGameParams;
    private UIBroker uiBroker;
    #endregion
    public ScreenNames screenName;
    public TMP_Text gameName;
    public TMP_Text level;
    public TMP_Text totalPoints;
    void Awake()
    {
        globalGameParams = Resources.Load("GlobalGameParams") as GlobalGameParams;
        Assert.IsNotNull(globalGameParams);
        uiBroker = Resources.Load("UIBroker") as UIBroker;
        Assert.IsNotNull(uiBroker);
    }

    void Start()
    {
        switch (screenName)
        {
            case ScreenNames.TutorScr:
            case ScreenNames.StartScr:
            case ScreenNames.SuccessScr:
            case ScreenNames.FailScr:
                gameName.text = globalGameParams.GameName;
                break;
            case ScreenNames.PlayScr:
                uiBroker.OnSetLevel += SetLevel;
                uiBroker.OnSetTotalPoints += SetTotalPoints;
                break;
            case ScreenNames.NoScr:
                break;
            default:
                break;
        }
    }

    public void SetGameName(string pGameName)
    {
        gameName.text = pGameName;
    }

    public void SetLevel(int plevel)
    {
        level.text = plevel.ToString();
    }
    public void SetTotalPoints(int points)
    {
        totalPoints.text = points.ToString();
    }
}
