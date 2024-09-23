using UnityEngine;

public class Invaders : MonoBehaviour
{
    public Invaders[] prefabs;

    public int rows = 5;

    public int columns = 11;
    public float speed = 10.0f;
    private Vector3 _direction = Vector2.right;

    private void Awake()
    {
        for (int row = 0; row < this.rows; row++) 

        {
            float width = 2.0f * (this.columns - 1);
            float height = 2.0f * (this.rows - 1);
            Vector2 centering = new Vector2(-width/2, -height/2);
            Vector3  rowPosition = new Vector3(0.0f, row * 2.0f, 0.0f);
            for (int col = 0; col < this.columns; col++)
            {
                 Instantiate(this.prefabs[rows], this.transform);
                Vector3 position = rowPosition;
                position.x += col * 2.0f;
            }
        }

    }
    private void Update()
    {
        this.transform.position = _direction * speed * Time.deltaTime;

    }


}
