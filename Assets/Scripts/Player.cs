using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    private Rigidbody thisRigidb = null;
    public float force;

    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
        thisRigidb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisRigidb.AddForce(Vector3.up * force);
            thisAnimation.Play();
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "obs")
        {
            GameManager.thisManager.GameOver();

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "point")
        {
            Destroy(other.gameObject);
            GameManager.thisManager.UpdateScore(10);

        }
    }
}
