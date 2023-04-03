using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.WebCam;

public class DesktopCapture : MonoBehaviour
{
    private WebCamTexture webCamTexture;
    private Material material;

    void Start()
    {
        // Create a new WebCamTexture
        webCamTexture = new WebCamTexture();

        // Set the requested FPS (frames per second)
        webCamTexture.requestedFPS = 30;

        // Assign the WebCamTexture to the material of the plane
        material = GetComponent<Renderer>().material;
        material.mainTexture = webCamTexture;

        // Start the WebCamTexture
        webCamTexture.Play();
    }

    void Update()
    {
        // Check if the WebCamTexture is playing and start it if it is not
        if (!webCamTexture.isPlaying)
        {
            webCamTexture.Play();
        }
    }
}
