using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
        [SerializeField] ParticleSystem finishEffect;
        bool hasFinished = false;
void OnTriggerEnter2D(Collider2D other) 
{
    if(other.tag == "Player" && !hasFinished)
    {
        hasFinished = true;
        finishEffect.Play();
        GetComponent<AudioSource>().Play();
        Invoke("ReloadScene", 1f);
    }    
}
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
