using UnityEngine;

public class spin : MonoBehaviour
{

    Vector3 InitPosition;
    public float rotationSpeed = 100.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InitPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = 1 * rotationSpeed;

        rotation *= Time.deltaTime;

        transform.Rotate(0, rotation, 0);
    }
}
