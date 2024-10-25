using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using GameJolt.UI;
using UnityEngine.SceneManagement;

public class ShowLogin : MonoBehaviour
{
    private void Start()
    {
        GameJoltUI.Instance.ShowSignIn(OnSignIn);
    }

    private void OnSignIn(bool success)
    {
        if (success)
        {
            SceneManager.LoadScene("Level1");
        }
        else
        {
            UnityEngine.Debug.Log("No se pudo logear");
        }
    }
}
