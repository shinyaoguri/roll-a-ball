using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    private int count;
    public TextMeshProUGUI countText;
    public TextMeshProUGUI finishText;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        finishText.text = "";
        SetCountText();
    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "スコア: " + count.ToString() + " 点";
        if (count >= 10)
        {
            finishText.text = "Finish!";
        }
    }


}
