using UnityEngine;
using UnityEngine.SceneManagement;
public class Home : MonoBehaviour
{
    public void Play()
    {
        int lvl = PlayerPrefs.GetInt("Level",2);
        if(lvl >= 2 && lvl <= 5)
        {
            SceneManager.LoadScene(lvl);
        }
        else if (lvl > 5)
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
