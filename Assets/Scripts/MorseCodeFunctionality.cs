using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class MorseCodeFunctionality : MonoBehaviour
{
    public string code;
    public int max; 
    public int input;

    public float ClickDuration = 0.2f;
    public UnityEvent OnLongClick;

    bool clicking = false;
    float totalDownTime = 0;

    public AudioSource audioSource;
    public AudioClip   ShootAudioClip;

    public GameObject letter;
    public TextMeshProUGUI MorseLetter;

    public GameObject shot;

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

        //MorseLetter = GetComponent<TextMeshProUGUI>();

    }

    void Update()
    {

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
                    //MorseLetter.text = morse[code].ToString();
                    //MorseLetter.text = "B";
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
                //MorseLetter.text = morse[code].ToString();
                //MorseLetter.text = "A";
            }
            else 
            {
                Debug.Log(" ");
            }

        }

        if(Input.GetMouseButtonDown(1))
        {
            if(morse.ContainsKey(code))
            {
                Debug.Log("Pressed right click - SHOOT " + morse[code]);
                Vector3 spawnPosition = GameObject.Find("Player").transform.position;
                Quaternion spawnRotation = Quaternion.identity;
                //MorseLetter.text = " ";

                audioSource.PlayOneShot(ShootAudioClip);
                GameObject bullet = Instantiate(shot, spawnPosition, spawnRotation) as GameObject;
                bullet.GetComponent<BulletController>().code = morse[code];
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