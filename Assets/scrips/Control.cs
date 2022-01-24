using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    public GameObject prob;
    public GameObject winTextObject;
    public GameObject endTextObject;
    public GameObject tutorial;
    public GameObject blocker;
    public Text timeText;
    public AudioClip music;
    public AudioClip victory;
    public AudioClip fail;
    public AudioSource musicSource;
    public float timeRemaining = 12;
    public bool timerIsRunning = false;
    void Start()
    {
        timeText.text = "Time Left: " + timeRemaining.ToString();
        winTextObject.SetActive(false);
        endTextObject.SetActive(false);
        prob.SetActive(false);
        Destroy(tutorial, 2);
        timerIsRunning = true;
        quiz();
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                timeText.text = "Time Left: " + timeRemaining.ToString();
            }
            else
            {
                timeRemaining = 0;
                timeText.text = "Time Left: " + timeRemaining.ToString();
                timerIsRunning = false;
                lose();
            }
        }
    }
    void FixedUpdate()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        if (Input.GetKey("space"))
        {
            timerIsRunning = true;
            timeRemaining = 10;
            winTextObject.SetActive(false);
            endTextObject.SetActive(false);
            quiz();
        }
        if (Input.GetKey(KeyCode.I))
        {
            win();
        }
        if (Input.GetKey(KeyCode.A))
        {
            lose();
        }
        if (Input.GetKey(KeyCode.B))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.C))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.D))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.E))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.F))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.G))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.H))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.J))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.K))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.L))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.M))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.N))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.O))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.P))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.Q))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.R))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.S))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.T))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.U))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.V))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.W))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.X))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.Y))
        {
            lose();
        }

        if (Input.GetKey(KeyCode.Z))
        {
            lose();
        }


    }
    void quiz()
    {
        prob.SetActive(true);
        musicSource.clip = music;
        musicSource.Play();
        musicSource.loop = true;
    }
void win()
    {
        timeRemaining = 500;
        prob.SetActive(false);
        winTextObject.SetActive(true);
        musicSource.clip = victory;
        musicSource.Play();
        musicSource.loop = false;
    }

void lose()
    {
        timeRemaining = 0;
        prob.SetActive(false);
        endTextObject.SetActive(true);
        musicSource.clip = fail;
        musicSource.Play();
        musicSource.loop = false;
    }

}



