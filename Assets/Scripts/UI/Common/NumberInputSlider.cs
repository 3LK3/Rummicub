using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Rummicub.UI.Common
{
    public class NumberSlider : MonoBehaviour
    {
        public int InitialValue;

        [Header("UI Controls")]
        public TMP_Text Text;
        public Slider Slider;

        private int m_Value;

        private void Awake()
        {
            Slider.onValueChanged.AddListener(OnSliderValueChanged);

            SetValue(InitialValue);
        }

        public void SetValue(int value)
        {
            m_Value = value;

            Slider.value = m_Value;
            Text.text = m_Value.ToString();
        }

        public int GetValue() => m_Value;

        private void OnSliderValueChanged(float value)
        {
            SetValue((int)value);
        }
    }
}
