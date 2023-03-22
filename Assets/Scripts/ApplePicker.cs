using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    [Header("inscribed")] 
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
	public List<GameObject> basketList;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0 ; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
        }
    }

	public void AppleMissed() 
	{
		//destroy falling apples
		GameObject[] appleArray=GameObject.FindGameObjectsWithTag("Apple");
			foreach (GameObject tempGO in appleArray)
			{
				Destroy (tempGO);
			}
	}
}
