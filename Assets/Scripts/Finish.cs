using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;
    private bool levelCompleted = false;
    public Text messageText;
    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
        messageText.gameObject.SetActive(false);
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            finishSound.Play();
            levelCompleted = true;
            Invoke("CompleteLevel", 1.5f);
        }
    }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !levelCompleted)
        {
            if (ItemCollector.cherryCount >= 5)
            {
                // ≈сли собрано достаточно вишен, переходим на следующий уровень
                finishSound.Play();
                levelCompleted = true;
                Invoke("CompleteLevel", 1.5f);              
            }
            else
            {
                // »наче выводим сообщение об ошибке
                Debug.Log("—оберите все 5 вишен, чтобы перейти на следующий уровень");
                messageText.gameObject.SetActive(true);

            }
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
