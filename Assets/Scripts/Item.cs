using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public AudioClip soundGetitem;

    void OnTriggerEnter(Collider hit)
    {

        if (hit.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(soundGetitem, transform.position);
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
