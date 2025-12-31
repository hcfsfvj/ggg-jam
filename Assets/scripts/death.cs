using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    public GameObject respawn;
    //public IllusionDeath illusionDeath;
    GameObject[] r;

    teleport tp;

    public GameObject door;

    public AudioSource bgm1;

    private void Awake()
    {
       r = GameObject.FindGameObjectsWithTag("r");
    }

    private void Start()
    {
       tp = GetComponent<teleport>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("damage"))
        {
            Die();
        }

        /*if(collision.CompareTag("music"))
        {
            bgm1.Play();
        }*/

    }

    public void Die()
    {
        tp.sr.flipY = false;
        tp.isr.flipY = true;

        Respawn();
        //illusionDeath.Respawn();
        foreach (GameObject obj  in r)
        {
            IllusionDeath script = obj.GetComponent<IllusionDeath>();
            script.Respawn();
        }

       // tp.freeze = true;

        bgm1.Stop();
        //bgm1.Play();
    }

    public void Respawn()
    {
        transform.position = respawn.transform.position;
        door.SetActive(true);
        Debug.Log("p res");
        // tp.freeze = false;
    }
}
