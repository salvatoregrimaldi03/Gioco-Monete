using UnityEngine;
using TMPro; 
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI centerMessageText;
    
    private int score=0;
    public bool isGameOver=false;

    void Start()
    {
        UpdateScore();
        centerMessageText.gameObject.SetActive(false);
    }

    //Aggiunge un punto al punteggio e aggiorna il testo
    public void AddScore()
    {
        if(isGameOver) 
            return;

        score++;
        UpdateScore();
    }

    private void UpdateScore()
    {
        scoreText.text="Score: " +score;
    }

    //Mostra il messaggio di Game Over e ferma il gioco
    public void TriggerGameOver()
    {
        if (isGameOver) 
            return;

        isGameOver=true;
        centerMessageText.text="Game Over";
        centerMessageText.color=Color.red;
        centerMessageText.gameObject.SetActive(true);
    }

    //Mostra il messaggio di vittoria e ferma il gioco
    public void TriggerWin()
    {
        if (isGameOver) 
            return;

        isGameOver=true;
        centerMessageText.text="Win";
        centerMessageText.color=Color.green;
        centerMessageText.gameObject.SetActive(true);
        Time.timeScale=0f; //Ferma il gioco (EXTRA)
    }

    public void ResetGame()
    {
        Time.timeScale=1f; //Ripristina il tempo normale
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}