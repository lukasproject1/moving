using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MonoBehaviourScript : MonoBehaviour
{
    private GameObject ground;
    public Texture2D tex;
    public Color startcolor= Color.white ;
    
    void Start()
    {
       
        ground = GameObject.Find("ground");
        

    }

    // Update is called once per frame
    void Update()
    {
        Color color = Color.Lerp(GetComponent<SpriteRenderer>().color, Color.blue, Time.deltaTime);
        GetComponent<SpriteRenderer>().color = color;
    }
   private void OnCollisionEnter2D (Collision2D col)
    {
       col.gameObject.GetComponent<SpriteRenderer>().color =Color. white;
        GetComponent<SpriteRenderer>().color = Color.white;
    }
     void OnCollisionExit2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<SpriteRenderer>().color = Color.Lerp(GetComponent<SpriteRenderer>().color, Color.blue, Time.deltaTime); ;
        //gameObject.GetComponent<SpriteRenderer>().color = startcolor;
    }
}
