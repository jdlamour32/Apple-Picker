using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float  bottomY = -20f;
    // Update is called once per frame
    void Update()
    {
        if ( transform.position.y < bottomY ) {
            Destroy( this.gameObject );       
            Apple_Picker apScript = Camera.main.GetComponent<Apple_Picker>();           // b
            // Call the public AppleMissed() method of apScript
            apScript.AppleMissed();                            
        }
    }
}
