using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour {

	//Make multidimensional array size 10 x 10 as platform
	int[,] grid = new int[10,10];

	//Score and length of the snake is store here
	int snakeScore = 1;
	//here are snake position in x and y
	int snakeX = 0;
	int snakeY = 4;

	private Transform snakeTransform;
	private float lastMove;
	private float timeInBetweenMove = 0.5f;
	private Vector3 direction;

	private void Start(){
		//GetComponent<Transform>() is similar with transform
		snakeTransform = transform;
		direction = Vector3.right;
		grid [snakeX, snakeY] = snakeScore;
	}

	private void Update(){


		//Check if there is deltaTime between Time.time and lastMove, if does, then move the snake
		if(Time.time - lastMove > timeInBetweenMove){
			//Move
			lastMove = Time.time;

			//Detect direction of snake
			if(direction.x == 1){
				snakeX++;
			}
			if(direction.x == -1){
				snakeX--;
			}
			if(direction.y == 1){
				snakeY++;
			}
			if(direction.y == -1){
				snakeY--;
			}

			//if the snake is goes out of bound
			if (snakeX > 9 || snakeX < 0 || snakeY > 9 || snakeY < 0) {
				Debug.Log ("Out of Bound");
			} else {
				//Move
				snakeTransform.position += direction;
				grid [snakeX, snakeY] = snakeScore;
			}

				
		}

		// Input Controll for game
		if(Input.GetKeyDown(KeyCode.W)){
			direction = Vector3.up;
			Debug.Log ("Move Up!");
		}
		if(Input.GetKeyDown(KeyCode.A)){
			direction = Vector3.left;
			Debug.Log ("Move Left!");
		}
		if(Input.GetKeyDown(KeyCode.D)){
			direction = Vector3.right;
			Debug.Log ("Move Right!");
		}
		if(Input.GetKeyDown(KeyCode.S)){
			direction = Vector3.down;
			Debug.Log ("Move Down!");
		}

	}
}
