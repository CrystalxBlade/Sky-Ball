using UnityEngine;
using UnityEngine.SceneManagement;
public class Home : MonoBehaviour
{
    public void Play()
    {
        if(2 <= PlayerPrefs.GetInt("Level") && 5 <= PlayerPrefs.GetInt("Level"))
        {
            int lvl = PlayerPrefs.GetInt("Level",2);
            SceneManager.LoadScene(lvl);
        }
        else if (6 >= PlayerPrefs.GetInt("Level"))
        {
            SceneManager.LoadScene(6);
        }
    }
    public void Levels()
    {
        SceneManager.LoadScene("Levels");
    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }
    public void Quit()
    {
        Application.Quit();
    }
}
