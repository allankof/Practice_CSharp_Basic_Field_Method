using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [Header("移動速度"),Range(5,100)]
    public int speedMove = 10;
    [Header("轉彎速度"), Range(1, 10)]
    public int speedTurn = 3;
    [Header("汽車檔次"), Range(1, 5)]
    public int carShift = 1;
    [Header("汽車品牌")]
    public string brand = "BMW";
    [Header("是否剎車")]
    public bool brakes;
    [Header("汽車顏色")]
    public Color color = new Color(0,0,255);
    [Header("汽車變形元件")]
    public Transform car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveForward()
    {
        car.Translate(Vector3.forward * Time.deltaTime * speedMove);
    }
    public void MoveBack()
    {
        car.Translate(Vector3.back * Time.deltaTime * speedMove);
    }
    public void TurnLeft()
    {
        car.transform.Rotate(0, -0.5f * speedTurn, 0);
        car.Translate(Vector3.forward * Time.deltaTime * speedMove);
    }
    public void TurnRight()
    {
        car.transform.Rotate(0, 0.5f * speedTurn, 0);
        car.Translate(Vector3.forward * Time.deltaTime * speedMove);
    }


}
