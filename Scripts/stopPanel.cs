using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopPanel : MonoBehaviour
{
    private Animator ani;
    public GameObject stop_button;
    void Start()
    {
        ani = GetComponent<Animator>();
    }
    /// <summary>
    /// �����ͣ
    /// </summary>
    public void Stop()
    {
        ani.SetBool("isStop", true);
        stop_button.SetActive(false);
    }
    /// <summary>
    /// �������
    /// </summary>
    public void Recur()
    {
        Time.timeScale = 1;
        ani.SetBool("isStop", false);
    }
    /// <summary>
    /// ����
    /// </summary>
    public void Replay()
    {

    }
    /// <summary>
    /// �����˵�
    /// </summary>
    public void Menu()
    {

    }
    /// <summary>
    /// ��ͣ����������
    /// </summary>
    public void StopAniEnd()
    {
        Time.timeScale = 0;
        print("��ͣ��Ϸ");
    }
    /// <summary>
    /// ��������������
    /// </summary>
    public void RecurAniEnd()
    {
        //Time.timeScale = 1;
        print("������Ϸ");
        stop_button.SetActive(true);
    }
}
