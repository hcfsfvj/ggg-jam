using UnityEditor;
using UnityEngine;

public class movement : MonoBehaviour
{
    public AudioSource bgm1;

    Rigidbody2D rb;
    public float speed;

    //bool done = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {       
        Vector2 position = rb.position;
        position.x = position.x + speed * Time.fixedDeltaTime;
        rb.MovePosition(position);
       // Debug.Log("moved");

       /* if (!done)
        {
            bgm1.Play();
            done = true;
        }*/
          
    }


}
