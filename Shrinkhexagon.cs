using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrinkhexagon : MonoBehaviour
{
    public Rigidbody2D rb;
    public float shrinkspd;
    // Start is called before the first frame update
    void Start()
    {
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 6f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.localScale -= Vector3.one * shrinkspd * Time.fixedDeltaTime;
        if(transform.localScale.x <= .05f){
            Destroy(gameObject);
        }
    }
}
