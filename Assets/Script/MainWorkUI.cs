using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainWorkUI : MonoBehaviour {
	public Canvas _CanvasDisplayWorks;
	public Canvas _CanvasUI;
	private MainStatUI statUI;
	private Dictionary<string, MainStatWork> statWorkDictionary;
	
	void Start () { 
		statWorkDictionary = new Dictionary<string, MainStatWork>(); 
		statWorkDictionary = mockWorks();
		statUI = _CanvasUI.GetComponent<MainPlayerStat>().statUI;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private Dictionary<string, MainStatWork> mockWorks(){
		Dictionary<string, MainStatWork> statWorkDictionary = new Dictionary<string, MainStatWork>();
		statWorkDictionary.Add("Practice",new MainStatWork("Practice",20,20,0,6));
		statWorkDictionary.Add("StreetShow",new MainStatWork("StreetShow",40,40,20,4));
		statWorkDictionary.Add("NightShow",new MainStatWork("NightShow",40,30,60,3));
		statWorkDictionary.Add("MiniConcert",new MainStatWork("MiniConcert",80,60,150,4));
		statWorkDictionary.Add("GoWork",new MainStatWork("GoWork",60,60,100,4));
		return statWorkDictionary;
	}
	
	void goWork(string paramWork){
		if((statUI.HungryPoint >= statWorkDictionary[paramWork].HungryPoint)&&
			(statUI.EnergyPoint >= statWorkDictionary[paramWork].EnergyPoint)){
			setCoins(statWorkDictionary[paramWork].Coins);
			setHungryPoint(statWorkDictionary[paramWork].HungryPoint);
			setEnergyPoint(statWorkDictionary[paramWork].EnergyPoint);
			setExp(statWorkDictionary[paramWork].Exp);
		}
	}
	
	private void setHungryPoint(int point){
		_CanvasUI.GetComponent<MainPlayerStat>().statUI.HungryPoint = _CanvasUI.GetComponent<MainPlayerStat>().statUI.HungryPoint - point;
	}
	private void setCoins(int point){
		_CanvasUI.GetComponent<MainPlayerStat>().statUI.Coins = _CanvasUI.GetComponent<MainPlayerStat>().statUI.Coins + point;
	}
	private void setEnergyPoint(int point){
		_CanvasUI.GetComponent<MainPlayerStat>().statUI.EnergyPoint = _CanvasUI.GetComponent<MainPlayerStat>().statUI.EnergyPoint - point;
	}
	private void setExp(int point){
		_CanvasUI.GetComponent<MainPlayerStat>().statUI.Exp = _CanvasUI.GetComponent<MainPlayerStat>().statUI.Exp + point;
	}
	
	 
	public void onClickPractice(){
		string paramWork = "Practice"; 
		goWork(paramWork);
	} 
	public void onStreetShow(){
		string paramWork = "StreetShow"; 
		goWork(paramWork);
	}
	public void onClickNightShow(){
		string paramWork = "NightShow"; 
		goWork(paramWork);
	} 
	public void onClickMiniConcert(){
		string paramWork = "MiniConcert"; 
		goWork(paramWork);
	}
	
	public void onCloseWorks(){
		_CanvasDisplayWorks.gameObject.SetActive(false);
	}
}
