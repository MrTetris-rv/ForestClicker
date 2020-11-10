using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TouchDetection : MonoBehaviour
{
    [SerializeField] public Text text, numberTree, win;
    [SerializeField]GameObject win2;
    public int score = 0, p = 0, k = 0;
    static string[] formats = { "", "K", "M", "B", "T" };
    private void Start()
    {
        text.text = "0";
        numberTree.text = "0 / 40";
    }
    public void OnClick(int i)
    {
        i++;
        score += i;
        FormatNumbers(digit: score);
        Count();
        if (i == 10000000)
        {
            win2.SetActive(true);
            win.text = "YOU WIN!!!";
            Time.timeScale = 0;
        }
    }

    public string FormatNumbers(decimal digit)
    {
        int n = 0;
        while (n < formats.Length && digit >= 1000m)
        {
            digit /= 1000m;
            n++;
        }
             
        return text.text = string.Format("{0:0.#}{1}", digit, formats[n]).ToString();
    }

    public void Count()
    {

        k++;
        numberTree.text = $"{k} / 40";
        if (k == 40)
        {
            p += Random.Range(1000, 10000); //может убрать +?
            OnClick(p);
            k = 0;
            p = 0; //надо ли это?
            numberTree.text = "0 / 40";
        }
   
   
    }

}
