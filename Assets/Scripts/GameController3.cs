using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController3 : MonoBehaviour
{

    public GameObject Ufo;
    public Vector3 spawnValues;
    public int hazardCount;

    public float spawnWait;
    public float startWait;
    public float RadNum = 0f;
    public float BossDelay;
    public float BossGravity;
    private Rigidbody2D rb;

    char[] morseLevelOne = { 'E', 'N', 'T', 'S', 'M', 'G','V','Y' };


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
        {"-.--", 'Y'}

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

    IEnumerator spawnEnemy()
    {

        yield return new WaitForSeconds(startWait);

        for (int i = 0; i < hazardCount; i++)
        {

            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.y), spawnValues.y, spawnValues.z);
            Quaternion spawnRotation = Quaternion.identity;

            System.Random rand = new System.Random();

            GameObject ufo = Instantiate(Ufo, spawnPosition, spawnRotation) as GameObject;
            ufo.GetComponent<UfoController>().morseLetter = morseLevelOne[rand.Next(8)];




            if(i == hazardCount - 1)
            {
                
                yield return new WaitForSeconds(BossDelay);
                spawnPosition = new Vector3(0, spawnValues.y, spawnValues.z);
                spawnRotation = Quaternion.identity;
                ufo = Instantiate(Ufo, spawnPosition, spawnRotation) as GameObject;
                ufo.GetComponent<UfoController>().morseLetter2 = 'T' ;
                rb = ufo.GetComponent<Rigidbody2D>();
                rb.gravityScale = BossGravity;

                spawnPosition = new Vector3(0, spawnValues.y, spawnValues.z);
                spawnRotation = Quaternion.identity;
                ufo = Instantiate(Ufo, spawnPosition, spawnRotation) as GameObject;
                ufo.GetComponent<UfoController>().morseLetter2 = 'S';
                rb = ufo.GetComponent<Rigidbody2D>();
                rb.gravityScale = BossGravity;

                spawnPosition = new Vector3(0, spawnValues.y, spawnValues.z);
                spawnRotation = Quaternion.identity;
                ufo = Instantiate(Ufo, spawnPosition, spawnRotation) as GameObject;
                ufo.GetComponent<UfoController>().morseLetter2 = 'E';
                rb = ufo.GetComponent<Rigidbody2D>();
                rb.gravityScale = BossGravity;

                spawnPosition = new Vector3(0, spawnValues.y, spawnValues.z);
                spawnRotation = Quaternion.identity;
                ufo = Instantiate(Ufo, spawnPosition, spawnRotation) as GameObject;
                ufo.GetComponent<UfoController>().morseLetter2 = 'V';
                rb = ufo.GetComponent<Rigidbody2D>();
                rb.gravityScale = BossGravity;
            }
            yield return new WaitForSeconds(spawnWait);
        }
    }
}
