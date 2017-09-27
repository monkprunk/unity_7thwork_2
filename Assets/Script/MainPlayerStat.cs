using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPlayerStat : MonoBehaviour{
	public Text _HungryPoint;
	public Text _EnergyPoint;
	public Text _Coins;
	public Text _Level;
	public Text _Exp;
	public Text _MaxExp;
	public MainStatUI statUI;
	
	// Use this for initialization
	void Start () {
		statUI = new MainStatUI();
		statUI.HungryPoint = 100;
		statUI.EnergyPoint = 100;
		statUI.Coins = 200;
		statUI.Level = 1;
		statUI.Exp = 0;
		statUI.MaxExp = 20;
	}
	
	// Update is called once per frame
	void Update () {
		_HungryPoint.text = statUI.HungryPoint.ToString();
		_EnergyPoint.text = statUI.EnergyPoint.ToString();
		_Coins.text = statUI.Coins.ToString();
		_Level.text = statUI.Level.ToString();
		_Exp.text = statUI.Exp.ToString();
		_MaxExp.text = statUI.MaxExp.ToString();
		if(statUI.Exp >= statUI.MaxExp){
			levelUp();
			statUI.Level = statUI.Level + 1;
		}
	}
	
	void levelUp(){
		statUI.Exp = statUI.Exp - statUI.MaxExp;
		statUI.MaxExp = statUI.MaxExp + (statUI.MaxExp * 3 / 2);
	}
	
}
