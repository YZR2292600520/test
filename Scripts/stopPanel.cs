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
    /// 点击暂停
    /// </summary>
    public void Stop()
    {
        ani.SetBool("isStop", true);
        stop_button.SetActive(false);
    }
    /// <summary>
    /// 点击继续
    /// </summary>
    public void Recur()
    {
        Time.timeScale = 1;
        ani.SetBool("isStop", false);
    }
    /// <summary>
    /// 重玩
    /// </summary>
    public void Replay()
    {

    }
    /// <summary>
    /// 回主菜单
    /// </summary>
    public void Menu()
    {

    }
    /// <summary>
    /// 暂停动画播放完
    /// </summary>
    public void StopAniEnd()
    {
        Time.timeScale = 0;
        print("暂停游戏");
    }
    /// <summary>
    /// 继续动画播放完
    /// </summary>
    public void RecurAniEnd()
    {
        //Time.timeScale = 1;
        print("继续游戏");
        stop_button.SetActive(true);
    }
}
