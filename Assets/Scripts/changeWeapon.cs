using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class changeWeapon : MonoBehaviour {

	public int iCurrentWeapon;
	public GameObject[] goWeapons;

	private int iTotalWeapons;
	private HashSet<int> hSetOfWeapons;

	private void deactivateAllWeapons(){
		for (int iX = 0; iX < goWeapons.Length; iX++)
			goWeapons [iX].SetActive (false);
	}

	private void activateWeapon(int iNum){
		if (hSetOfWeapons.Contains (iNum))
		{
			goWeapons [iCurrentWeapon].SetActive (false);
			goWeapons [iNum].SetActive (true);
			iCurrentWeapon = iNum;
		}
	}

	// Use this for initialization
	void Start () {
		deactivateAllWeapons ();
		iCurrentWeapon = 0;
		iTotalWeapons = 1;
		hSetOfWeapons = new HashSet<int> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.Alpha1))
			activateWeapon (1);
		else if (Input.GetKey (KeyCode.Alpha2))
			activateWeapon (2);
		// Hacer los else ifs necesarios para todas las armas que se puedan tener en el juego.
	}
}
