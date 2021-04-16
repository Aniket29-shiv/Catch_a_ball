using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GameObject.Find("Dog(Clone)")== null)
            {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            }
            else
            {
                Debug.Log("Do not cheat!");
            }
        }
    }
}
