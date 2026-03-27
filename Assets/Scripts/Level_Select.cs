using UnityEngine;
using UnityEngine.SceneManagement;
public class Level_Select : MonoBehaviour
{
    [SerializeField] float lvl;

    public void LoadLvl(int lvl)
    {
        SceneManager.LoadScene(lvl);
    }
}
