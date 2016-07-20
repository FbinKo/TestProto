using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class CountDownTimer : MonoBehaviour {

    public float timeLeft = 300.0f;

    private float minutes;
    private float seconds;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        while (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            minutes = Mathf.Floor(timeLeft / 60);
            seconds = timeLeft % 60;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
