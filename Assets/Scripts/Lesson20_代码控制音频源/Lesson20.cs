using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson20 : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) {
            audioSource.Play();
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            audioSource.Stop();
        }
    }
}
