using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wisp : MonoBehaviour
{
    string PlayerName = "SideScrollPlayer";
    public bool isCollected = false;
    public GameObject[] wisps;
    public AudioSource sfx;

    public int wispPoints = 0;



    void Start()
    {
        sfx = GameObject.FindGameObjectWithTag("WispSFX").GetComponent<AudioSource>();
        //Setting all wisps to active
        foreach (GameObject go in wisps)
        {
            go.SetActive(true);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == PlayerName)
        {
            //gameObject.GetComponent<Manager>().wispsCollected++;
            ;
            isCollected = true;

            //Destroy(gameObject);
            //setting triggered wisp to active == false
            gameObject.SetActive(false);
        }

    }


}
