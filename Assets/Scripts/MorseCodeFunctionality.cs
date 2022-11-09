using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;


public class MorseCodeFunctionality : MonoBehaviour
{

    private float startTime, endTime; 
    //public List<string> input = new List<string>();
    public string code;
    public int max; 
    public int input;

    public float ClickDuration = 0.2f;
    public UnityEvent OnLongClick;

    bool clicking = false;
    float totalDownTime = 0;

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


    void Start()
    {
        code = "";
        max = 5;
        input = 0;
        startTime = 0f;
        endTime = 0f;
    }

    void Update()
    {

        //if(Input.GetMouseButtonDown(0)) Debug.Log("Pressed left click.");
        //if(Input.GetMouseButtonDown(1)) Debug.Log("Pressed right click.");
        //if(Input.GetMouseButtonDown(2)) Debug.Log("Pressed middle click.");

        //if(Input.GetMouseButtonDown(0)) Debug.Log("Pressed left click - .");
        //if(Input.GetMouseButton(0)) Debug.Log("Long pressed left click - -");

        if (Input.GetMouseButtonDown(0))
        {
            totalDownTime = 0;
            clicking = true;
        }

        if (clicking && Input.GetMouseButton(0))
        {
            totalDownTime += Time.deltaTime;

            if (totalDownTime >= ClickDuration)
            {
                //Debug.Log("Long click");
                clicking = false;
                //OnLongClick.Invoke();
                //Debug.Log("Long Pressed left click - -");
                input++;
                code += '-';

                if(input >= max)
                {
                    Debug.Log("Max input reached");
                    code = "";
                    input = 0;
                }

                if(morse.ContainsKey(code))
                {
                    Debug.Log(morse[code]);
                }
                else 
                {
                    Debug.Log(" ");
                }
            }
        }

        if (clicking && Input.GetMouseButtonUp(0))
        {
            clicking = false;
            //Debug.Log("Pressed left click - .");
            input++;
            code += '.';

            if(input >= max)
            {
                Debug.Log("Max input reached");
                code = "";
                input = 0;
            }

            if(morse.ContainsKey(code))
            {
                Debug.Log(morse[code]);
            }
            else 
            {
                Debug.Log(" ");
            }

        }


        //if(Input.GetMouseButtonDown(0)) 
        //{
        //    Debug.Log("Pressed left click - .");
        //    input++;
        //    code += '.';

        //    if(input >= max)
        //    {
        //        Debug.Log("Max input reached");
        //        code = "";
        //        input = 0;
        //    }
        //}

        //if(Input.GetMouseButtonDown(2))
        //{
        //    Debug.Log("Pressed middle click - -");
        //    input++;
        //    code += '-';

        //    if(input >= max)
        //    {
        //        Debug.Log("Max input reached");
        //        code = "";
        //        input = 0;
        //    }
        //}

        if(Input.GetMouseButtonDown(1))
        {
            if(morse.ContainsKey(code))
            {
                Debug.Log("Pressed right click - SHOOT " + morse[code]);
            }
            else 
            {
                Debug.Log(" ");
            }
            code = "";
            input = 0;
        }

        
    }

}