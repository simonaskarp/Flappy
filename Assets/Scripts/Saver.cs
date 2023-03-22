using UnityEngine;

public class Saver : MonoBehaviour
{
    public Player player;

    private void Start()
    {
        Load();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            PlayerPrefs.DeleteAll();
        }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("highscore", player.highscore);
    }

    private void OnApplicationQuit()
    {
        Save();
    }

    public void Load()
    {
        player.highscore = PlayerPrefs.GetInt("highscore", player.highscore);
    }

}
