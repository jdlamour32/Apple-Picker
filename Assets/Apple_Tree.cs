using UnityEngine;

public class Apple_Tree : MonoBehaviour
{
[Header("Inscribed")]
public GameObject applePrefab;

public float speed = 1f;

public float leftAndRightEdge = 10f;

public float changeDirChance = 0.1f;

public float appleDropDelay = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke( "DropApple", 2f );    
    }

    void DropApple() {                                                    // b
        GameObject apple = Instantiate<GameObject>( applePrefab );        // c
        apple.transform.position = transform.position;                    // d
        Invoke( "DropApple", appleDropDelay );                            // e
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if(pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        } 
        else if(pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
        
    }

    void FixedUpdate() {                                                 // b
         // Random direction changes are now time-based due to FixedUpdate()
         if ( Random.value < changeDirChance ) {                          // b
             speed *= -1; // Change direction 
         }
     }
}
