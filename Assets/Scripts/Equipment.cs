using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Eqipment",menuName ="Inventory/Equipment")]
public class Equipment : Item {

    public EquipmentSlot equipSlot; // slot to store items
    public SkinnedMeshRenderer mesh;
    public EquipmentMeshRegion[] coveredMeshRegions;

    public int armorModifier; //armor value
    public int damageModifier; //damage value

    public override void Use()
    {
        base.Use();
        EquipmentManager.instance.Equip(this); //Equipm it
        RemoveFromInventory(); //Remove it from the inventory
    }

}

public enum EquipmentSlot { Head, Chest, Legs, Weapon, Shield, Feet}
public enum EquipmentMeshRegion { Legs, Arms, Torso}; //Corresponds to body blendshapes
