﻿using UnityEngine;
using System.Collections;

namespace UI
{
public class ControlDisplays : MonoBehaviour {

		public UIManager parentScript;
		public GameObject logInWindow;
		public GameObject backGround;
		public GameObject[] UIObjs;

		//Temp buttons
		public GameObject tempSceneButton;
		public GameObject tempMenuButton;


		public void ResetUI(){

			//This empties all slots and returns everything back to default values, or should
			//TODO: continue to update this when developing the UI. This is messy ATM

			if (parentScript.hands.rightSlot.isFull) {

				Destroy (parentScript.hands.rightSlot.inHandItem);
			}
			if (parentScript.hands.leftSlot.isFull) {

				Destroy (parentScript.hands.leftSlot.inHandItem);
			}
			if (parentScript.bottomControl.storage01Slot.isFull) {

				Destroy (parentScript.bottomControl.storage01Slot.inHandItem);

			}
			if (parentScript.bottomControl.storage02Slot.isFull) {

				Destroy (parentScript.bottomControl.storage02Slot.inHandItem);

			}


		}

		public void SetScreenForLobby(){
			
			SoundManager.control.StopAmbient ();
			SoundManager.control.PlayRandomTrack ();
			ResetUI (); //Make sure UI is back to default for next play
			foreach (GameObject obj in UIObjs) {
				obj.SetActive (false);
			}
			backGround.SetActive (true);
			logInWindow.SetActive (true);

			//TODO remove the temp button when scene transitions completed
			tempSceneButton.SetActive (false);
			tempMenuButton.SetActive (false);

		}

		public void SetScreenForGame(){


			foreach (GameObject obj in UIObjs) {
				obj.SetActive (true);
			}
			backGround.SetActive (false);
			logInWindow.SetActive (false);
			SoundManager.control.StopMusic ();
			//TODO random ambient
			SoundManager.control.PlayVarAmbient (0);

			//TODO remove the temp button when scene transitions completed
			tempSceneButton.SetActive (false);
			tempMenuButton.SetActive (true);

		}


}
}
