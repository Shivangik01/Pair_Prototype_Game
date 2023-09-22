using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public static bool isGameWin;
    public GameObject gameOverScreen;
    public GameObject gameWinScreen;

    private void Awake()
    {
        isGameOver = false;
        isGameWin = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
        }

        if (isGameWin)
        {
            gameWinScreen.SetActive(true);
        }
    }

    public void ReplayLevel()
    {
        gameObject.SetActive(true);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Level01");

    }

    public void NextLevel()
    {
        gameObject.SetActive(true);
        SceneManager.LoadScene("Level01");
    }
}
