using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUpUI : MonoBehaviour
{
    public static PickUpUI Instance => m_instance;
    private static PickUpUI m_instance;

    public TMP_Text pickUpText;

    int pickUps = 0;
    // Start is called before the first frame update
    void Start()
    {
        m_instance = this;
        pickUpText.text = "Pick-ups: " + pickUps + "/4";
    }

    public void IncrementPickUps()
    {
        pickUps += 1;
        pickUpText.text = "Pick-ups: " + pickUps + "/4";

        if (pickUps == 4)
        {
            GameManager.Instance.WinGame();
        }


    }
}
