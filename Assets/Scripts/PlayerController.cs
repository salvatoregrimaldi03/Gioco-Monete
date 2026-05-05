using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed=5f;
    public float jumpForce=5f;
    
    private Rigidbody rb;
    private bool isGrounded=true;
    public GameManager gameManager;

    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(gameManager.isGameOver) 
            return;

        //Movimento (Avanti, Indietro, Destra, Sinistra)
        float moveX=Input.GetAxis("Horizontal");
        float moveZ=Input.GetAxis("Vertical");
        
        Vector3 movement=new Vector3(moveX, 0f, moveZ);
        rb.AddForce(movement * moveSpeed);

        //Salto con barra spaziatrice
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded=false;
        }

    
        if(transform.position.y<-3f)
            gameManager.TriggerGameOver();
    }

    //Controlla se il giocatore è a terra per poter saltare di nuovo
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded=true;
    }

    private void OnTriggerEnter(Collider other)
    {
        //Se il giocatore tocca una moneta, aumenta il punteggio e distrugge la moneta
        if(other.gameObject.CompareTag("Coin"))
        {
            gameManager.AddScore();
            Destroy(other.gameObject); //La moneta scompare
        }
        //Altrimenti, se tocca il traguardo, vince
        else if(other.gameObject.CompareTag("Finish"))
            gameManager.TriggerWin();
    }
}