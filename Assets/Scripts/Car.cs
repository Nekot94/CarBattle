using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed = 10;
    public int playerNumber = 1;

	void Start ()
    {
		
	}

	void Update ()
    {
        float move = Input.GetAxis("Horizontal" + playerNumber) * speed * Time.deltaTime;
        if (playerNumber == 2)
        {
            move = -move;
        }
        transform.Translate(0, 0, move);
    }


}
