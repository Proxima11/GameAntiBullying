using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameVariable : MonoBehaviour 
{
	public int stress = 0;
	public int score = 0;
	public int maxTime = 600;
	public float timeNow = 0;
	public int second;
	public int minute;
	public int day = 1;
	public bool bell_time = false;
	public bool takescore = false;
	public int stressAdded = 0;

    public void TakeStress(int takeStress)
	{
		int temp = stress + takeStress;
		if(temp < 0){
            stress = 0;
        }else if(temp > 100){
            stress = 100;
        }else{
            stress = temp;
        }
		stressAdded = takeStress;
		if (stress <= 0) stress = 0;
    }

	public int getSumDone(){
		int count = 0;
		foreach (var node in superScript.Tasks){
			if (node.done) count++;
		}

		return count;
	}

	public void AddPoint(int addPoint){
		score += addPoint;
		takescore = true;
		//scoreAdded = addPoint;
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
			timeNow += Time.deltaTime;
		} else {
			this.day+=1;
			FindObjectOfType<InventoryManager>().AddItem(1);
			FindObjectOfType<InventoryManager>().AddItem(1);
			FindObjectOfType<InventoryManager>().AddItem(2);
			timeNow = 0;
        }

		superScript.updateTime(this.timeNow, this.day);
	}

	private void Start(){
		stress = superScript.stress;
		score = superScript.score;
		timeNow = superScript.time;
		day = superScript.day;
		isAlreadyLose=false;
	}

	private bool isLose(){
		if (stress >= 100) return true;
		if (score < 0) return true;
		if (day > 5) return true;
		return false;
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

		if(minute == 4 && second == 1 ||  minute == 9 && second == 1) {
			bell_time = true;
		}

		if (isLose()) {
			if (!isAlreadyLose){
			FindObjectOfType<UpdateUI>().showGameOver();
			isAlreadyLose = true;
			}
		}
		// Debug.Log("Stress = " + stress.ToString());
		// Debug.Log("Point = " + score.ToString());
		// Debug.Log("Time = " + Time.time.ToString());
		// Debug.Log("Time = " + minute.ToString() + ":" + second.ToString());

    }

	private bool isAlreadyLose=false;

}
