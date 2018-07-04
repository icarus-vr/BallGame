/* Attach this script to the GameObject parent of bowling pin GameObjects. */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingResetPins : MonoBehaviour {
    public GameObject bowlingPinPrefab;
    private GameObject bowlingPins;
    
	// Use this for initialization
	void Start () {
        bowlingPins = Instantiate(bowlingPinPrefab);
	}

    // Update is called once per frame
    void Update() {
        if (OVRInput.GetDown(OVRInput.Button.One)) {
            Destroy(bowlingPins);
            bowlingPins = Instantiate(bowlingPinPrefab);
        }
	}
}
