using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemCollectorFinish : MonoBehaviour
{
    public int totalCherryCount;
    public Collider2D flagCollider;

    private int cherryCount;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Cherry")
        {
            cherryCount++;
            Destroy(other.gameObject);
        }
        else if (other.tag == "Player")
        {
            if (cherryCount == totalCherryCount)
            {
                SceneManager.LoadScene("NextLevel");
            }
            else
            {
                // Вывести сообщение об ошибке
            }
        }
    }

    void Update()
    {
        if (cherryCount == totalCherryCount)
        {
            flagCollider.isTrigger = true;
        }
        else
        {
            flagCollider.isTrigger = false;
        }
    }
}
