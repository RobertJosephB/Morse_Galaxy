using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject ufo;
    public Vector3 spawnValues;
    public int hazardCount;

    public float spawnWait;
    public float startWait;


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

            Instantiate(ufo, spawnPosition, spawnRotation);
;
            yield return new WaitForSeconds (spawnWait);
        }




    }
}