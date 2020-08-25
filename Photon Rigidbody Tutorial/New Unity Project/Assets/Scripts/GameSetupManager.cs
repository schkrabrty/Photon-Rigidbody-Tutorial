using UnityEngine;
using Photon.Pun;
using System.IO;

public class GameSetupManager : MonoBehaviour
{
    private float actualXChoice, actualZChoice;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        CreatePlayer(); // Create a networked player object for each player that loads into the multiplayer game
    }

    private void CreatePlayer()
    {
        Debug.Log("Creating Player");
        RandomValueGenerator();
        player = PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PhotonPlayer"), new Vector3(actualXChoice, 0, actualZChoice), Quaternion.identity);
    }

    private void RandomValueGenerator()
    {
        float xPos = Random.Range(5.0f, 10.1f);
        float xNeg = Random.Range(-5.0f, -10.1f);
        //float zPos = Random.Range(5.0f, 10.1f);
        float zNeg = Random.Range(-5.0f, -10.1f);

        float []choicesX = { xPos, xNeg };
        //float[] choicesZ = { zPos, zNeg };
        int XChoice = Random.Range(0, 2);
        //int ZChoice = Random.Range(0, 2);

        actualXChoice = choicesX[XChoice];
        //actualZChoice = choicesZ[ZChoice];
        actualZChoice = zNeg;
    }
}
