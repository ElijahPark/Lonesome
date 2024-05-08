using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpScare : MonoBehaviour
{

    public GameObject JumpScareImg;
    public AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        JumpScareImg.SetActive(false);
    }

    private void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            JumpScareImg.SetActive(true);
            audioSource.Play();
            StartCoroutine(DisableImg(2));
            Debug.Log("No");
            StartCoroutine(DisableImg(2));
            
        }
    }

    IEnumerator DisableImg(float time)
    {
        yield return new WaitForSeconds(time);
        JumpScareImg.SetActive(false);
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(1);

    }
}
