using UnityEngine;
 
public class ShootFromCamera : MonoBehaviour
{
    public GameObject projectilePrefab; //vergeet geen prefab in te slepen via de inspector
    private Plane floor;
    void Start()
    {
        floor = new Plane(Vector3.up, 0);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            float dist;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (floor.Raycast(ray, out dist)) {
                GameObject p = Instantiate(projectilePrefab, transform.position, transform.rotation);
                Vector3 tPos = ray.GetPoint(dist);
                p.transform.LookAt(tPos);
                p.AddComponent<MoveProj>();
                Destroy(p,5f);
            }
        }
    }
}
public class MoveProj : MonoBehaviour
{
    private float moveSpeed = 20f;
    void Update()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }
}