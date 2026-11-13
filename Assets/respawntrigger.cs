using UnityEngine;

public class ResetTrigger : MonoBehaviour

{

    public float threshold;

    public Checkpoint checkpoint;

    private void Start()

    {

        checkpoint = GetComponent<Checkpoint>();

    }

    private void FixedUpdate()

    {

        if (transform.position.y < threshold)

        {

            Debug.Log(checkpoint.vectorPoint);

            transform.position = checkpoint.vectorPoint;

        }

    }

}
