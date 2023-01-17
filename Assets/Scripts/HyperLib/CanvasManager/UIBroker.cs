using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UIBroker", menuName = "Hypernova/Brokers/UIBroker")]
public class UIBroker : ScriptableObject
{
    public delegate void DelegateSetLevel(int level);
    public event DelegateSetLevel OnSetLevel;
    public delegate void DelegateSetTotalPoints(int points);
    public event DelegateSetTotalPoints OnSetTotalPoints;
    public delegate void DelegateSwitchCanvas(ScreenNames screenName);
    public event DelegateSwitchCanvas OnDelegateSwitchCanvas;
    public delegate void DelegateEnableJoyStickPanel(bool enable);
    public event DelegateEnableJoyStickPanel OnDelegateEnableJoyStickPanel;

    void OnEnable()
    {

    }
    void OnDisable()
    {

    }

    public void SetTotalPoints(int points)
    {
        if (OnSetTotalPoints != null)
            OnSetTotalPoints(points);

    }

    public void SetLevel(int level)
    {
        if (OnSetLevel != null)
            OnSetLevel(level);
    }

    public void SwitchCanvas(ScreenNames screenName)
    {
        if (OnDelegateSwitchCanvas != null)
            OnDelegateSwitchCanvas(screenName);
    }


    public void EnableJoyStickPanel(bool enable)
    {
        if (OnDelegateEnableJoyStickPanel != null)
            OnDelegateEnableJoyStickPanel(enable);

    }

}
