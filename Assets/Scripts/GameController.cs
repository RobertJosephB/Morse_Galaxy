using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject ufo1;
    public GameObject ufo2;
    public GameObject ufo3;
    public Vector3 spawnValues;
    public int hazardCount;

    public float spawnWait;
    public float startWait;
    public float RadNum =0f;


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


            RadNum = Random.Range(1, 4);
            if(RadNum==1)
                Instantiate(ufo1, spawnPosition, spawnRotation);
            else if(RadNum == 2)
                Instantiate(ufo2, spawnPosition, spawnRotation);
            else if(RadNum ==3)
                Instantiate(ufo3, spawnPosition, spawnRotation);
            ;
            yield return new WaitForSeconds (spawnWait);
        }




    }
}
