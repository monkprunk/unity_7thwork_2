using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStatFood {
	private string name;
	private int hungryPoint;
	private int price;
	
	public MainStatFood(string name,int hungryPoint,int price){
		this.name = name;
		this.hungryPoint = hungryPoint;
		this.price = price;
	}
	
	public string Name{
		get{return this.name;}
		set{this.name = value;}
	}
	
	public int HungryPoint{
		get{return this.hungryPoint;}
		set{this.hungryPoint = value;}
	} 
	
	public int Price{
		get{return this.price;}
		set{this.price = value;}
	}
	
}