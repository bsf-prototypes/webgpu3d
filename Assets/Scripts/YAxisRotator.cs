using UnityEngine;

public class YAxisRotator : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 100.0f;

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}