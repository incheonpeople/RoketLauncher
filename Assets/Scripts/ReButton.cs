using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReButton : MonoBehaviour
{
    public void ReGame() // Inspector â�� On Click�� ReButton()�� ����
    {
        SceneManager.LoadScene("Rocket");
    }
}

