using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using System;
using TMPro;

public class MorseFunctionality : MonoBehaviour
{
    public string code;
    public int max; 
    public int input;

    public float ClickDuration = 0.2f;
    public UnityEvent OnLongClick;

    bool clicking = false;
    float totalDownTime = 0;

    public new AudioSource audio;
    public TextMeshProUGUI morseCode;

    public Dictionary<string, char> morse = new Dictionary<string, char>()
    {
        {".-", 'A'},
        {"-...", 'B'},
        {"-.-.", 'C'},
        {"-..", 'D'},
        {".", 'E'},
        {"..-.", 'F'},
        {"--.", 'G'},
        {"....", 'H'},
        {"..", 'I'},
        {".---", 'J'},
        {"-.-", 'K'},
        {".-..", 'L'},
        {"--", 'M'},
        {"-.", 'N'},
        {"---", 'O'},
        {".--.", 'P'},
        {"--.-", 'Q'},
        {".-.", 'R'},
        {"...", 'S'},
        {"-", 'T'},
        {"..-", 'U'},
        {"...-", 'V'},
        {".--", 'W'},
        {"-..-", 'X'},
        {"-.--", 'Y'},
        {"--..", 'Z'},       
    };    

    // Start is called before the first frame update
    void Start()
    {
        code = "";
        max = 5;
        input = 0;
        audio.volume =0.4f;
        audio.Stop();

        morseCode = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            totalDownTime = 0;
            clicking = true;
            StartCoroutine(AudioFadeScript.clickCheck(audio));
        }

        if (clicking && Input.GetMouseButton(0))
        {
            totalDownTime += Time.deltaTime;

            if (totalDownTime >= ClickDuration)
            {
                clicking = false;
                input++;
                code += '-';

                if(input >= max)
                {
                    code = "";
                    input = 0;
                }

                morseCode.text = code;

            }
        }

        if (clicking && Input.GetMouseButtonUp(0))
        {
            clicking = false;
            input++;
            code += '.';

            if(input >= max)
            {
                code = "";
                input = 0;
            }

            morseCode.text = code;

        }

        if(Input.GetMouseButtonDown(1))
        {
            code = "";
            input = 0;
            morseCode.text = code;
        }

        
    }
}
