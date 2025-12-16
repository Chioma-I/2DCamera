using UnityEngine;

public class QuickMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.right * Input.GetAxis("Horizontal");
        Vector3 evmo = Vector3.up * Input.GetAxis("Vertical");
        transform.Translate(move* speed * Time.deltaTime);
        transform.Translate(evmo * speed * Time.deltaTime);
    }
}
