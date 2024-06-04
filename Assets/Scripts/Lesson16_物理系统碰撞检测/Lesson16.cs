using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson16 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) {
        print(this.name + "被" + collision.gameObject.name + "碰到了");
    }
    private void OnCollisionExit(Collision collision) {
        print(this.name + "和" + collision.gameObject.name + "分离了");
    }
    private void OnCollisionStay(Collision collision) {
        print(this.name + "跟" + collision.gameObject.name + "一直在摩擦");
    }
}
