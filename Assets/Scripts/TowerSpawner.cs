using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    public GameObject towerPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float x = Random.Range(-5f, 5f);
            
            float z = Random.Range(-5f, 5f);

            Vector3 spawnPosition = new Vector3(x, 0f, z);

            Instantiate(towerPrefab, spawnPosition, Quaternion.identity);
        }
    }

}
