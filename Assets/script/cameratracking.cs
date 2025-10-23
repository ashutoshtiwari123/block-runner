using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Transform playertransform;
    public float offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camerapos = transform.position;
        camerapos.z = playertransform.position.z + offset;    
        transform.position = camerapos;
    }
}
