using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
    public bool startPlaying;
    public BeatScroller theBS;
    public static GameManager instance;

    public float totalNotes;
    public float normalHits;
    public float perfectHits;
    

    public GameObject resultScreen;
    public Text percentHitText, normalText, perfectText;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        totalNotes = FindObjectsOfType<NoteObject>().Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                theBS.hasStarted = true;
                theMusic.Play();
            }
        }
        else 
        {
            if (!theMusic.isPlaying && !resultScreen.activeInHierarchy)
            {
                resultScreen.SetActive(true);

                normalText.text = normalHits.ToString();
                perfectText.text = perfectHits.ToString();

                float totalHit = normalHits + perfectHits;
                float percentHit = (totalHit / totalNotes) * 100f;

                percentHitText.text = percentHit.ToString("F1") + "b" ;
            }
        }
    }

    public void NoteHit()
    {
        Debug.Log("Note Hit");
    }

    public void NormalHit()
    {
        NoteHit();
        normalHits++;
    }

    public void PerfectHit()
    {
        NoteHit();
        perfectHits++;
    }



    public void NoteMissed()
    {
        Debug.Log("Note Missed");
    }
}
