using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Scoresystem : MonoBehaviour
{
    public static int scorevalue = 0;
    public static int missesvalue = 0;
    TextMeshProUGUI score;
    public TextMeshProUGUI misses;
    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
        //misses = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score:" + scorevalue;
        misses.text = "Misses:" + missesvalue;
    }
}
