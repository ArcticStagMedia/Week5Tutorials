using UnityEngine;
using System.Collections;

public class EnemyCounter : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Enemy enemy1 = new Enemy();
        Enemy enemy2 = new Enemy();
        Enemy enemy3 = new Enemy();

        int numEnemies = Enemy.enemyCount;

        Debug.Log("The number of enemies is " + numEnemies);

        Player player1 = new Player();
        Player player2 = new Player();
        Player player3 = new Player();

        int numPlayers = Player.playerCount;

        Debug.Log("The number of Players is " + numPlayers);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
