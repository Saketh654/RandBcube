using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdie : MonoBehaviour
{

    public GameObject bullet;


    private void Awake()
    {
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(3);
        Destroy(bullet);
    }
}
