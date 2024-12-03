using UnityEngine;

public class PlayerDataView : MonoBehaviour
{
   [SerializeField] private SO_PlayerData _soPlayerData;
   void OnEnable()
   {
      var playerHealth = _soPlayerData.GetPlayerHealth();
      Debug.Log(playerHealth);
   }
}
