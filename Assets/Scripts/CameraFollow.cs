using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; 
    public GameManager gameManager;
    public Vector3 offset=new Vector3(0, 4, -8);

    //Usa LateUpdate per assicurarsi che la camera segua dopo che il player si è mosso
    void LateUpdate()
    {
        //Se il gioco è in Game Over e il player è caduto giù, smetti di seguire
        if(gameManager.isGameOver && target.position.y<-3f)
            return;

        if (target!=null)
            transform.position=target.position + offset;
    }
}