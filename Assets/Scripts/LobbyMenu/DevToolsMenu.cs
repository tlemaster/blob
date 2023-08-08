using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DevToolsMenu : MonoBehaviour
{
    [SerializeField] private string gameplaySceneName = "Gameplay";
        
    // Netcode function runs on ui HostButton
    public void StartHost()
    {
        NetworkManager.Singleton.StartHost();
        NetworkManager.Singleton.SceneManager.LoadScene(gameplaySceneName, LoadSceneMode.Single);
    }

    // Netcode function runs on ui ServerButton   
    public void StartServer()
    {
        NetworkManager.Singleton.StartServer();
        NetworkManager.Singleton.SceneManager.LoadScene(gameplaySceneName, LoadSceneMode.Single);
    }

    // Netcode function runs on ui ClientButton 
    public void StartClient()
    {
        NetworkManager.Singleton.StartClient();
    }
}
