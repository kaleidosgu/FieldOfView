using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LosMask : MonoBehaviour {

    // Use this for initialization
    public Material LOSMaskMaterial;

    public Camera fowCamera;
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        //LOSMaskMaterial.SetTexture("_LOSMaskTexture", fowCamera.targetTexture);
        Graphics.Blit(source, destination, LOSMaskMaterial);
    }
}
