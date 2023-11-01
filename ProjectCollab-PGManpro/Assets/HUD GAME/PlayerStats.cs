using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerStats : MonoBehaviour 
{
	public int stress = 0;
	public int score = 0;
	public int maxTime = 1200;
	public int timeNow = 0;
	public int second;
	public int minute;
	public int day = 1;


	public void TakeStress(int takeStress)
	{
		stress +=takeStress;
	}

	public void AddPoint(int addPoint){
		score += addPoint;
	}

	public void setTime(int inputTime){
		timeNow = inputTime;
	}

	public void setDay(int inputDay){
		day = inputDay;
	}
	

	public void updateTime(){
		if (timeNow <= maxTime){
			if (timeNow<Time.time+1){
				minute = timeNow/60;
				second = timeNow%60;
				timeNow += 1 ;
			}
		}
	}

	private void Update() {
		
		if (Input.GetKeyUp(KeyCode.G)){
			TakeStress(1);
		}

		if (Input.GetKeyUp(KeyCode.Z)){
			AddPoint(10);
		}

		if (Input.GetKeyUp(KeyCode.X)){
			AddPoint(-10);
		}

		updateTime();

		// Debug.Log("Stress = " + stress.ToString());
		// Debug.Log("Point = " + score.ToString());
		// Debug.Log("Time = " + Time.time.ToString());
		// Debug.Log("Time = " + minute.ToString() + ":" + second.ToString());

    }

}
