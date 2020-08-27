using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyboard1 : MonoBehaviour
{

    string word = null;
    int wordIndex = 0;
    string alpha;
    public Text Text = null;
    // Use this for initialization

    public void alphabetFunction(string alphabet)
    {
        wordIndex++;
        word = word + alphabet;
        Text.text = word;

    }
}