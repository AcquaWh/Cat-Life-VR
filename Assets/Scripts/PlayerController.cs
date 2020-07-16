using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviourPunCallbacks
{
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    float rotSpeed;
    [SerializeField]
    GameObject cam;
    [SerializeField]
    Transform vrCamera;
    [SerializeField]
    float toggleAngle = 15.0f;
    public Animator animacion;
    private CharacterController cc;
    /*
    public Rigidbody rb;
    public CapsuleCollider col;
    public float jumpForce = 7;
    */

    void Start()
    {
        cc = GetComponent<CharacterController>();
        /*
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
        */

        animacion = GetComponentInChildren<Animator>();
        if (photonView.IsMine)
        {
            cam.SetActive(true);
        }
    }

    void Update()
    {
        if (!photonView.IsMine) return;

        transform.Translate(Vector3.forward * axis.z * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * axis.x * rotSpeed * Time.deltaTime);

        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
        {
            Vector3 forward2 = vrCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward2 * moveSpeed);

            animacion.SetBool("walk", true);
        } else
        {
            animacion.SetBool("walk", false);
        }
        /* 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        */
        
    }
 
    Vector3 axis { get => new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")); }
}
