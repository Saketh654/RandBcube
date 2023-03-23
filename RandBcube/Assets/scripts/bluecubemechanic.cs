using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluecubemechanic : MonoBehaviour
{
    public Transform spawnPointbs;
    public GameObject bluesphere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "bullet2")
        {
            var blue = Instantiate(bluesphere, spawnPointbs.position, spawnPointbs.rotation);
            Destroy(other.gameObject);
            

        }
    }

}