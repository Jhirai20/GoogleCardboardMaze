using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject Poof;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located

        Object.Instantiate(Poof, transform.position, Quaternion.Euler(-90,0,0));
        // Make sure the poof animates vertically - Quaternion.Euler( put 3 float numbers seperated by comas here)
        // Destroy this coin. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);
    }

}
