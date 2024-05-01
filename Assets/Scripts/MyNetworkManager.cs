using Mirror;
using UnityEngine;

public class MyNetworkManager : NetworkManager
{
    public override void OnServerAddPlayer(NetworkConnectionToClient networkConnectionToClient)
    {
        base.OnServerAddPlayer(networkConnectionToClient);

        MyNetworkPlayer player = networkConnectionToClient.identity.GetComponent<MyNetworkPlayer>();

        player.SetDisplayName($"Player {numPlayers}");

        Color displayColour = new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f));

        player.SetDisplayColour(displayColour);
    }
}