﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class howtoplaybutton : MonoBehaviour
{

    public void SetText(string text)
    {
        Text txt = transform.Find("Text").GetComponent<Text>();
        txt.text = text;
        SceneManager.LoadScene("How To Play");
    }
}
