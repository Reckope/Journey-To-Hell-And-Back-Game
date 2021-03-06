﻿/* Author: Joe Davis
 * Project: One Way Ticket to Hell
 * Date modified: 14/04/19
 * This is used for level 4. I have given each level it's own script for spawn points,
 * objectives (easier to expand on in the future) and to return when it's completed. 
 * Code QA Sweep: DONE
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFour : MonoBehaviour {

	// Other Scripts
	public LevelController levelController;

	// Level objects arrays
	private Vector2[] spawnTickets = new Vector2[3];
	private Vector2[] spawnDemons = new Vector2[4];
	private Vector2[] spawnReapers = new Vector2[3];

	// Prefabs
	public GameObject ticketPrefab;
	public GameObject demonPrefab;
	public GameObject reaperPrefab;

	// Game Objects
	[SerializeField]
	private GameObject demon;
	[SerializeField]
	private GameObject blackReaper;
	private GameObject ticket;

	// Global Variables
	public static int lvl4TicketQuantity;

	// Use this for initialization
	void Start () {
		if(demon != null){
			Destroy(demon);
		}
		if(ticket != null){
			Destroy(ticket);
		}
		if(blackReaper != null){
			Destroy(blackReaper);
		}
		lvl4TicketQuantity = 0;
		SpawnDemons();
		SpawnReapers();
		SpawnTickets();
	}

	// Spawns the demons in at the start.
	private void SpawnDemons(){
		// Spawn points
		spawnDemons [0] = new Vector2(-11f, -330.9f);
		spawnDemons [1] = new Vector2(-14.8f, -329.3f);
		spawnDemons [2] = new Vector2(5.7f, -328.5f);
		spawnDemons [3] = new Vector2(19.3f, -332.2f);

		for(int x = 0; x < 4; x++){
			demon = (GameObject)Instantiate (demonPrefab, spawnDemons[x], Quaternion.identity);
		}
	}

	// Spawn the Reapers in at the start.
	private void SpawnReapers(){
		// Spawn points
		spawnReapers [0] = new Vector2(-17.7f, -327.3f);
		spawnReapers [1] = new Vector2(-7f, -332.2f);
		spawnReapers [2] = new Vector2(7f, -332.27f);

		for(int x = 0; x < 3; x++){
			blackReaper = (GameObject)Instantiate (reaperPrefab, spawnReapers[x], Quaternion.identity);
		}
	}

	// Spawns the tickets in at the start.
	private void SpawnTickets(){
		// Spawn Tickets
		spawnTickets [0] = new Vector2(8.08f, -326.54f);
		spawnTickets [1] = new Vector2(21.5f, -332.6f);
		spawnTickets [2] = new Vector2(-19.72f, -326.79f);

		for (int x = 0; x < 3; x++) {
			ticket = (GameObject)Instantiate (ticketPrefab, spawnTickets[x], Quaternion.identity);
			lvl4TicketQuantity++;
		}
	}

	// Returns when the level is completed.
	public bool LevelFourCompleted(){
		if(lvl4TicketQuantity == 0) {
			return true;
		}
		else{
			return false;
		}
	}
}