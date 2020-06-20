using UnityEngine;
using System.Collections;
public class GyroRotate : MonoBehaviour
{

    private Gyroscope gyro;

    void Start()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
        }
        else
        {
            Debug.Log("Phone doesen't support");
        }
    }

    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.Rotate(-Input.gyro.rotationRateUnbiased.x, -Input.gyro.rotationRateUnbiased.y, 0);
    }

    void OnGUI()
    {
        GUILayout.Label("Gyroscope attitude : " + gyro.attitude);
    }
}