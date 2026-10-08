using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    public GameObject towerPrefab;

    void Update()
    {
       // if (Input.GetMouseButtonDown(0))
        {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-5f, 5f);

            Vector3 spawnPosition = new Vector3(x, y, 0);

            Instantiate(towerPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
