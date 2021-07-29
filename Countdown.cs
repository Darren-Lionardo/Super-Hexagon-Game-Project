using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public GameObject textbox;
    public int counter = 3;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Count());
    }
    IEnumerator Count(){
        while(counter > 0){
            textbox.GetComponent<Text>().text = counter.ToString();
            yield return new WaitForSeconds(1);
            counter --;
        }
        textbox.GetComponent<Text>().text = "GO";
        yield return new WaitForSeconds(1);
        textbox.SetActive(false);
    }
}
