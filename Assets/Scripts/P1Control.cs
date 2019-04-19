using UnityEngine;

public class P1Control : MonoBehaviour
{
    public KeyCode moveUp;
    public KeyCode moveDown;
    public float speed = 10f;
    Rigidbody2D rigid2D;
    // Start is called before the first frame update
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(moveUp)) {
            rigid2D.velocity = new Vector3(0, speed, 0);
        } else if(Input.GetKey(moveDown)) {
            rigid2D.velocity = new Vector3(0, speed * -1, 0);
        } else {
            rigid2D.velocity = new Vector3(0, 0, 0);
        }
    }
}
