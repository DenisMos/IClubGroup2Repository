using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSweatcher : MonoBehaviour
{
    public GameObject[] weapons;
    private int currentWeaponIndex = 0;
    private KeyCode[] KeyCodes = { KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3, KeyCode.Alpha4 };

    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon(0);
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 4; i++)
        {
            if (Input.GetKeyDown(KeyCodes[i]))
            {
                SelectWeapon(i);
            }
        }
    }
    
    void SelectWeapon(int index)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if (i == index)
            {
                if (weapons[i] != null)
                {
                    weapons[i].SetActive(true);
                }
            }
            else
            {
                if (weapons[i] != null)
                {
                    weapons[i].SetActive(false);
                }
            }
        }
        currentWeaponIndex = index;
    }

}
