using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscapeMenu : MonoBehaviour
{
    public GameObject escapeMenu;
    public Button resumeButton;
    public Button toMenuButton;
    // Start is called before the first frame update
    void Start()
    {
        escapeMenu.SetActive(false);

        resumeButton.onClick.AddListener(delegate { CloseEscapeMenu(); });
        toMenuButton.onClick.AddListener(delegate { SceneNavigator.Instance.ChangeScene(0); });
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Show menu
            escapeMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            GameManager.Instance.SetGameState(GameState.MenuOpen);
        }
    }

    void CloseEscapeMenu()
    {
        escapeMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        GameManager.Instance.SetGameState(GameState.Normal);
    }


}
