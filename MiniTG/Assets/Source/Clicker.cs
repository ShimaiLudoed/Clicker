using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class Clicker : MonoBehaviour
    {
        private int _score=0;
        [SerializeField] private TMP_Text score;
        [SerializeField] private Button click;

        private void Start()
        {
            score.text = $"Your Score: {_score}";
            click.onClick.AddListener(() => Click());
        }

        private void Click()
        {
            _score++;
            score.text = $"Your Score: {_score}";
        }
    }
}