using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Projectile laserprefab;

    public float speed = 5.0f;

    private bool _laserActive;


   

    private void Update()
    {
        /*if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * this.speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * this.speed * Time.deltaTime;
        }*/
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            Shoot();
        }
        
    }



    private void Shoot()
    {
        Instantiate(this.laserprefab, this.transform.position, Quaternion.identity);
    }

    
   

   
}