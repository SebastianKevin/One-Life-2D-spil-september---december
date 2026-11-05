using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void LoadScene(int id)
    {
        SceneManager.LoadScene(id);
    }

    public void Quit()
    {
#if (UNITY_EDITOR)
        UnityEditor.EditorApplication.isPlaying = false;
#endif
#if (UNITY_STANDALONE)
    Application.Quit();
#endif
    }

    public void ChooseCharacter()
    {
        
    }
}