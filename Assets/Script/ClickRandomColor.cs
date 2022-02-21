using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickRandomColor : MonoBehaviour
{
    [SerializeField] private GameObject clickNumber;
    public void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            GameObject gameObject = Instantiate(clickNumber, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.2f);
            GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
    }
    
}