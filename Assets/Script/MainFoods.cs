using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainFoods : MonoBehaviour {
	public Canvas _CanvasUI;
	private MainStatUI statUI;
	private Dictionary<string, MainStatFood> statFoodDictionary;
	
	void Start () {
		List<MainStatFood> statFoodList = new List<MainStatFood>();
		statFoodDictionary = new Dictionary<string, MainStatFood>();
		//statFoodList = mockFoods();
		statFoodDictionary = mockFood2();
		statUI = _CanvasUI.GetComponent<MainPlayerStat>().statUI;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void onClickBurger(){
		string paramFood = "Burger";
		if(statUI.Coins >= statFoodDictionary[paramFood].Price){
			setCoins(statFoodDictionary[paramFood].Price);
			setHungryPoint(statFoodDictionary[paramFood].HungryPoint);
		}
	}
	
	public void onClickPizza(){
		string paramFood = "Pizza";
		if(statUI.Coins >= statFoodDictionary[paramFood].Price){
			setCoins(statFoodDictionary[paramFood].Price);
			setHungryPoint(statFoodDictionary[paramFood].HungryPoint);
		}
	}
	
	public void onClickChicken(){
		string paramFood = "Chicken";
		if(statUI.Coins >= statFoodDictionary[paramFood].Price){
			setCoins(statFoodDictionary[paramFood].Price);
			setHungryPoint(statFoodDictionary[paramFood].HungryPoint);
		}
	}
	
	public void onClickWater(){
		string paramFood = "Water";
		if(statUI.Coins >= statFoodDictionary[paramFood].Price){
			setCoins(statFoodDictionary[paramFood].Price);
			setHungryPoint(statFoodDictionary[paramFood].HungryPoint);
		}
	}
	
	private void setHungryPoint(int point){
		_CanvasUI.GetComponent<MainPlayerStat>().statUI.HungryPoint = _CanvasUI.GetComponent<MainPlayerStat>().statUI.HungryPoint + point;
	}
	
	private void setCoins(int point){
		_CanvasUI.GetComponent<MainPlayerStat>().statUI.Coins = _CanvasUI.GetComponent<MainPlayerStat>().statUI.Coins - point;
	}
	
	private List<MainStatFood> mockFoods(){
		List<MainStatFood> statFoodList = new List<MainStatFood>();
		statFoodList.Add(new MainStatFood("Burger",40,20));
		statFoodList.Add(new MainStatFood("Pizza",30,15));
		statFoodList.Add(new MainStatFood("Chicken",10,10));
		statFoodList.Add(new MainStatFood("Water",5,5));
		return statFoodList;
	}
	
	private Dictionary<string, MainStatFood> mockFood2(){
		Dictionary<string, MainStatFood> statFoodDictionary = new Dictionary<string, MainStatFood>();
		statFoodDictionary.Add("Burger",new MainStatFood("Burger",40,20));
		statFoodDictionary.Add("Pizza",new MainStatFood("Pizza",30,15));
		statFoodDictionary.Add("Chicken",new MainStatFood("Chicken",10,10));
		statFoodDictionary.Add("Water",new MainStatFood("Water",5,5));
		return statFoodDictionary;
	}
}
