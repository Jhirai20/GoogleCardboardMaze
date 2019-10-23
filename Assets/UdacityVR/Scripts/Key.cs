using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject Poof;
    public GameObject Door;
    public bool keyCollected = false;

	void Update()
	{
        //Not required, but for fun why not try adding a Key Floating Animation here :)
       // transform.position = new Vector3(10f, 2 + Mathf.Sin(Time.time * 5f), 48f);
    }


	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        Object.Instantiate(Poof, transform.position, Quaternion.Euler(-90,0,0));
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        Door doorFromVariable = Door.GetComponent<Door>();
        doorFromVariable.Unlock();

        // Set the Key Collected Variable to true
        keyCollected = true;
        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy (gameObject);
    }

}
