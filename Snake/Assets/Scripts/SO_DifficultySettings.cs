using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SO_DifficultySettings : ScriptableObject
{
	private int _difficulty=1;

	public int Difficulty
	{
		get { return _difficulty; }
		set { 
			if(value > 0 && value < 4)
			_difficulty = value+1; 
			else
				_difficulty = 1;
			}
	}

}
