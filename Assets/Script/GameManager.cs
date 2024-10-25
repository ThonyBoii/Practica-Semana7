using GameJolt.API;
using GameJolt.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private bool[] trophies = new bool[5]; // Se guarda el estado de los trofeos
    public float timeElapsed = 0;
    public int clickCount = 0;
    private bool playerDead = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        GameJoltUI.Instance.ShowSignIn();
        ResetTrophies();
    }

    private void ResetTrophies()
    {
        for (int i = 0; i < trophies.Length; i++)
            trophies[i] = false;
    }

    public void IncrementClickCount(int requiredClicks, int trophyIndex)
    {
        clickCount++;
        if (clickCount >= requiredClicks)
        {
            UnlockTrophy(trophyIndex)
        }
    }

    public void CheckTimeCondition(float requiredTime, int trophyIndex)
    {
        if (timeElapsed <= requiredTime)
        {
            UnlockTrophy(trophyIndex);
        }
    }

    public void CompleteLevel()
    {
        if (SceneManager.GetActiveScene().name == "Level1" && trophies[0] && trophies[1])
        {
            SceneManager.LoadScene("Level2");
        }
        else if (SceneManager.GetActiveScene().name == "Level2" && trophies[2] && trophies[3] && !playerDead)
        {
       
            SceneManager.LoadScene("EndScene"); 
        }
    }

    
    public void ResetClickAndTime()
    {
        clickCount = 0;
        timeElapsed = 0;
    }

}
