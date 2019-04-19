using UnityEngine;

public class P2Control : MonoBehaviour
{
    private bool AI = MainMenu.isAI; 
    public KeyCode moveUp;
    public KeyCode moveDown;
    public float speed = 10f;
    Rigidbody2D rigid2D;
    private Transform theBall;
    private Vector2 ballPos;

    // Start is called before the first frame update
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        if(AI) {
            theBall = GameObject.FindGameObjectWithTag("Ball").transform;
            speed = DifficultyMenu.AISpeed;
        } 
    }

    // Update is called once per frame
    void FixedUpdate() {
        if(AI) {
            Move();
        }
        else {
            if(Input.GetKey(moveUp)) {
                rigid2D.velocity = new Vector3(0, speed, 0);
            } else if(Input.GetKey(moveDown)) {
                rigid2D.velocity = new Vector3(0, speed * -1, 0);
            } else {
                rigid2D.velocity = new Vector3(0, 0, 0);
            }
        }
        
    }

    void Move() {
        ballPos = theBall.localPosition;
        if(theBall.position.x > 0f) {
            if(transform.localPosition.y > -5f && ballPos.y < transform.localPosition.y) {
                transform.localPosition += new Vector3(0, -speed * Time.deltaTime, 0);
            }
            if(transform.localPosition.y < 5f && ballPos.y > transform.localPosition.y) {
                transform.localPosition += new Vector3(0, speed * Time.deltaTime, 0);
            }
        }
    }
}
