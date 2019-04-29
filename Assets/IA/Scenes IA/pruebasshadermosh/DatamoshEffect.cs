using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]

public class DatamoshEffect : MonoBehaviour
{

    public Material DMmat; //datamosh material

    void Start()
    {
        this.GetComponent<Camera>().depthTextureMode = DepthTextureMode.MotionVectors;
        StartCoroutine("CrashWait");
        //generate the motion vector texture @ '_CameraMotionVectorsTexture'
    }
    private void Update()
    {
        
        // question mark operator allows us to use a bool as an integer
    }

    private void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        Graphics.Blit(src, dest, DMmat);
    }


    IEnumerator CrashWait()
    {
        Shader.SetGlobalFloat("_Button", 0);
        yield return new WaitForSeconds(1.0f);
        yield return StartCoroutine("Crash");
    }

    IEnumerator Crash()
    {
        Shader.SetGlobalFloat("_Button", 1);
        yield return new WaitForSeconds(5.0f);
        yield return StartCoroutine("CrashWait");
    }

    //Input.GetButton("Fire1") ? 1 : 
}