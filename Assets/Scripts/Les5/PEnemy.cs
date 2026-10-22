using UnityEngine;
 
public class PEnemy : MonoBehaviour
{
    protected float speed;
    protected int health;
 
    void Start()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.tag == "Player")
        {
         health -= 5;
         Destroy(collision.gameObject);
         if(health <= 0)
         {
            Destroy(gameObject);
         }
        }
    }
    protected void Walk()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
    // Update is called once per frame
   void Update()
    {
       Walk();
    }
}