using UnityEngine;

public class light : MonoBehaviour
{


    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector2(transform.position.x, 2.2f);
    }
}
