
using UnityEngine;
using Random = UnityEngine.Random;


public class Obsticle : MonoBehaviour
{
    public float speed = 3;
    public float xOffset = 2;
    public float yOffset = 2;
    

    // Start is called before the first frame update
    void Start()
    {
        Vector2 offset = new();
        offset.x += Random.Range(-xOffset, xOffset);
        offset.y += Random.Range(-yOffset, yOffset);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if(transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
