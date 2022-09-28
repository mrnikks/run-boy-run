using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMenu : MonoBehaviour
{
    // Start is called before the first frame update
  /*  void Start()
    {
        
    }*/

    // Update is called once per frame
  /*  void Update()
    {
        
    }*/

    public void PlayGame()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
