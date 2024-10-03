using System;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Player.Resources
{
    public class PlayerResources : MonoBehaviour
    {
        public static PlayerResources Instance { get; private set; }
        public static Action<int> BoughtEvent;
        private int _score = 5000;
        private int _playerSpeedRelad = 1;
        private int _playerLivesAdd = 0;
        private int _playerBullets = 0;
        private int _countOfReinforsments = 1;
        public int PlayerSpeedRelad => _playerSpeedRelad;
        public int PlayerLivesAdd => _playerLivesAdd;
        public int PlayerBullets => _playerBullets;
        public int CountOfReinforsments
        {
            get { return _countOfReinforsments; }
            set { _countOfReinforsments = value; }
        }
        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void AddScore(int points)
        {
            _score += points;
        }
        public void Live(int value)
        {
            _playerLivesAdd += value;
        }
        public void Reinforsment(int value)
        {
            _countOfReinforsments += value;
        }
        public void bullets(int value)
        {
            _playerBullets += value;
        }
        public void ReloadCannonTime(int value)
        {
            _playerSpeedRelad += value;
        }
        public void Bought(int points)
        {
            _score -= points;
            BoughtEvent?.Invoke(_score);
        }
        public int ReturnScore()
        {
            return _score;
        }
    }

}
