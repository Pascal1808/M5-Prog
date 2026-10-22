using UnityEngine;
 
public class Elf : PEnemy
{
    private MeshRenderer meshRenderer;
    private float timer;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        speed = 3f;
        health = 10;
        timer = 0f;
    }
 
    private void ToggleInvis()
    {
        timer += Time.deltaTime;
        if(timer >= 3f)
        {
            timer = 0f;
            if(meshRenderer.enabled == false)
            {
               meshRenderer.enabled = true;
            }
            else
            {
                meshRenderer.enabled = false;
            }
        }
    }
 
    private void Update()
    {
        Walk();
        ToggleInvis();
    }
}