using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickedObj : MonoBehaviour, IClickable
{
    public void OnClick()
    {
        Debug.Log("somebody clicked me");
        transform.Rotate(0, 30f, 0);
    }
}
