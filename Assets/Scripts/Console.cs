using UnityEngine;

public class Console : MonoBehaviour
{
        public GameObject Box;
        string Naam = "Naam: erwin";
        public int Health = 100;
        public bool Leeft = true;
    void Start()
    {

        Debug.Log(Naam);
        Debug.Log("Leeft: " + Leeft);
        Debug.Log("Health: " + Health);

    }

    void Update()
    {
        Begroet("Erwin");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Health -= 25;
            Debug.Log("Health: " + Health);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Health += 80;
            Debug.Log("Health: " + Health);
        }
        if(Health <= 0)
        {
            Leeft = false;
            Debug.Log("Leeft: " + Leeft);
            Destroy(Box);
        }

        
        
    }

    void Begroet(string naam)
    {
        Debug.Log("Hallo " + naam);
    }
}
