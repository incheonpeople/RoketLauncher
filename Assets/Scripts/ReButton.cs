using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReButton : MonoBehaviour
{
    public void ReGame() // Inspector 창에 On Click에 ReButton()이 생김
    {
        SceneManager.LoadScene("Rocket");
    }
}

