using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelManager : MonoBehaviour
{
    [SerializeField] TMP_Text lvlText;
    [SerializeField] int nextLvl;
    [SerializeField] GameObject pauseScreen;
    bool pause;
    void Start()
    {
        nextLvl = SceneManager.GetActiveScene().buildIndex + 1;
        lvlText.text = $" Level {SceneManager.GetActiveScene().buildIndex - 1}";
    }
    void Update()
    {
        if(transform.position.y < -10)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }
    void TogglePause()
    {
        pause = !pause;
        pauseScreen.SetActive(pause);
        Time.timeScale = pause ? 0f : 1f;
    }
    void NextLvl()
    {
        SceneManager.LoadScene(nextLvl);
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Finish"))
        {
            Destroy(other.gameObject);
            Invoke("NextLvl", 2);

            if(nextLvl > PlayerPrefs.GetInt("Level"))
            {
                PlayerPrefs.SetInt("Level", nextLvl);
            }
        }
        if(other.gameObject.CompareTag("Last"))
        {
            SceneManager.LoadScene("Credit");
        }
    }
}
