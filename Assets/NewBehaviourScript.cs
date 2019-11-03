using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 100, 200);
    }

    // Update is called once per frame
    void Update()
    {

    }
}