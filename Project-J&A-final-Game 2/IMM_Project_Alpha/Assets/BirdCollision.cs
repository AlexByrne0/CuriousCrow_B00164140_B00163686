using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Oak"))
        {
            transform.position = new Vector3(-7.2f, 0f, 0f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Oak"))
        {
            transform.position = new Vector3(-7.2f, 0f, 0f);
        }
    }
}


