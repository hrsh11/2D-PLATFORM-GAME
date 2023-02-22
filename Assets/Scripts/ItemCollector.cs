using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
private int Cherries = 0;
[SerializeField] private Text CherriesText;
[SerializeField] private AudioSource collectionSoundEffect;
private void OnTriggerEnter2D(Collider2D Collision)
{
    if (Collision.gameObject.CompareTag("Cherry"))
    {
        collectionSoundEffect.Play();
        Destroy(Collision.gameObject);
        Cherries++;
        CherriesText.text = "Cherries: " + Cherries;
    }
}
}
