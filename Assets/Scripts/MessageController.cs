using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageController : MonoBehaviour
{
    public Text messageText;

    void Start()
    {
        messageText.gameObject.SetActive(false);
    }
}
