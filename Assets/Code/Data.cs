using UnityEngine;
using UnityEngine.UIElements;

namespace GB_UnityCSharp
{
    [CreateAssetMenu(fileName = "GameData", menuName = "Data/GameData")]
    public class Data : ScriptableObject
    {
        [Header("Player Data")]
        public Vector3 playerInitialPosition;

        public GameObject playerPrefab;
        public float playerSpeed;

        [Header("Camera Data")] 
        public Vector3 cameraOffset;

        private InteractiveObjects[] _requiredItems;

        public InteractiveObjects[] RequiredItems
        {
            get => _requiredItems;
        }
        
        private int _points = 0;
        public int Points
        {
            get => _points;
            set => _points = value;
        }
        
        private VisualElement _uiRoot;
        public VisualElement Root { get => _uiRoot; }

        
        public void OnEnable()
        {
            _requiredItems = FindObjectsOfType<InteractiveObjects>();
            _uiRoot = FindObjectOfType<UIDocument>().rootVisualElement;
        }
    }
}