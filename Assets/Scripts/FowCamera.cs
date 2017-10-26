using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FowCamera : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        var t = new RenderTexture(Screen.width, Screen.height, 16);
        Camera camera = GetComponent<Camera>();
        camera.targetTexture = t;
        Shader.SetGlobalTexture("_LOSMaskTexture", t);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
