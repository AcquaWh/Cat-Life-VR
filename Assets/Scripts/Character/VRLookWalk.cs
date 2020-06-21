using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VRLookWalk : MonoBehaviour
{
    public Transform vrCamera;
    public float toggleAngle = 30.0f;
    public float speed = 3.0f;
    public bool movedForward;
    private CharacterController cc;
    public Animator animacion;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        animacion = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name != "Home")
        {
            if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
            {
                movedForward = true;
            }
            else
            {
                movedForward = false;
                animacion.SetBool("walk", false);
            }
            if (movedForward)
            {
                Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
                cc.SimpleMove(forward * speed);
                animacion.SetBool("walk", true);
            }
        }
    }
}
