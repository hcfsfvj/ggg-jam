using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.Rendering;


public class teleport : MonoBehaviour
{
   // public bool freeze = false;

    public GameObject illusion;

    public float minTime;
    float startTime;
    public float tpDistance;

    bool holding = false;

    public GameObject Track;

    public SpriteRenderer sr;
    public SpriteRenderer isr;

    Animator ani;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        isr = illusion.GetComponent<SpriteRenderer>();

        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

       // if (!freeze)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Swap();
                startTime = Time.time;
                holding = true;

                ani.SetTrigger("pressed");
            }
            if (Input.GetKey(KeyCode.Space) && holding)
            {

            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                //holding = false;

                //float heldTime = Time.time - startTime;
               // if (heldTime < minTime)
               // {
                    Swap();

                  
                //sr.flipX = false;
                //  }
                // else
                //  {
                // tp();
                //  }
            }
        }
    }
   
    void Swap()
    {
        Vector2 pos = transform.position;
        Vector2 Ipos = illusion.transform.position;
        Vector2 Tpos = Track.transform.position;

        transform.position = Ipos;
        illusion.transform.position = pos;
        Tpos.x = pos.x;
        Track.transform.position = Tpos;

        //pos.y = -6.5f;
        //Ipos.y = 0;

        sr.flipY = !sr.flipY;
        isr.flipY = !isr.flipY;

        ani.SetTrigger("glitch");

    }

    /*void tp()
    {
        Debug.Log("tp");

        Vector2 position = transform.position;
        position.x += tpDistance;
        transform.position = position;

        float y = transform.position.y * 2;
        Vector2 xy = transform.position;
        xy.y = xy.y - y;

        illusion.transform.position = xy;

        Vector2 track;
        track.y = 2.2f;
        track.x = transform.position.x;
        Track.transform.position = track;

    }*/

}
