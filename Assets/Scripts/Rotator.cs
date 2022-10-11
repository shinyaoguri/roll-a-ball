using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(1,1,-1), 50 * Time.deltaTime);
    }
}
