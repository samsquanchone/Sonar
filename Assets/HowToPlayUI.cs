using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowToPlayUI : MonoBehaviour
{
    public Button toMenuButton;
    public Button playButton;

    private void Start()
    {
        toMenuButton.onClick.AddListener(delegate { SceneNavigator.Instance.ChangeScene(0); });
        playButton.onClick.AddListener(delegate { SceneNavigator.Instance.ChangeScene(2); });
    }

}
