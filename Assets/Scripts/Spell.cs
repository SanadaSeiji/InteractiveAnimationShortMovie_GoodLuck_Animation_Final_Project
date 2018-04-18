using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour {

    public GameObject Smile;
    public GameObject Goo;
    public GameObject Good;
    public GameObject Lu;
    public GameObject Luck;

	// Use this for initialization
	void Start () {

        Smile.SetActive(true);
        Goo.SetActive(false);
        Good.SetActive(false);
        Lu.SetActive(false);
        Luck.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.S))
        {
            Smile.SetActive(true);
            Goo.SetActive(false);
            Good.SetActive(false);
            Lu.SetActive(false);
            Luck.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            Smile.SetActive(false);
            Goo.SetActive(true);
            Good.SetActive(false);
            Lu.SetActive(false);
            Luck.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Smile.SetActive(false);
            Goo.SetActive(false);
            Good.SetActive(true);
            Lu.SetActive(false);
            Luck.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Smile.SetActive(false);
            Goo.SetActive(false);
            Good.SetActive(false);
            Lu.SetActive(true);
            Luck.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Smile.SetActive(false);
            Goo.SetActive(false);
            Good.SetActive(false);
            Lu.SetActive(false);
            Luck.SetActive(true);
        }

    }
}
