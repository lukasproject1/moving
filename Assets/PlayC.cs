using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayC : MonoBehaviour

{
    public float speed;
    private bool isGrounded = false;
    private int amountOfJumps = 2;
    private int mijnIntje = 10;
    public GameObject miObject;
    // Start is called before the first frame update
    void Start()

    {
        RaycastHit2D hit;
        Physics2D.Raycast(transform.position, Vector2.up);

        Ray2D ray = new Ray2D(transform.position, Vector2.down);






    }

    // Update is called once per frame
    void Update()
        
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            if (amountOfJumps > 1)
            {

                rb.AddForce(Vector2.up * speed);
                amountOfJumps--;
            }
            
        }



        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);
        if (hit.collider != null)
        {
            float distanceToHitObject = Vector2.Distance(transform.position, hit.point);
            Debug.Log(distanceToHitObject);
            isGrounded = true;
            if (distanceToHitObject <1f)
            {
                Debug.Log(hit.collider.gameObject.name);
                amountOfJumps = 2;
             
                Debug.Log("m'n code is hier aangekomen");
            }
        }
    }
}
//het is point in plaats van positie