using UnityEngine;
using System.Collections;

public class falle : MonoBehaviour {

    Animator anim;
    public float triggerTime;
    public float activeTime;

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {

        anim.SetBool("hit", false);
	
	}

    //aktiviert die animation wenn trigger ausgelöst wird
    /*void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(Hit());
        }
    }*/

    //ablauf, wenn animation ausgelöst
    /*IEnumerator Hit()
    {
        yield return new WaitForSeconds(triggerTime);
        anim.SetBool("hit", true);
        gameObject.tag = "deadly";
        yield return new WaitForSeconds(activeTime);
        //gameObject.tag = "neutralized";
    }*/
}
