using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickLogic : MonoBehaviour
{
    
    public void ClickSwitchColor()
    {
        GetComponent<Image>().color = Color.yellow;
    }
}
