using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    //private bool Pause = true;
    public GameObject PauseMenu;
    public GameObject GameMenu;
    public GameObject StartMeny;
    public GameObject EndMenu;


    
    public void Start()
    {
        Time.timeScale = 0;
        StartMeny.SetActive(true);
        
        
        GameMenu.SetActive(false);
        PauseMenu.SetActive(false);
    }

    public void GameStart()
    {
        Time.timeScale = 1;
        StartMeny.SetActive(false);
        GameMenu.SetActive(true);
    }
    
    public void PauseStart()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
        GameMenu.SetActive(false);
    }

    public void PauseEnd()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
        GameMenu.SetActive(true);
    }

    public void NewGameStart()
    {
        SceneManager.LoadScene("SampleScene"); //рестарт
        EndMenu.SetActive(false);

    }
}
