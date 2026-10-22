using UnityEngine;
using System;
public class Hit : MonoBehaviour
{
    public static event Action OnHit;

    private void OnTriggerEnter(Collider other)
    { 
        if (other.CompareTag("Player"))
        {
            OnHit?.Invoke();
            Debug.Log("Ik vernietig: " + gameObject.name);
            Destroy(gameObject);
        }
    }
}
