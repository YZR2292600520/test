using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    /// <summary>
    /// ������������ʾ��������
    /// </summary>
    public void Show()
    {
        GameManager.Instance.WinState();
    }
}
