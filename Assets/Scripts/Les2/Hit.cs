using UnityEngine;
using System;
 
public class Hit : MonoBehaviour
{
    public static event Action OnPickupCollected;
    void Start()
    {
       
    }
private void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player"))
    {
        OnPickupCollected?.Invoke();
        Destroy(gameObject);
    }
}
    void Update()
    {
       
    }
}
