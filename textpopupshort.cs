using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textpopupshort : MonoBehaviour
{
    public GameObject uiObject;
    void Start()
    {
        uiObject.SetActive(false);
    }
            void OnTriggerEnter (Collider Player)
        {
            if (Player.gameObject.tag == "Player")
            {
                uiObject.SetActive(true);
                StartCoroutine("WaitForSec");
            }
        }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(4);
        Destroy(uiObject);
        Destroy(gameObject);
    }



}
