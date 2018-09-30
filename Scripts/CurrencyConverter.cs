using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyConverter : MonoBehaviour {
	private static CurrencyConverter instance;
	public static CurrencyConverter Instance{
		get{ 
			return instance;
		}
	}

	void Awake(){
		CreateInstance();
	}

	void CreateInstance(){
		if (instance == null) {
			instance = this;
		}
	}

	public string GetCurrencyIntoString (float valueToConvert, bool display){
		string converted = "";
		if (display == false) {
			if (valueToConvert >= 1000000000000000000000000000f) {
				converted = (valueToConvert / 1000000000000000000000000000f).ToString ("F3") + " Octillion";
			} else if (valueToConvert >= 1000000000000000000000000f) {
				converted = (valueToConvert / 1000000000000000000000000f).ToString ("F3") + " Septillion";
			} else if (valueToConvert >= 1000000000000000000000f) {
				converted = (valueToConvert / 1000000000000000000000f).ToString ("F3") + " Sextillion";
			} else if (valueToConvert >= 1000000000000000000f) {
				converted = (valueToConvert / 1000000000000000000f).ToString ("F3") + " Quintillion";
			} else if (valueToConvert >= 1000000000000000f) {
				converted = (valueToConvert / 1000000000000000f).ToString ("F3") + " Quadrillion";
			} else if (valueToConvert >= 1000000000000f) {
				converted = (valueToConvert / 1000000000000f).ToString ("F3") + " Trillion";
			} else if (valueToConvert >= 1000000000f) {
				converted = (valueToConvert / 1000000000f).ToString ("F3") + " Billion";
			} else if (valueToConvert >= 1000000f) {
				converted = (valueToConvert / 1000000f).ToString ("F3") + " Million";
			} else if (valueToConvert >= 1000f) {
				converted = (valueToConvert / 1000f).ToString ("F3") + " Thousand";
			} else {
				converted = "" + (valueToConvert).ToString ("F0");
			}
		}
		if (display == true) {
			if (valueToConvert >= 1000000000000000000000000000f) {
				converted = (valueToConvert / 1000000000000000000000000000f).ToString ("F3") + "\nOctillion";
			} else if (valueToConvert >= 1000000000000000000000000f) {
				converted = (valueToConvert / 1000000000000000000000000f).ToString ("F3") + "\nSeptillion";
			} else if (valueToConvert >= 1000000000000000000000f) {
				converted = (valueToConvert / 1000000000000000000000f).ToString ("F3") + "\nSextillion";
			} else if (valueToConvert >= 1000000000000000000f) { 
				converted = (valueToConvert / 1000000000000000000f).ToString ("F3") + "\nQuintillion";
			} else if (valueToConvert >= 1000000000000000) {
				converted = (valueToConvert / 1000000000000000f).ToString ("F3") + "\nQuadrillion";
			} else if (valueToConvert >= 1000000000000) {
				converted = (valueToConvert / 1000000000000f).ToString ("F3") + "\nTrillion";
			} else if (valueToConvert >= 1000000000) {
				converted = (valueToConvert / 1000000000f).ToString ("F3") + "\nBillion";
			} else if (valueToConvert >= 1000000) {
				converted = (valueToConvert / 1000000f).ToString ("F3") + "\nMillion";
			} else if (valueToConvert >= 1000) {
				converted = (valueToConvert / 1000f).ToString ("F3") + "\nThousand";
			} else {
				converted = "" + (valueToConvert).ToString ("F0");
			}
		}
		return converted;
	}
}
