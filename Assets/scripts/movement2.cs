using UnityEngine;

public class movement2 : MonoBehaviour
{
    public float speed = 3f;

    void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.fixedDeltaTime);
    }
}
