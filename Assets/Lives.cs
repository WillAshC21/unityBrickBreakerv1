using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Lives : MonoBehaviour {
    Text text;
    public static int lives = 3;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "Lives: " + lives.ToString();
        if (lives < 0)
        {
            Application.LoadLevel("Retry");
        }
	}
	}

