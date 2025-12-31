using UnityEngine;

public class IllusionDeath : MonoBehaviour
{
    public GameObject respwan;
    public void Respawn()
    {
       Debug.Log("respwaned");
       transform.position = respwan.transform.position;
    }
}
