using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject Ufo;
    public GameObject VictoryPanel;
    public GameObject SettingsPanel;
    public Vector3 spawnValues;
    public int hazardCount;
    public int spawned = 0;

    public float spawnWait;
    public float startWait;
    public float RadNum =0f;

    char[] morseLevelOne = { 'E', 'N', 'T' };

    /*
    Dictionary<int, char> morseLevelOne = new Dictionary<int, char>()
    {
        {1, 'E'},
        {2, 'N'},
        {3, 'T'}
    };
    */

    Dictionary<string, char> morseLevelTwo = new Dictionary<string, char>()
    {
        {".", 'E'},
        {"-.", 'N'},
        {"-", 'T'},
        {"...", 'S'},
        {"--", 'M'},
        {"--.", 'G'}
    };

    Dictionary<string, char> morseLevelThree = new Dictionary<string, char>()
    {
        {".", 'E'},
        {"-.", 'N'},
        {"-", 'T'},
        {"...", 'S'},
        {"--", 'M'},
        {"--.", 'G'},
        {"...-", 'V'},
        {"-.--", 'Y'},

    };



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnEnemy () {

        yield return new WaitForSeconds (startWait);

        
        for (int i = 0; i < hazardCount; i++) {
            
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.y), spawnValues.y, spawnValues.z);
            Quaternion spawnRotation = Quaternion.identity;

            System.Random rand = new System.Random();

            GameObject ufo = Instantiate(Ufo, spawnPosition, spawnRotation) as GameObject;
            ufo.GetComponent<UfoController>().morseLetter = morseLevelOne[rand.Next(3)];


            /*
            RadNum = Random.Range(1, 4);
            if(RadNum==1)
                Instantiate(ufo1, spawnPosition, spawnRotation);
            else if(RadNum == 2)
                Instantiate(ufo2, spawnPosition, spawnRotation);
            else if(RadNum ==3)
                Instantiate(ufo3, spawnPosition, spawnRotation);
            ;
            */
            spawned++;
            Debug.Log(spawned);
            if(spawned == hazardCount)
            {
                yield return new WaitForSeconds (20);
                Debug.Log("Display Victory Panel");
                whenDoneSpawning();
            }

            yield return new WaitForSeconds (spawnWait);
        }




    }


    public void whenDoneSpawning()
    {
        if (VictoryPanel.activeInHierarchy == false)
        {
            VictoryPanel.SetActive(true);
            SettingsPanel.SetActive(false);
            Time.timeScale = 0;
        }

    }
}
