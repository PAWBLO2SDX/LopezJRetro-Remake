
using UnityEngine;

public class projectile : MonoBehaviour
{
    public Vector3 direction;

    public float speed;

    public void Update()
    {
        this.transform.position += this.direction * this.speed * Time.deltaTime;
    }

}
