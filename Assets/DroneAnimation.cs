using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAnimation : MonoBehaviour {

    private Animator m_Animator;
    private bool facing = true;
    private bool scan = false;
    private bool showlaser = false;


	// Use this for initialization
	void Start () {
        m_Animator = gameObject.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Toggle Scanning");
            scan = !scan;
            showlaser = !showlaser;
            m_Animator.SetBool("IsScanning", scan);
            m_Animator.SetBool("IsShowingLaser", showlaser);
        }
    }
}
