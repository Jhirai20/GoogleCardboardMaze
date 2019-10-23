using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    public bool locked = true;
    // Create a boolean value called "opening" that can be checked in Update() 
    public bool opening = false;
    public Animator doorAnimation;
    public AudioSource doorSound;
    public AudioClip DoorLocked;
    public AudioClip DoorOpened;
    public bool Unlocked;
    
    void Update() {
        // If the door is opening and it is not fully raised
        // Animate the door raising up
        if (opening == true)
        {
            //doorAnimation.StartPlayback();
            //doorAnimation.SetTrigger("openDoor");
            gameObject.GetComponent<Animator>().SetTrigger("openDoor");
        }
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
        // Set the "opening" boolean to true
        // (optionally) Else
        // Play a sound to indicate the door is locked
        if (locked == false)
        {
            doorSound.PlayOneShot(DoorLocked);
            opening = true;
            doorSound.PlayOneShot(DoorOpened);
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    public void Unlock() {
        // You'll need to set "locked" to false here
        locked = false;
    }
}
