using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonToggle : MonoBehaviour
{
    [SerializeField]private GameObject obj;
    public void Toggle()
    {
        obj.SetActive(!obj.active);
    }

}
