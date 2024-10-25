using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{
    private void Start()
    {
        GameManager.Instance.ResetClickAndTime();
    }

    private void Update()
    {
        GameManager.Instance.timeElapsed += Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
            GameManager.Instance.IncrementClickCount(10, 0); // Trofeo 1: 10 clics

        if (GameManager.Instance.timeElapsed <= 60)
            GameManager.Instance.CheckTimeCondition(60, 1); // Trofeo 2: Menos de 1 minuto
    }

    public void OnCompleteLevelButtonPressed()
    {
        GameManager.Instance.CompleteLevel();
    }
}
