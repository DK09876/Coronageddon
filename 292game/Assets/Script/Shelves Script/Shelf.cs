using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shelf : MonoBehaviour
{
    public GameObject panel;
    private void OnMouseUpAsButton() {
        panel.SetActive(true);
    }
    
    void Update() {
        if (Input.GetMouseButtonDown(1)) {
            panel.SetActive(false);
        }
    }
}
