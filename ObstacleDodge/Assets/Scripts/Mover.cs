using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float movespeed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*movespeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime*movespeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
