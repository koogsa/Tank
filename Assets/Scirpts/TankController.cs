using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public ScoreManager scoreManager;
    public ParticleSystem shellExplosion;
    public int playerNum = 1;
    string mvAxisName;
    string rotAxisName;
    float tkMvSpeed = 10.0f;
    float tkRotSpeed = 150.0f;
    public int Hp = 3;

    private Vector3 initialPosition; 
    private Quaternion initialRotation;  
    public Color tankColor;

    void Start()
    {
        mvAxisName = "Vertical" + playerNum;
        rotAxisName = "Horizontal" + playerNum;

        MeshRenderer[] renderers = GetComponentsInChildren<MeshRenderer>();

        for (int i = 0; i < renderers.Length; i++)
        {
            renderers[i].material.color = tankColor;
        }
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    void Update()
    {
        float mv = Input.GetAxis(mvAxisName) * tkMvSpeed * Time.deltaTime;
        float rot = Input.GetAxis(rotAxisName) * tkRotSpeed * Time.deltaTime;

        transform.Translate(0, 0, mv);
        transform.Rotate(0, rot, 0);
    }
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag == "SHELL")
        {
            Hp -= 1;
            if (Hp == 0)
            {
                ParticleSystem fire = Instantiate(shellExplosion, transform.position, Quaternion.identity);
                fire.Play();
                gameObject.SetActive(false);
                Destroy(fire.gameObject, 2.0f);
                scoreManager.AddScore(playerNum);
                GameManager.Instance.GameOver();
            }
        }
    }
    public void ResetTank()
    {
        transform.position = initialPosition;
        transform.rotation = initialRotation;
        Hp = 3;  // 체력도 초기화
        gameObject.SetActive(true);
    }
}
