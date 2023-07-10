using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    /// <summary>
    /// 动画播放完显示几颗星星
    /// </summary>
    public void Show()
    {
        GameManager.Instance.WinState();
    }
}
