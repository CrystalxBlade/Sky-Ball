using UnityEngine;
using UnityEngine.SceneManagement;
public class Home : MonoBehaviour
{
    public void Play()
    {
        int lvl = PlayerPrefs.GetInt("Level",2);
        SceneManager.LoadScene(lvl);
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
