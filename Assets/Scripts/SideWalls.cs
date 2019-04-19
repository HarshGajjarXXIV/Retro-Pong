using UnityEngine;

public class SideWalls : MonoBehaviour
{
    public AudioClip scoreSound;

    private AudioSource source;
    void Awake() {
        source = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D hitInfo) {
        if(hitInfo.name == "Ball") {
            string wallName = transform.name;
            source.PlayOneShot(scoreSound);
            GameManager.Score(wallName);
            hitInfo.gameObject.SendMessage("ResetBall");
        }
    }
}
