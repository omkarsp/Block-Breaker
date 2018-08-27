using UnityEngine;

public class Ball : MonoBehaviour {

    //config parameters
    [SerializeField] Paddle paddle1;
    [SerializeField] float xComponent;
    [SerializeField] float yComponent;
    [SerializeField] AudioClip[] ballSounds;
    [SerializeField] float randomFactor = 0.2f;

    //State
    Vector2 paddleToBallVector;
    bool hasStarted = false;
    
    //Cached component references
    AudioSource myAudioSource;
    Rigidbody2D myRigidBody2D;
    
    // Use this for initialization
    void Start ()
    {
        paddleToBallVector = transform.position - paddle1.transform.position;
        myAudioSource = GetComponent<AudioSource>();
        myRigidBody2D = GetComponent<Rigidbody2D>();
        //GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;s
    }
	
	// Update is called once per frame
	void LateUpdate ()
    {
        if (hasStarted == false)
        {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
	}

    private void LaunchOnMouseClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            myRigidBody2D.velocity=new Vector2(xComponent,yComponent);
            hasStarted = true;
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 velocityTweak = new Vector2
            ( Random.Range(-randomFactor, randomFactor),
              Random.Range(-randomFactor, randomFactor) );


        if (hasStarted == true)
        {
            AudioClip clip = ballSounds[Random.Range(0, ballSounds.Length)];
            myAudioSource.PlayOneShot(clip);
            myRigidBody2D.velocity += velocityTweak;
        }
    }
}
    