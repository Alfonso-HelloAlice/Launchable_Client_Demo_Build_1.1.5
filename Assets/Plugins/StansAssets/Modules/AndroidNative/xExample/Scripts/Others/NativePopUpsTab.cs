﻿using UnityEngine;
using System.Collections;

public class NativePopUpsTab : FeatureTab {

	private string rateText = "If you enjoy using Google Earth, please take a moment to rate it. Thanks for your support!";
	
	
	//example link to your app on android market
	private string rateUrl = "market://details?id=com.unionassets.android.plugin.preview";
	
	//--------------------------------------
	// INITIALIZE
	//--------------------------------------

	//--------------------------------------
	//  PUBLIC METHODS
	//--------------------------------------
	
	public void RateDialogPopUp() {
		AndroidRateUsPopUp rate = AndroidRateUsPopUp.Create("Rate Us", rateText, rateUrl);
		rate.ActionComplete += OnRatePopUpClose;
	}
	
	public void DialogPopUp() {
		AndroidDialog dialog = AndroidDialog.Create("Dialog Titile", "Dialog message");
		dialog.ActionComplete += OnDialogClose;
	}
	
	public void MessagePopUp() {
		AndroidMessage msg = AndroidMessage.Create("Message Titile", "Message message");
		msg.ActionComplete += OnMessageClose;
	}
	
	public void ShowPreloader() {
		Invoke("HidePreloader", 2f);
		AndroidNativeUtility.ShowPreloader("Loading", "Wait 2 seconds please");
	}
	
	public void HidePreloader() {
		AndroidNativeUtility.HidePreloader();
	}
	
	public void OpenRatingPage() {
		AndroidNativeUtility.OpenAppRatingPage(rateUrl);
	}
	
	//--------------------------------------
	//  GET/SET
	//--------------------------------------
	
	//--------------------------------------
	//  EVENTS
	//--------------------------------------
	
	private void OnRatePopUpClose(AndroidDialogResult result) {
		
		switch(result) {
		case AndroidDialogResult.RATED:
			Debug.Log ("RATED button pressed");
			break;
		case AndroidDialogResult.REMIND:
			Debug.Log ("REMIND button pressed");
			break;
		case AndroidDialogResult.DECLINED:
			Debug.Log ("DECLINED button pressed");
			break;
			
		}
		
		AN_PoupsProxy.showMessage("Result", result.ToString() + " button pressed");
	}
	
	
	
	private void OnDialogClose(AndroidDialogResult result) {
		
		//parsing result
		switch(result) {
		case AndroidDialogResult.YES:
			Debug.Log ("Yes button pressed");
			break;
		case AndroidDialogResult.NO:
			Debug.Log ("No button pressed");
			break;
			
		}
		
		AN_PoupsProxy.showMessage("Result", result.ToString() + " button pressed");
	}
	
	
	
	private void OnMessageClose(AndroidDialogResult result) {
		AN_PoupsProxy.showMessage("Result", "Message Closed");
	}
	
	
	
	//--------------------------------------
	//  PRIVATE METHODS
	//--------------------------------------
	
	//--------------------------------------
	//  DESTROY
	//--------------------------------------

}
