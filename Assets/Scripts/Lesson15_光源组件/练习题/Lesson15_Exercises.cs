using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson15_Exercises : MonoBehaviour {
    public new Light light;
    public Transform directionalLight;
    public float moveSpeed = 10;
    public float flashSpeed = 10;
    public float changeDarkOrLightSpeed = 10;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (light != null) {
            light.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime, Space.World);
            if (light.transform.position.x >= 1) {
                moveSpeed = -moveSpeed;
            } else if (light.transform.position.x <= 0.8f) {
                moveSpeed = -moveSpeed;
            }
            light.intensity += flashSpeed * Time.deltaTime;
            if (light.intensity >= 1) {
                flashSpeed = -flashSpeed;
            } else if (light.intensity <= 0.5f) {
                flashSpeed = -flashSpeed;
            }
        }
        directionalLight.Rotate(Vector3.right * changeDarkOrLightSpeed * Time.deltaTime, Space.Self);
        
    }
}
