using System.Collections.Generic;
using UnityEngine;
using PlayerCreator;

[CreateAssetMenu(fileName ="AppearanceFeatureSpritesStorage", menuName ="PlayerAppearance/AppearanceFeatures")]
public class AppearanceFeatureSpritesStorage : ScriptableObject
{
    [SerializeField] private List<AppearanceFeatureSprites> _appearanceFeatureSprites;
    public List<AppearanceFeatureSprites> AppearanceFeatureSprites => _appearanceFeatureSprites;
}
