using UnityEngine;
using System.Collections;


public class Menu : MonoBehaviour {

	private const string AD_UNIT_ID = "YOUR_AD_UNIT_ID";
	private const string INTERSTITIAL_ID = "YOUR_AD_UNIT_ID";

	private static Vector2 BUTTON_SIZE = new Vector2(100, 50);

	private Rect buttonPositionShowAds;
	private Rect buttonPositionHideAds;
	private Rect buttonPositionShowInterstitial;



	void Start() {


		buttonPositionShowAds = new Rect(
			(Screen.width - BUTTON_SIZE.x) / 2,
			(Screen.height - BUTTON_SIZE.y) / 2,
			BUTTON_SIZE.x, BUTTON_SIZE.y);

		buttonPositionHideAds = new Rect(
			buttonPositionShowAds.x, buttonPositionShowAds.y + BUTTON_SIZE.y * 3 / 2,
			buttonPositionShowAds.width, buttonPositionShowAds.height);

		buttonPositionShowInterstitial = new Rect(
			buttonPositionHideAds.x, buttonPositionHideAds.y + BUTTON_SIZE.y * 3 / 2,
			buttonPositionHideAds.width, buttonPositionHideAds.height);
	}

	void OnEnable() {

	}

	void OnDisable() {

	}

	void HandleAdLoaded() {

	}

	void HandleInterstitialLoaded() {

	}

	void OnGUI() {

	}
}
