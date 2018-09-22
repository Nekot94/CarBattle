using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed = 10;
    public int playerNumber = 1;
    public AudioSource crash;
    public AudioSource motor;
    public float jumpSpeed = 30;
    public float rotationSpeed = 100;


	void Update ()
    {
        float move = Input.GetAxis("Horizontal" + playerNumber) * speed * Time.deltaTime;
        float rotate = Input.GetAxis("Vertical" + playerNumber) * rotationSpeed * Time.deltaTime;
        if (playerNumber == 2)
        {
            move = -move;
        }
        float moveY = 0;
        if (Input.GetButtonDown("Jump" + playerNumber))
        {
            GetComponent<Rigidbody>().AddForce(0,jumpSpeed,0);
        }
        transform.Translate(0, moveY, move);
        transform.Rotate(-rotate, 0, 0);

        if (move != 0 && !motor.isPlaying)
        {
            motor.Play();
        }
        if (move == 0)
        {
            motor.Stop();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && !crash.isPlaying)
        {
            crash.Play();
        }
    }


}
