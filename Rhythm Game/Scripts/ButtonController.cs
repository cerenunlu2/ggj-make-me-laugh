using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;
    public KeyCode interactionButton;

    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(interactionButton))
        {
            theSR.sprite = pressedImage;
        }

        if (Input.GetKeyUp(interactionButton))
        {
            theSR.sprite = defaultImage;
        }
    }
}