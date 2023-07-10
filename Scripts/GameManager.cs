using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public List<brid> brids; //��
    public List<pig> pigs; //��
    private Vector3 startPos; //ÿֻС�����ʼλ��
    public GameObject win;
    public GameObject lose;
    public GameObject[] stars;//��������
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
                brids[i].transform.position = startPos; //��ֵ��ʼλ��
                //brids[i].transform.DOMove(startPos, 1);
                brids[i].sp2d.enabled = true; //��������
                brids[i].enabled = true; //����brid�ű�
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
        if (pigs.Count>0)//��û��
        {
            if (brids.Count>0)//������
            {
                Initialize();
            }
            else
            {
                //����
                lose.gameObject.SetActive(true);
            }
        }
        else
        {
            //Ӯ��
            win.gameObject.SetActive(true);
            //WinState();
        }
    }
    /// <summary>
    /// Ӯ��ʾ������
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
    /// ����
    /// </summary>
    public void Repaly()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
    /// <summary>
    /// �����˵�
    /// </summary>
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level");
    }
}
