using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPickUps : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            PickUpUI.Instance.IncrementPickUps();
           
        }
    }
}
