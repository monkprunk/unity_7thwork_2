using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStatUI {
	private int hungryPoint;
	private int energyPoint;
	private int coins; 
	private int level;
	private int exp;
	private int maxExp;
	
	public int HungryPoint{
		get{return this.hungryPoint;}
		set{this.hungryPoint = value;}
	}
	public int EnergyPoint{
		get{return this.energyPoint;}
		set{this.energyPoint = value;}
	}
	public int Coins{
		get{return this.coins;}
		set{this.coins = value;}
	}
	public int Level{
		get{return this.level;}
		set{this.level = value;}
	}
	public int Exp{
		get{return this.exp;}
		set{this.exp = value;}
	}
	public int MaxExp{
		get{return this.maxExp;}
		set{this.maxExp = value;}
	}
}