using UnityEngine;

public class RotateGameObject : MonoBehaviour
{
    public float rotationRate = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("GameObject's Rotation Started!!!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back, rotationRate * Time.deltaTime);
    }
}
