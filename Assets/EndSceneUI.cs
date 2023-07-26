using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndSceneUI : MonoBehaviour
{
    public Button restartButton;
    public Button toMenuButton;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined; //Allow user to use mouse now we are not in FP scene
        restartButton.onClick.AddListener(delegate { SceneNavigator.Instance.ChangeScene(2); });
        toMenuButton.onClick.AddListener(delegate { SceneNavigator.Instance.ChangeScene(0); });
    }
}
