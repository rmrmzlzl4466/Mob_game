using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    private int clickCount = 0;

    public void OnButtonClick()
    {
        clickCount++;
        if (clickCount == 1)
        {
            Debug.Log("첫 번째 클릭입니다!");
        }
        else if (clickCount == 2)
        {
            Debug.Log("두 번째 클릭입니다!");
        }
        else if (clickCount == 3)
        {
            Debug.Log("세 번째 클릭입니다!");
        }
        else
        {
            Debug.Log("클릭 횟수를 초과했습니다.");
        }
    }
}