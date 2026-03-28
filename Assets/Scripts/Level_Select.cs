using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Level_Select : MonoBehaviour
{
    [SerializeField] int lvlNo;

    void Start()
    {
        if(lvlNo <= PlayerPrefs.GetInt("Level", 1))
        {
            gameObject.GetComponent<Button>().interactable = true;
        }
        else
        {
            gameObject.GetComponent<Button>().interactable = false;
        }
    }
    public void LoadLvl()
    {
        SceneManager.LoadScene(lvlNo);
    }
}
