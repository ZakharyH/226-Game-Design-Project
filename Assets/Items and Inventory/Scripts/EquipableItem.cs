﻿using UnityEngine;

public enum EquipmentType{

  Helmet,
  Chest,
  Gloves,
  Weapon1,
  Weapon2,
  Accessory1,
  Accessory2,
}

[CreateAssetMenu]
public class EquipableItem : Item
{
  public int StrengthBonus;
  public int AgilityBonus;
  public int IntelligenceBonus;
  public int VitalityBonus;
  [Space]
  public float StrengthPercentBonus;
  public float AgilityPercentBonus;
  public float IntelligencePercentBonus;
  public float VitalityPercentBonus;
  [Space]
  public EquipmentType EquipmentType;

}
