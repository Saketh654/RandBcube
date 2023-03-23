using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bullet1mechanic : MonoBehaviour
{
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
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "enemy1")
        {
            SceneManager.LoadScene(2);
        }
    }
}
