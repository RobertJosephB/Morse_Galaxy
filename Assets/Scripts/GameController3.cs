using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController3 : MonoBehaviour
{

    public GameObject ufo1;
    public GameObject ufo2;
    public GameObject ufo3;
    public GameObject ufo4;
    public GameObject ufo5;
    public GameObject ufo6;
    public GameObject ufo7;
    public GameObject ufo8;
    public GameObject megabossVest;
    public GameObject megabossEst;
    public GameObject megabossSt;
    public GameObject megabossT;
    public Vector3 spawnValues;
    public int hazardCount;

    public float spawnWait;
    public float startWait;
    public float RadNum = 0f;
    public float bossDelay;


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


            RadNum = Random.Range(1, 9);

            switch (RadNum)
            {
                case 1:
                    Instantiate(ufo1, spawnPosition, spawnRotation);
                    break;
                case 2:
                    Instantiate(ufo2, spawnPosition, spawnRotation);
                    break;
                case 3:
                    Instantiate(ufo3, spawnPosition, spawnRotation);
                    break;
                case 4:
                    Instantiate(ufo4, spawnPosition, spawnRotation);
                    break;
                case 5:
                    Instantiate(ufo5, spawnPosition, spawnRotation);
                    break;
                case 6:
                    Instantiate(ufo6, spawnPosition, spawnRotation);
                    break;
                case 7:
                    Instantiate(ufo7, spawnPosition, spawnRotation);
                    break;
                case 8:
                    Instantiate(ufo8, spawnPosition, spawnRotation);
                    break;

                default:
                    // code block
                    break;
            }

            if (i == hazardCount - 1)
            {
                yield return new WaitForSeconds(bossDelay);
                spawnPosition = new Vector3(0, spawnValues.y, spawnValues.z);
                spawnRotation = Quaternion.identity;
                Instantiate(megabossT, spawnPosition, spawnRotation);
                //yield return new WaitForSeconds(startWait);
                Instantiate(megabossSt, spawnPosition, spawnRotation);
                //yield return new WaitForSeconds(startWait);
                Instantiate(megabossEst, spawnPosition, spawnRotation);
                //yield return new WaitForSeconds(startWait);
                Instantiate(megabossVest, spawnPosition, spawnRotation);
                //yield return new WaitForSeconds(startWait);
            }
            yield return new WaitForSeconds(spawnWait);
        }




    }
}
