using UnityEngine;

public class EatPlayer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Yam!");
        Destroy(gameObject);
    }
}
