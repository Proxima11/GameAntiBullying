using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameVariable : MonoBehaviour 
{
	public int stress = 0;
	public int score = 0;
	public int maxTime = 1200;
	public float timeNow = 0;
	public int second;
	public int minute;
	public int day = 1;


	public void TakeStress(int takeStress)
	{
		int temp = stress + takeStress;
		if(temp < 0){
            stress = 0;
        }else if(temp > 50){
            stress = 50;
        }else{
            stress = temp;
        }
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
			
			minute = (int) timeNow/60;
			second = (int) timeNow%60;
			timeNow += Time.deltaTime ;
		} else {
			this.day+=1;
			timeNow = 0;
		}

		superScript.updateTime(this.timeNow, this.day);
	}

	private void Start(){
		stress = superScript.stress;
		score = superScript.score;
		timeNow = superScript.time;
		day = superScript.day;
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
