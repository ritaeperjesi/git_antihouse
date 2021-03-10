using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public Camera Camera;

    public RenderTexture EyeCubemap;
    public RenderTexture EquirectTexture;

    // Start is called before the first frame update
    void Start()
    {
        Camera.stereoSeparation = 0.064f; // 64mm
    }

    // Update is called once per frame
    void Update()
    {
        Camera.RenderToCubemap(EyeCubemap, 63, Camera.MonoOrStereoscopicEye.Left);
        EyeCubemap.ConvertToEquirect(EquirectTexture, Camera.MonoOrStereoscopicEye.Left);

        Camera.RenderToCubemap(EyeCubemap, 63, Camera.MonoOrStereoscopicEye.Right);
        EyeCubemap.ConvertToEquirect(EquirectTexture, Camera.MonoOrStereoscopicEye.Right);

        // Creates buffer
        Texture2D tempTexture = new Texture2D(EquirectTexture.width, EquirectTexture.height);

        // Copies EquirectTexture into the tempTexture
        RenderTexture currentActiveRT = RenderTexture.active;
        RenderTexture.active = EquirectTexture;
        tempTexture.ReadPixels(new Rect(0, 0, EquirectTexture.width, EquirectTexture.height), 0, 0);

        // Exports to a PNG
        var bytes = tempTexture.EncodeToPNG();
        System.IO.File.WriteAllBytes("FileName", bytes);

        // Restores the active render texture
        RenderTexture.active = currentActiveRT;

    }
}
