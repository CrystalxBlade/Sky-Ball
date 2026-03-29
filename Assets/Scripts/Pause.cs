using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
