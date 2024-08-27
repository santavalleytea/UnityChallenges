using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour {
    public GameObject dogPrefab;
    public float timer = 2.0f;
    public float countDown = 0.0f;

    // Update is called once per frame
    void Update() {
        countDown += Time.deltaTime;
        if (countDown >= timer) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                spawnDog();
                countDown = 0;
            }
        }
    }
    void spawnDog() {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}
