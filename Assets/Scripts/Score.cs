using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static float PinCount = 0;
    public Text text;

    void Start()
    {
        PinCount = 0;
    }

    void Update()
    {

        text.text = PinCount.ToString();
            
    }
}
