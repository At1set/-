using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.InputSystem.WebGL;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [SerializeField]
    TMP_InputField Fuel;
    [SerializeField]
    TMP_InputField RocketMass;
    [SerializeField]
    TMP_InputField jetSpeed;
    [SerializeField]
    TMP_InputField jetMass;
    [SerializeField]
    TMP_InputField HighStart;
    [SerializeField]
    TMP_InputField Gravity;
    [SerializeField]
    TMP_InputField MaxFuelFlow;
    [SerializeField]
    TMP_InputField LandingSpeed;


    double Rm;        //����� ������� ������
    double Fm;        //����� �������
    double jetM;     //����� �������������� ��������
    double jetV;     //�������� �������������� ��������
    double StartH;   //��������� ������
    vect G;          //��������� ���������� �������
    double LandV;    //���������� ������� �������
    double MaxFF;    //������������ ������ �������
    double Hstart;   //��������� ������
    double Lv;       //�������� ������ �������
    float Fps = 100;       //���-�� ������ ������ � �������

    vect accel;      //���������
    public double trust;    //���� %
    public vect v;          //��������
    public double h;        //������
    public double a;        //���� �������
    public double delta;    //delta

    private void Start()
    {
        delta = 1 / Fps;
        Debug.Log((Gravity.text));
        SceneStart();
    }


    public bool ReadData(out double Fm, out double Rm, out double JetS, out double JetM, out double Hstart, out vect G,out double MaxFF, out double Ls)
    {
        bool res = true;
        G = new vect();
        //if (!double.TryParse(Gravity.get ,out G.y)) res = false;
        if (!double.TryParse(Fuel.text,out Fm)) res = false;
        if (!double.TryParse(RocketMass.text, out Rm)) res = false;
        if (!double.TryParse(jetSpeed.text, out JetS)) res = false;
        if (!double.TryParse(jetMass.text, out JetM)) res = false;
        if (!double.TryParse(HighStart.text, out Hstart)) res = false;
        if (!double.TryParse(MaxFuelFlow.text, out MaxFF)) res = false;
        if (!double.TryParse(LandingSpeed.text, out Ls)) res = false;
        return res;
    }


    void SceneStart()
    {
        if(!ReadData(out Fm, out Rm, out jetV, out jetM, out Hstart, out G, out MaxFF, out Lv))
        {
            Debug.Log("�� ������� ��������");
            return;
        }
        //InvokeRepeating("PhisicFrame", 0,0.001f);

    }

    void PhisicFrame()
    {
        Debug.Log("23");
        //v -= G * delta;
    }

    vect Verle()
    {
        return new vect();
    }

}
