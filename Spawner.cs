using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float nexttimespawn;
    public float intervalspawn;
    public GameObject hexagonprefab;

    void Start(){
        StartCoroutine(repeater());
    }
    // Update is called once per frame
    IEnumerator repeater(){
            yield return new WaitForSeconds(nexttimespawn);
            while (true){
                Instantiate(hexagonprefab, Vector3.zero, Quaternion.identity);
                yield return new WaitForSeconds(intervalspawn);
            }
    }
}
