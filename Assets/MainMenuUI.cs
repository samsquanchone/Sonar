using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainMenuUI : MonoBehaviour
{
    public Button playButton;
    public Button quitButton;
    public Button howToPlayButton;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined; //Allow user to use mouse now we are not in FP scene
        playButton.onClick.AddListener(delegate { SceneNavigator.Instance.ChangeScene(2); });
        howToPlayButton.onClick.AddListener(delegate { SceneNavigator.Instance.ChangeScene(1); });
        quitButton.onClick.AddListener(delegate { SceneNavigator.Instance.QuitGame(); });
    }
}
