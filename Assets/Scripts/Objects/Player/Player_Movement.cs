using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float player_speed = 0;

    private Rigidbody2D ref_rbody;

    private void Awake()
    {
        ref_rbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        // Do movements in fixed update for smoother movements
        float movement_hori = Input.GetAxis("Horizontal");
        float movement_vert = Input.GetAxis("Vertical");

        // Use forces to apply acceleration
        float time_scale = Time.fixedDeltaTime * player_speed;
        ref_rbody.AddForce(new Vector2(movement_hori * time_scale, movement_vert * time_scale));
    }
}
