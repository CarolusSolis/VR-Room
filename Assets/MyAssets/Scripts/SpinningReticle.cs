using UnityEngine;

public class SpinningReticle : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 90f; // Degrees per second, default 90

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}