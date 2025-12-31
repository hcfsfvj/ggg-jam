using UnityEngine;

public class GlitchAnim : MonoBehaviour
{
    Animator ani;

    [Header("Glitch Timing")]
    public float minDelay = 2f;
    public float maxDelay = 6f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ani = GetComponent<Animator>();
        StartCoroutine(GlitchRoutine());
    }

    System.Collections.IEnumerator GlitchRoutine()
    {
        while (true)
        {
            float waitTime = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(waitTime);

            ani.SetTrigger("glitch");
        }
    }
}
