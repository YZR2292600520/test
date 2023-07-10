using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public List<brid> brids; //鸟
    public List<pig> pigs; //猪
    private Vector3 startPos; //每只小鸟的起始位置
    public GameObject win;
    public GameObject lose;
    public GameObject[] stars;//星星数组
    private void Awake()
    {
        Instance = this;
        if (brids.Count > 0)
        {
            startPos = brids[0].transform.position;
        }
        
    }
    private void Start()
    {
        Initialize();
    }
    public void Initialize()
    {
        for (int i = 0; i < brids.Count; i++)
        {
            if (i == 0) 
            {
                brids[i].transform.position = startPos; //赋值起始位置
                //brids[i].transform.DOMove(startPos, 1);
                brids[i].sp2d.enabled = true; //激活弹簧组件
                brids[i].enabled = true; //激活brid脚本
            }
            else
            {
                brids[i].sp2d.enabled = false;
                brids[i].enabled = false;
            }
        }
    }

    public void NextDrid()
    {
        if (pigs.Count>0)//猪没死
        {
            if (brids.Count>0)//还有鸟
            {
                Initialize();
            }
            else
            {
                //输了
                lose.gameObject.SetActive(true);
            }
        }
        else
        {
            //赢了
            win.gameObject.SetActive(true);
            //WinState();
        }
    }
    /// <summary>
    /// 赢显示的星星
    /// </summary>
    public void WinState()
    {
        StartCoroutine(ShowStars());
    }
    IEnumerator ShowStars()
    {
        for (int i = 0; i < brids.Count + 1; i++)
        {
            yield return new WaitForSeconds(0.5f);
            stars[i].SetActive(true);
        }
    }
    /// <summary>
    /// 重玩
    /// </summary>
    public void Repaly()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
    /// <summary>
    /// 回主菜单
    /// </summary>
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level");
    }
}
