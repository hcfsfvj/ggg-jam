using UnityEngine;

public class DoorController : MonoBehaviour
{
    public AudioSource bgm1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bgm1.Play();
            gameObject.SetActive(false);
        }
    }
}
