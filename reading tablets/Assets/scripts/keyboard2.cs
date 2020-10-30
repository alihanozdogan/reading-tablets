using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEditor;

public class keyboard2 : MonoBehaviour
{
    private const string Path = "test";
    public Text text;
    public string word = null;
    int wordIndex = 0;
    string alpha = null;
    string alpha2 = null;
    char[] nameChar = new char[1000];
    public Text index = null;
    public Text Text = null;
    string path = "Assets/word.txt";

    void Start(){
        wordSaver();
            
    }
      
     public void alphabetFunction(string alphabet)
    {
        
        wordIndex++;
        char[] keepchar = alphabet.ToCharArray();
        nameChar[wordIndex] = keepchar[0];
        alpha = nameChar[wordIndex].ToString();
        word += alphabet;
        Text.text = word;
        index.text = wordIndex.ToString();

        
        PlayerPrefs.SetString ("wordi2", word);
        Debug.Log(word);
       
        }
    public void backspace() {
    
        if (wordIndex >= 0 )
        {
            wordIndex--;
            alpha2 = null;
            for(int i = 1; i < wordIndex + 1; i++)
            {
                alpha2 += nameChar[i].ToString();

            }
            word = alpha2;
            Text.text = word;
            index.text = wordIndex.ToString();
            
        }
    
    }
  
    public void changescene()
    {
        SceneManager.LoadScene("a-h");
            
    }
    public void changescene2()
    {
        SceneManager.LoadScene("r-z");
     
    }
    public void changescene3()
    {
        SceneManager.LoadScene("ı-p");
      
    }
    public void wordSaver(){
        if(SceneManager.GetActiveScene().buildIndex > 0 && SceneManager.GetActiveScene().buildIndex < 5){
        text.text = PlayerPrefs.GetString("wordi2") +word ;   
        
    }
  
    
   
}






}