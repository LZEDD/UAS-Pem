using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MasukGame : MonoBehaviour
{
    public string gameSceneName = "GameScene";

    public void Play()
    {
        // Memuat scene game berdasarkan nama scene
        SceneManager.LoadScene("Gameplay");
        Time.timeScale = 1.0f;
    }

    public void Exid()
    {
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
