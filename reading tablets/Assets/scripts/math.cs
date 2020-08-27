using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class math : MonoBehaviour
{
    public UnityEngine.UI.Text firstint, secondint, symbol, attention, result;
    int first, second, symbolize, answersymbol;
    // Start is called before the first frame update
    void Start()
    {
        newquestion();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void newquestion()
    {

        attention.text = "";
        result.text = "";
        first = UnityEngine.Random.Range(1, 10);
        second = UnityEngine.Random.Range(1, 10);
        symbolize = UnityEngine.Random.Range(1, 3);
        switch (symbolize)
        {
            case 1:
                symbol.text = "+";
                answersymbol = first + second;

                break;
            case 2:
                symbol.text = "-";
                if (second > first)
                {
                    int temp = first;
                    first = second;
                    second = temp;
                }
                answersymbol = first - second;
                break;
        }
        
        firstint.text = first + "";
        secondint.text = second + "";
    }
    public void answercheck()
    {

        if (int.Parse(result.text) == answersymbol)
        {
            attention.text = "CONGRATUALIONS";
        }

        else
        {
            attention.text = "TRY AGAIN";
        }
    }
}

