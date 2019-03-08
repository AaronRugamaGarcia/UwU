using UnityEngine;
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]

public class DatamoshEffect : MonoBehaviour
{

    public Material DMmat; //datamosh material

    void Start()
    {
        this.GetComponent<Camera>().depthTextureMode = DepthTextureMode.MotionVectors;
        //generate the motion vector texture @ '_CameraMotionVectorsTexture'
    }
    private void Update()
    {
        Shader.SetGlobalInt("_Button", Input.GetButton("Fire1") ? 1 : 0);
        // question mark operator allows us to use a bool as an integer
    }

    private void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        Graphics.Blit(src, dest, DMmat);
    }
}