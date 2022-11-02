using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    public void Stage1()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Stage2()
    {
        SceneManager.LoadScene("GameScene2");
    }

    public void Stage3()
    {
        SceneManager.LoadScene("GameScene3");
    }
}
