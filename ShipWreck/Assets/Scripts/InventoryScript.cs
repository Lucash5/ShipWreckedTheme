using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventoryScript : MonoBehaviour
{
    bool C;
    bool I;
    public GameObject crafting;
    public GameObject Items;
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
        if (I == false)
        {
            I = true;
            Items.SetActive(true);
        }
        else
        {
            I = false;
            Items.SetActive(false);
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
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.C) && collision.gameObject.name == "Workbench" && C == false)
        {
            C =true;
            crafting.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.C) && collision.gameObject.name == "Workbench" && C == true)
        {
            C = false;
            crafting.SetActive(false);
        }
     
    }



}
