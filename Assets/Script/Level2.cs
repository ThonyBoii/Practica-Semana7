using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : MonoBehaviour
{
    private void Start()
    {
        GameManager.Instance.ResetClickAndTime();
    }

    private void Update()
    {
        GameManager.Instance.timeElapsed += Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
            GameManager.Instance.IncrementClickCount(20, 3); // Trofeo 4: 20 clics

        if (GameManager.Instance.timeElapsed <= 45)
            GameManager.Instance.CheckTimeCondition(45, 2); // Trofeo 3: Menos de 45 segundos
    }

    public void OnCompleteLevelButtonPressed()
    {
        GameManager.Instance.CompleteLevel();
    }
}
