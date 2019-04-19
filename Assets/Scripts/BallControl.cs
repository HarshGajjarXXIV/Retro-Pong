using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour
{
    public float ballSpeed = 100f;
    public AudioClip hitSound;
    private Rigidbody2D rigid2D;
    private AudioSource source;
    
    void Start() {
        rigid2D = GetComponent<Rigidbody2D>();
        Invoke("FireBall", 2);
    }

    void Awake () {
        source = GetComponent<AudioSource>();
    }

    void ResetBall() {
        Vector2 ballVelocity = rigid2D.velocity;
        Vector2 ballPosition = transform.position;

        ballVelocity = new Vector2(0f, 0f);
        ballPosition = new Vector2(0f, 0f);
        
        rigid2D.velocity = ballVelocity;
        transform.position = ballPosition;
        
        Invoke("FireBall", 2);
    }

    void FireBall() {
        float randomNumber = Random.Range(0, 2);
        
        if(randomNumber <= 0.5) {
            rigid2D.AddForce(new Vector2(ballSpeed, 10));
        } else {
            rigid2D.AddForce(new Vector2(-ballSpeed, -10));
        }
    }

    void Update() {
        float ballXVel = rigid2D.velocity.x;
        Vector2 ballVelocity = rigid2D.velocity;
        // Debug.Log("Velocity:" + ballXVel);
        if(ballXVel < 19 && ballXVel > -19 && ballXVel != 0) {
            if(ballXVel > 0) {
                ballVelocity.x = 20f;
            } else {
                ballVelocity.x = -20f;
            }
            rigid2D.velocity = ballVelocity;
        }
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collinfo) {

        Vector2 ballVelocity = rigid2D.velocity;

        if(collinfo.collider.tag == "Player") {
            ballVelocity.y = rigid2D.velocity.y/2 + collinfo.collider.GetComponent<Rigidbody2D>().velocity.y/2;
            rigid2D.velocity = ballVelocity;
            source.pitch = Random.Range(0.8f, 1.3f);
            source.PlayOneShot(hitSound,1f);
        }
    }
}
