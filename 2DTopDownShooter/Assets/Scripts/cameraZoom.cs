using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraZoom : MonoBehaviour {
    public Camera m_OrthographicCamera;
    public float Size = 5f; //how zoomed in the camera currently is
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {

        if (Input.GetKey("space")) //this is just a test value, I should rebind it to getinput at some point
        {
            if (m_OrthographicCamera.orthographicSize == 5.0f)
            {
                m_OrthographicCamera.orthographicSize = 3.0f;
            } //when zoomed in lower movement speed
            
        }
        else if (m_OrthographicCamera.orthographicSize == 3.0f)
        {
            m_OrthographicCamera.orthographicSize = 5.0f;
        }
       
    }
}
