using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainBtnUI : MonoBehaviour {
	public Canvas _CanvasDisplayWorks;
	public Canvas _CanvasDisplayFoods;
	public Canvas _CanvasUI;
	private MainStatUI statUI;
	
	// Use this for initialization
	void Start () {
		statUI = _CanvasUI.GetComponent<MainPlayerStat>().statUI;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void onDisplayedWorks(){
		_CanvasDisplayWorks.gameObject.SetActive(true);
	}
	
	public void onDisplayedFoods(){
		if(_CanvasDisplayFoods.gameObject.active){
			_CanvasDisplayFoods.gameObject.SetActive(false);
		}else{
			_CanvasDisplayFoods.gameObject.SetActive(true);
		}
	}
	
	public void onSleep(){
		if(_CanvasUI.GetComponent<MainPlayerStat>().statUI.EnergyPoint < 50){
			_CanvasUI.GetComponent<MainPlayerStat>().statUI.EnergyPoint = 100;
			_CanvasUI.GetComponent<MainPlayerStat>().statUI.HungryPoint = _CanvasUI.GetComponent<MainPlayerStat>().statUI.HungryPoint - 10;
		} 
	}
	

}
