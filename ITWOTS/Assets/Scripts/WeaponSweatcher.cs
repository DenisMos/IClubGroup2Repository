using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSweatcher : MonoBehaviour
{
    public GameObject[] weapons;
    private int currentWeaponIndex = 0;
    private KeyCode[] KeyCodes = { KeyCode.Keypad0, KeyCode.Keypad1, KeyCode.Keypad2, KeyCode.Keypad3 };

    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon(0);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 4;i++)
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
                weapons[i].SetActive(true);
            }
            else
            {
                weapons[i].SetActive(false);
            }
        }
        currentWeaponIndex = index;
    }

}
