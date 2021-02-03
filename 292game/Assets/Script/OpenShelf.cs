using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenShelf : MonoBehaviour
{
    // Start is called before the first frame update
    public Image shelf;

    void Start() {
        // Turns the image off.
        shelf.enabled = false;
    }

    void OnMouseDown() {
        // Turns the image on if it is off, and off if it is on.
        shelf.enabled = !shelf.enabled;
    }
}
