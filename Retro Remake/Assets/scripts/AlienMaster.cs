using UnityEngine;
using System.Collections.Generic;

public class AlienMaster : MonoBehaviour
{


    public GameObject bulletPrefab;



    private Vector3 InMoveDistance = new Vector3(0, 0, 0);
    private Vector3 vMoveDistance = new Vector3(0, 0, 0);

    private const float MAX_LEFT = -2.5F;
    private const float MAX_RIGHT = 2.5F;
    private const float MAX_MOVE_SPEED = 0.2F;

    private float moveTimer;
    private const float moveTime = 0.005f;
    private bool movingRight;

    public static List<GameObject> allAliens = new List<GameObject>();
    private GameObject go;
    private Vector3 hMoveDistance;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("Alien")) ;
        allAliens.Add(go);

    }

    // Update is called once per frame
    void Update()
    {
        if (moveTimer <= 0)
            MoveEnimies();

        moveTimer -= Time.deltaTime;

    }

    private void MoveEnimies()
    {
        if (allAliens.Count > 0)
        {
            int hitMax = 0;
            for (int i = 0; i < allAliens.Count; i++)
            {
                if (movingRight)
                    allAliens[i].transform.position += hMoveDistance;

                allAliens[i].transform.position -= hMoveDistance;

                if (allAliens[i].transform.position.x > MAX_RIGHT || allAliens[i].transform.position.x < MAX_LEFT)
                    hitMax++;
            }
            if (hitMax > 0)
            {
                for (int i = 0; i < allAliens.Count; i++)
                    allAliens[i].transform.position = vMoveDistance;

                movingRight = !movingRight;
            }

            moveTimer = GetMoveSpeed();
        }


    }

    private float GetMoveSpeed()
    {
        float f = allAliens.Count * moveTime;

        if(f < MAX_MOVE_SPEED)
            return MAX_MOVE_SPEED;
        return f;
    }
    
        
    
    
   

    

}
