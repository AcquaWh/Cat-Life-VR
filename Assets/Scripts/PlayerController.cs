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
    float toggleAngle = 30.0f;
    public Animator animacion;
    private CharacterController cc;
    void Start()
    {
        cc = GetComponent<CharacterController>();
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
        
    }
    Vector3 axis { get => new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")); }
}
