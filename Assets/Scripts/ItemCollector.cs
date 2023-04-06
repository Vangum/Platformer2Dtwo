using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemCollector : MonoBehaviour
{
    public static int cherries;
    public static int cherryCount = 0;


    [SerializeField] private Text cherriesText;
    [SerializeField] private AudioSource collectionSoundEffect;

   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            cherryCount++;
            cherriesText.text = "Cherries: " + cherries;
        }
    }
    /*void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectionSoundEffect.Play();
            cherriesText.text = "Cherries: " + cherries;
            cherryCount++;
            Destroy(collision.gameObject); // Удаляем собранную вишню из игры
        }
    }*/

}
