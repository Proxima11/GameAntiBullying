using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Item 
{
    public string name;
    public int stressPoint;
    public Sprite image;

    public Item(string name, int stressPoint, Sprite image){
        this.name = name;
        this.stressPoint = stressPoint;
        this.image = image;
    }
}

public class InventoryManager : MonoBehaviour
{
    public List<Item> items;
    public List<Item> itemOnwed;

    public List<int> itemIndex;
    public List<GameObject> slot; 
    // Start is called before the first frame update
    void Start()
    {
        // itemOnwed = superScript.itemOnwed;
        itemIndex = superScript.itemIndex;
        getItemFromIndex();
        RefreshInventory();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.I)){
			AddItem(0);
		}
    }

    public void getItemFromIndex(){
        foreach(int index in itemIndex){
            itemOnwed.Add(items[index]);
        }
    }

    public void AddItem(int index)
    {
        if (itemOnwed.Count < 5){
            Item item = items[index];
            itemIndex.Add(index);
            itemOnwed.Add(item);
            slot[itemOnwed.Count-1].SetActive(true);
            slot[itemOnwed.Count-1].GetComponent<Image>().sprite = item.image;
        }else{
            Debug.Log("Inventory Full");
        }

    }

    public void RemoveItem(int index)
    {
        if (itemOnwed.Count > 0 && index < itemOnwed.Count){
            Item item = itemOnwed[index];
            float r_shy = Random.Range(0f, 1f);
            int shy = 0;
            if (r_shy > superScript.shyConfidence) shy += (int) Mathf.Round(item.stressPoint / 2f);
            FindObjectOfType<GameVariable>().TakeStress(item.stressPoint + shy);
            itemIndex.Remove(index);
            itemOnwed.Remove(item);
            RefreshInventory();
            
        }else{
            Debug.Log("Inventory Empty");
        }
    }

    public void RefreshInventory(){
        int i = 0;
        int onwed = itemOnwed.Count;
        foreach(GameObject image in slot){
            if (i<onwed){
                image.GetComponent<Image>().sprite = itemOnwed[i].image;
            }else{
                image.SetActive(false);
            }
            i=i+1;
        }
    }
}
