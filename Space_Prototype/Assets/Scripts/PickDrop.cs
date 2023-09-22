using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickDrop : MonoBehaviour
{
    private bool isPickedUp = false;
    private Transform player;
    public Transform desiredDropPosition;
    public PlayerManager playerManager;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    private void Update()
    {
        if (!isPickedUp && Input.GetKeyDown(KeyCode.E))
        {
            float distance = Vector2.Distance(transform.position, player.position);

            if (distance < 2f)
            {
                PickUpItem();
            }
        }
        else if (isPickedUp && Input.GetKeyDown(KeyCode.Q))
        {
            DropItem();
        }
    }

    private void PickUpItem()
    {
        isPickedUp = true;
        transform.SetParent(player);
        transform.localPosition = Vector3.zero;
        GetComponent<Rigidbody2D>().isKinematic = true;
        GetComponent<Collider2D>().enabled = false;
    }

    private void DropItem()
    {
        isPickedUp = false;
        transform.SetParent(null);
        GetComponent<Rigidbody2D>().isKinematic = false;
        GetComponent<Collider2D>().enabled = true;


        float distanceToDesiredPosition = Vector2.Distance(transform.position, desiredDropPosition.position);
        if (distanceToDesiredPosition < 1.5f)
        {

            PlayerManager.isGameWin = true;
            gameObject.SetActive(false);
        }
    }

}
