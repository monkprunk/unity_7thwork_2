using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStatWork {
	private string name;
	private int hungryPoint;
	private int coins;
	private int energyPoint;
	private int exp;
	
	public MainStatWork(string name,int energyPoint,int hungryPoint,int coins,int exp){
		this.name = name;
		this.energyPoint = energyPoint;
		this.hungryPoint = hungryPoint;
		this.coins = coins;
		this.exp = exp;
	} 
	public string Name{
		get{return this.name;}
		set{this.name = value;}
	} 
	public int HungryPoint{
		get{return this.hungryPoint;}
		set{this.hungryPoint = value;}
	}  
	public int Coins{
		get{return this.coins;}
		set{this.coins = value;}
	} 
	public int EnergyPoint{
		get{return this.energyPoint;}
		set{this.energyPoint = value;}
	}
	public int Exp{
		get{return this.exp;}
		set{this.exp = value;}
	}
	
}