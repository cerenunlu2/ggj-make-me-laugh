using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode interactionButton;

    public GameObject badEffect,goodEffect,perfectEffect;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(interactionButton))
        {
            
            if (canBePressed)
            {
                Destroy(gameObject);

                if (transform.position.y <= 1.3f && transform.position.y > 0.12f)
                {
                    Debug.Log("Normal");
                    GameManager.instance.NormalHit();                    
                    GameObject Ahmet =Instantiate(goodEffect, transform.position, goodEffect.transform.rotation);
                    Destroy(Ahmet, 1f);

                }
                if (PerfectCollision.instance.isPerfect==true)
                {
                    Debug.Log("Perfect");
                    GameManager.instance.PerfectHit();
                    GameObject Arda = Instantiate(perfectEffect, transform.position, perfectEffect.transform.rotation);
                    Destroy(Arda, 1f);

                }

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;

            GameManager.instance.NoteMissed();
           GameObject mahmut=  Instantiate(badEffect, transform.position, badEffect.transform.rotation);
            Destroy(mahmut, 1f);
        }
    }
}