using UnityEngine;
using UnityEngine.SceneManagement;

public class gamecontroller:MonoBehaviour
{
    public GameObject gameoverpanel;
    public GameObject taptostart;
    public GameObject scoretext;

    

    private void Start()
    {
        pausegame();
        gameoverpanel.SetActive(false);
        taptostart.SetActive(true);
        scoretext.SetActive(false);
       
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            startgame();
        }
    }

    public void gameover()
    {
        scoretext.SetActive(false);
        gameoverpanel.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("game");     
    }
    public void Quitgame()
    {
        Application.Quit();
    }
    public void pausegame()
    {
        Time.timeScale = 0f;
       }
    public void startgame()
    {
        Time.timeScale = 1f;
        taptostart.SetActive(false);
       scoretext.SetActive(true ); 
       

    }

}
