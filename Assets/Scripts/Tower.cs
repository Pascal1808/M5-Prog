using UnityEngine;


public class Tower : MonoBehaviour
{
    void Start()
    {
        float x = Random.Range(0f,1f);
        float y = Random.Range(0f,1f);
        float z = Random.Range(0f,1f);

        transform.localScale = new Vector3(x,y,z);
        
    }

    void Update()
    {
        
    }
}
