using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class CameraController : MonoBehaviour
{
    public float cameraSpeed = 5.0f;
    private GameObject player;
    private PhotonView PV;

    private void Start()
    {
        PV = GetComponent<PhotonView>();  // PhotonView 컴포넌트 가져오기
        player = GameObject.FindGameObjectWithTag("Player");  // "Player" 태그를 가진 오브젝트 찾기
    }

    private void Update()
    {
        if (PV != null && PV.IsMine && player != null)
        {
            Vector3 dir = player.transform.position - transform.position;
            Vector3 moveVector = dir * cameraSpeed * Time.deltaTime;
            transform.Translate(moveVector);
        }
    }
}
