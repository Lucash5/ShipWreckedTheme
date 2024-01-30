using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventoryScript : MonoBehaviour
{
    public Canvas invUI;
    List<string> inventory = new List<string>();
    string[] itemlist = { "Apple" };
    
    public Image[] image;
    public Sprite[] PNGs;

    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            openclose();
        }
    }


    private void openclose()
    {
        if (invUI.enabled == false)
        {
            invUI.enabled = true;
        }
        else
        {
            invUI.enabled = false;
        }
    }

    bool owns;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
        foreach (string item in itemlist)
        {
            
        
            if (item == collision.gameObject.name)
            {
               

                for (int i = 0; i < inventory.Count; i++)
                {
                    if (inventory[i] == item)
                    {
                        owns = true;

                        inventory[i + 1] = (int.Parse(inventory[i + 1]) + 1).ToString();
                    }
                }

                if (owns == false)
                {
                inventory.Add(item);
                    foreach (Sprite name in PNGs)
                    {
                        if (name.name == item)
                        {
                   image[inventory.Count - 1].sprite = name;
                        }
                    }
                
                inventory.Add("1");
                }

                foreach (string aaa in inventory)
                {
                    Debug.Log(aaa);
                }
                
                Destroy(collision.gameObject);
            }
        }
    }
}
