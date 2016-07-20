using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {

    public Slider healthBarSlider;
    public Text gameOverText;
    public float damageoT = 0.01f;
    public float deathTime = 2.0f;
    private bool isGameOver = false;

    void Start()
    {
        gameOverText.enabled = false;
    }

    void Update()
    {
        if (isGameOver == true)
        {
            gameOverText.enabled = true;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            StartCoroutine(DeathTimer(deathTime));
            isGameOver = false;
            Debug.Log("Apfel");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "deadly")
        {
            gameOverText.enabled = true;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            DeathTimer(deathTime);
            Debug.Log("Birne");
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "hurt" && healthBarSlider.value > 0)
        {
            healthBarSlider.value -= damageoT;
        }
        else
        {
            isGameOver = true;
        }
    }

    IEnumerator DeathTimer(float waitTime)
    {
        Debug.Log("Before Waiting 2 seconds");
        yield return new WaitForSeconds(waitTime);
        Debug.Log("After Waiting 2 Seconds");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
