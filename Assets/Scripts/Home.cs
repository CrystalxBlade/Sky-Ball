using UnityEngine;
using UnityEngine.SceneManagement;
public class Home : MonoBehaviour
{
    public void Play()
    {
        
    }
    public void Levels()
    {
        SceneManager.LoadScene("Levels");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
