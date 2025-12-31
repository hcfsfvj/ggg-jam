using UnityEngine;

public class GlitchController : MonoBehaviour
{
    Animator animator;

    [Header("Timing")]
    public float minDelay = 2f;
    public float maxDelay = 6f;

    [Header("Chances (0–1)")]
    public float glitchChance = 0.6f;
    public float disappearChance = 0.4f;

    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(RandomRoutine());
    }

    System.Collections.IEnumerator RandomRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));

            float roll = Random.value;

            if (roll < glitchChance)
                animator.SetTrigger("Glitch");
            else
                animator.SetTrigger("dis");
        }
    }
}
