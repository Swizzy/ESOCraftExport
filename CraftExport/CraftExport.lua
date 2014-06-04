CraftExportAddon = {}
CraftExportAddon.Name = "CraftExport"
CraftExportAddon.AddonID = "craftexport"
CraftExportAddon.ArmorTraits = {
	Divines = 8,
	Exploration = 7,
	Impenetrable = 2,
	Infused = 6,
	Reinforced = 3,
	Sturdy = 1,
	Training = 5,
	WellFitted = 4
}
CraftExportAddon.WeaponTraits = {
	Charged = 2,
	Defending = 5,
	Infused = 4,
	Powered = 1,
	Precise = 3,
	Sharpened = 7,
	Training = 6,
	Weighted = 8
}
CraftExportAddon.Styles = {
	HighElves = 8,
	DarkElves = 5,
	WoodElves = 9,
	Nords = 6,
	Bretons = 2,
	Redguards = 3,
	Khajiit = 10,
	Orcs = 4,
	Argonians = 7,
	Imperial = 35,
	AncientElves = 16,
	Barbaric = 18,
	Primal = 20,
	Daedric = 21
}

function CraftExportAddon.Initialize(...)	
	CraftExportAddon.Exported = ZO_SavedVars:New("CraftExport", 1, nil, {})	
	CraftExportAddon.Exported["Woodworking"] = {
		Bow = {
			Charged = 0,
			Defending = 0,
			Infused = 0,
			Powered = 0,
			Precise = 0,
			Sharpened = 0,
			Training = 0,
			Weighted = 0
		},
		Froststaff = {
			Charged = 0,
			Defending = 0,
			Infused = 0,
			Powered = 0,
			Precise = 0,
			Sharpened = 0,
			Training = 0,
			Weighted = 0
		},
		Firestaff = {
			Charged = 0,
			Defending = 0,
			Infused = 0,
			Powered = 0,
			Precise = 0,
			Sharpened = 0,
			Training = 0,
			Weighted = 0
		},
		Lightningstaff = {
			Charged = 0,
			Defending = 0,
			Infused = 0,
			Powered = 0,
			Precise = 0,
			Sharpened = 0,
			Training = 0,
			Weighted = 0
		},
		Healingstaff = {
			Charged = 0,
			Defending = 0,
			Infused = 0,
			Powered = 0,
			Precise = 0,
			Sharpened = 0,
			Training = 0,
			Weighted = 0
		},
		Shield = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		}
	}	
	CraftExportAddon.Exported["BlackSmithing"] = {
		Chest = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		},
		Boots = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		},
		Gloves = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		},
		Head = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		},
		Legs = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		},
		Shoulders = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		},
		Belt = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		},
		Sword = {
			Charged = 0,
			Defending = 0,
			Infused = 0,
			Powered = 0,
			Precise = 0,
			Sharpened = 0,
			Training = 0,
			Weighted = 0
		},
		Axe = {
			Charged = 0,
			Defending = 0,
			Infused = 0,
			Powered = 0,
			Precise = 0,
			Sharpened = 0,
			Training = 0,
			Weighted = 0
		},
		Hammer = {
			Charged = 0,
			Defending = 0,
			Infused = 0,
			Powered = 0,
			Precise = 0,
			Sharpened = 0,
			Training = 0,
			Weighted = 0
		},
		Greatsword = {
			Charged = 0,
			Defending = 0,
			Infused = 0,
			Powered = 0,
			Precise = 0,
			Sharpened = 0,
			Training = 0,
			Weighted = 0
		},
		Battleaxe = {
			Charged = 0,
			Defending = 0,
			Infused = 0,
			Powered = 0,
			Precise = 0,
			Sharpened = 0,
			Training = 0,
			Weighted = 0
		},
		Maul = {
			Charged = 0,
			Defending = 0,
			Infused = 0,
			Powered = 0,
			Precise = 0,
			Sharpened = 0,
			Training = 0,
			Weighted = 0
		},
		Dagger = {
			Charged = 0,
			Defending = 0,
			Infused = 0,
			Powered = 0,
			Precise = 0,
			Sharpened = 0,
			Training = 0,
			Weighted = 0
		}
	}
	CraftExportAddon.Exported["Clothing_Light"] = {
		Chest = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		},
		Boots = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		},
		Gloves = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		},
		Head = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		},
		Legs = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		},
		Shoulders = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		},
		Belt = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		}
	}
	CraftExportAddon.Exported["Clothing_Medium"] = {
		Chest = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		},
		Boots = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		},
		Gloves = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		},
		Head = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		},
		Legs = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		},
		Shoulders = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		},
		Belt = {
			Divines = 0,
			Exploration = 0,
			Impenetrable = 0,
			Infused = 0,
			Reinforced = 0,
			Sturdy = 0,
			Training = 0,
			WellFitted = 0
		}
	}
	CraftExportAddon.Exported["Styles"] =  {
		HighElves = 0,
		DarkElves = 0,
		WoodElves = 0,
		Nords = 0,
		Bretons = 0,
		Redguards = 0,
		Khajiit = 0,
		Orcs = 0,
		Argonians = 0,
		Imperial = 0,
		AncientElves = 0,
		Barbaric = 0,
		Primal = 0,
		Daedric = 0
	}
	SLASH_COMMANDS["/craftexpo"] = CraftExportAddon.Scan
	CraftExportAddon.Scan()
end

local function ScanType(list, crafttype, index, traittype, objtype)
	for name, _ in pairs(CraftExportAddon.Exported[list][objtype]) do
		tType, _, tKnown = GetSmithingResearchLineTraitInfo(crafttype, index, CraftExportAddon[traittype][name])
		if tKnown then
			CraftExportAddon.Exported[list][objtype][name] = 1
		else
			_, tRemain = GetSmithingResearchLineTraitTimes(crafttype, index, CraftExportAddon[traittype][name])
			if tRemain then
				CraftExportAddon.Exported[list][objtype][name] = 2
			end
		end
	end
end

local function GetTraitName(trait, armor)
	if armor then
		if trait == 8 then
			return "Divines"
		elseif trait == 7 then
			return "Exploration"
		elseif trait == 2 then
			return "Impenetrable"
		elseif trait == 6 then
			return "Infused"
		elseif trait == 3 then
			return "Reinforced"
		elseif trait == 1 then
			return "Sturdy"
		elseif trait ==  5 then
			return "Training"
		elseif trait == 4 then
			return "WellFitted"
		end
	else
		if trait == 2 then
			return "Charged"
		elseif trait == 5 then
			return "Defending"
		elseif trait == 4 then
			return "Infused"
		elseif trait == 1 then
			return "Powered"
		elseif trait == 3 then
			return "Precise"
		elseif trait == 7 then
			return "Sharpened"
		elseif trait == 6 then
			return "Training"
		elseif trait == 8 then
			return "Weighted"
		end
	end
	return nil
end

local function CheckStored(bag, slot, crafttype, trait, index, list, armor)

	if not CanItemBeSmithingExtractedOrRefined(bag, slot, crafttype) then	
		return
	end
	local traitNum = trait
	if trait > 10 then
		traitNum = trait - 10
	end
	local traitName = GetTraitName(traitNum, armor)
	if traitName == nil then	
		return
	end
	
	if list[traitName] ~= 0 then
		return
	end
	
	if CanItemBeSmithingTraitResearched(bag, slot, crafttype, index, traitNum) then
		list[traitName] = 3
	end
	
end

local function CheckStoredLight(bag, slot, trait, equipType)
	if equipType == EQUIP_TYPE_CHEST then
		CheckStored(bag, slot, CRAFTING_TYPE_CLOTHIER, trait, 1, CraftExportAddon.Exported.Clothing_Light["Chest"], true)
	elseif equipType == EQUIP_TYPE_FEET then
		CheckStored(bag, slot, CRAFTING_TYPE_CLOTHIER, trait, 2, CraftExportAddon.Exported.Clothing_Light["Boots"], true)
	elseif equipType == EQUIP_TYPE_HAND then
		CheckStored(bag, slot, CRAFTING_TYPE_CLOTHIER, trait, 3, CraftExportAddon.Exported.Clothing_Light["Gloves"], true)
	elseif equipType == EQUIP_TYPE_HEAD then
		CheckStored(bag, slot, CRAFTING_TYPE_CLOTHIER, trait, 4, CraftExportAddon.Exported.Clothing_Light["Head"], true)
	elseif equipType == EQUIP_TYPE_LEGS then
		CheckStored(bag, slot, CRAFTING_TYPE_CLOTHIER, trait, 5, CraftExportAddon.Exported.Clothing_Light["Legs"], true)
	elseif equipType == EQUIP_TYPE_SHOULDERS then
		CheckStored(bag, slot, CRAFTING_TYPE_CLOTHIER, trait, 6, CraftExportAddon.Exported.Clothing_Light["Shoulders"], true)
	elseif equipType == EQUIP_TYPE_WAIST then
		CheckStored(bag, slot, CRAFTING_TYPE_CLOTHIER, trait, 7, CraftExportAddon.Exported.Clothing_Light["Belt"], true)
	end
end

local function CheckStoredMedium(bag, slot, trait, equipType)
	if equipType == EQUIP_TYPE_CHEST then
		CheckStored(bag, slot, CRAFTING_TYPE_CLOTHIER, trait, 8, CraftExportAddon.Exported.Clothing_Medium["Chest"], true)
	elseif equipType == EQUIP_TYPE_FEET then
		CheckStored(bag, slot, CRAFTING_TYPE_CLOTHIER, trait, 9, CraftExportAddon.Exported.Clothing_Medium["Boots"], true)
	elseif equipType == EQUIP_TYPE_HAND then
		CheckStored(bag, slot, CRAFTING_TYPE_CLOTHIER, trait, 10, CraftExportAddon.Exported.Clothing_Medium["Gloves"], true)
	elseif equipType == EQUIP_TYPE_HEAD then
		CheckStored(bag, slot, CRAFTING_TYPE_CLOTHIER, trait, 11, CraftExportAddon.Exported.Clothing_Medium["Head"], true)
	elseif equipType == EQUIP_TYPE_LEGS then
		CheckStored(bag, slot, CRAFTING_TYPE_CLOTHIER, trait, 12, CraftExportAddon.Exported.Clothing_Medium["Legs"], true)
	elseif equipType == EQUIP_TYPE_SHOULDERS then
		CheckStored(bag, slot, CRAFTING_TYPE_CLOTHIER, trait, 13, CraftExportAddon.Exported.Clothing_Medium["Shoulders"], true)
	elseif equipType == EQUIP_TYPE_WAIST then
		CheckStored(bag, slot, CRAFTING_TYPE_CLOTHIER, trait, 14, CraftExportAddon.Exported.Clothing_Medium["Belt"], true)
	end
end

local function CheckStoredHeavy(bag, slot, trait, equipType)
	if equipType == EQUIP_TYPE_CHEST then
		CheckStored(bag, slot, CRAFTING_TYPE_BLACKSMITHING, trait, 8, CraftExportAddon.Exported.BlackSmithing["Chest"], true)
	elseif equipType == EQUIP_TYPE_FEET then
		CheckStored(bag, slot, CRAFTING_TYPE_BLACKSMITHING, trait, 9, CraftExportAddon.Exported.BlackSmithing["Boots"], true)
	elseif equipType == EQUIP_TYPE_HAND then
		CheckStored(bag, slot, CRAFTING_TYPE_BLACKSMITHING, trait, 10, CraftExportAddon.Exported.BlackSmithing["Gloves"], true)
	elseif equipType == EQUIP_TYPE_HEAD then
		CheckStored(bag, slot, CRAFTING_TYPE_BLACKSMITHING, trait, 11, CraftExportAddon.Exported.BlackSmithing["Head"], true)
	elseif equipType == EQUIP_TYPE_LEGS then
		CheckStored(bag, slot, CRAFTING_TYPE_BLACKSMITHING, trait, 12, CraftExportAddon.Exported.BlackSmithing["Legs"], true)
	elseif equipType == EQUIP_TYPE_SHOULDERS then
		CheckStored(bag, slot, CRAFTING_TYPE_BLACKSMITHING, trait, 13, CraftExportAddon.Exported.BlackSmithing["Shoulders"], true)
	elseif equipType == EQUIP_TYPE_WAIST then
		CheckStored(bag, slot, CRAFTING_TYPE_BLACKSMITHING, trait, 14, CraftExportAddon.Exported.BlackSmithing["Belt"], true)
	end
end

local function ScanBag(bag)
	local _, bagSlots = GetBagInfo(bag)
	for slot = 0, bagSlots do
		local itemType = GetItemType(bag, slot)
		if itemType == ITEMTYPE_ARMOR or itemType == ITEMTYPE_WEAPON then
			local _,_,_,_,_,equipType = GetItemInfo(bag, slot)
			if equipType ~= EQUIP_TYPE_NECK and equipType ~= EQUIP_TYPE_RING then
				local trait = GetItemTrait(bag, slot)
				if itemType == ITEMTYPE_ARMOR then
					local armorType = GetItemArmorType(GetItemLink(bag, slot))
					if armorType == ARMORTYPE_LIGHT then
						CheckStoredLight(bag, slot, trait, equipType)
					elseif armorType == ARMORTYPE_MEDIUM then
						CheckStoredMedium(bag, slot, trait, equipType)
					elseif armorType == ARMORTYPE_HEAVY then
						CheckStoredHeavy(bag, slot, trait, equipType)
					end
				elseif itemType == ITEMTYPE_WEAPON then
					local weaponType = GetItemWeaponType(GetItemLink(bag, slot))
					if weaponType == WEAPONTYPE_AXE then
						CheckStored(bag, slot, CRAFTING_TYPE_BLACKSMITHING, trait, 1, CraftExportAddon.Exported.BlackSmithing["Axe"], false)
					elseif weaponType == WEAPONTYPE_HAMMER then
						CheckStored(bag, slot, CRAFTING_TYPE_BLACKSMITHING, trait, 2, CraftExportAddon.Exported.BlackSmithing["Hammer"], false)
					elseif weaponType == WEAPONTYPE_SWORD then
						CheckStored(bag, slot, CRAFTING_TYPE_BLACKSMITHING, trait, 3, CraftExportAddon.Exported.BlackSmithing["Sword"], false)
					elseif weaponType == WEAPONTYPE_TWO_HANDED_AXE then
						CheckStored(bag, slot, CRAFTING_TYPE_BLACKSMITHING, trait, 4, CraftExportAddon.Exported.BlackSmithing["Battleaxe"], false)
					elseif weaponType == WEAPONTYPE_TWO_HANDED_HAMMER then
						CheckStored(bag, slot, CRAFTING_TYPE_BLACKSMITHING, trait, 5, CraftExportAddon.Exported.BlackSmithing["Maul"], false)
					elseif weaponType == WEAPONTYPE_TWO_HANDED_SWORD then
						CheckStored(bag, slot, CRAFTING_TYPE_BLACKSMITHING, trait, 6, CraftExportAddon.Exported.BlackSmithing["Greatsword"], false)
					elseif weaponType == WEAPONTYPE_DAGGER then
						CheckStored(bag, slot, CRAFTING_TYPE_BLACKSMITHING, trait, 7, CraftExportAddon.Exported.BlackSmithing["Dagger"], false)
					elseif weaponType == WEAPONTYPE_BOW then
						CheckStored(bag, slot, CRAFTING_TYPE_WOODWORKING, trait, 1, CraftExportAddon.Exported.Woodworking["Bow"], false)
					elseif weaponType == WEAPONTYPE_FIRE_STAFF then
						CheckStored(bag, slot, CRAFTING_TYPE_WOODWORKING, trait, 2, CraftExportAddon.Exported.Woodworking["Firestaff"], false)
					elseif weaponType == WEAPONTYPE_FROST_STAFF then
						CheckStored(bag, slot, CRAFTING_TYPE_WOODWORKING, trait, 3, CraftExportAddon.Exported.Woodworking["Froststaff"], false)
					elseif weaponType == WEAPONTYPE_LIGHTNING_STAFF then
						CheckStored(bag, slot, CRAFTING_TYPE_WOODWORKING, trait, 4, CraftExportAddon.Exported.Woodworking["Lightningstaff"], false)
					elseif weaponType == WEAPONTYPE_HEALING_STAFF then
						CheckStored(bag, slot, CRAFTING_TYPE_WOODWORKING, trait, 5, CraftExportAddon.Exported.Woodworking["Healingstaff"], false)
					end
				end
				if equipType == EQUIP_TYPE_OFF_HAND then
					CheckStored(bag, slot, CRAFTING_TYPE_WOODWORKING, trait, 6, CraftExportAddon.Exported.Woodworking["Shield"], true)
				end
			end			
		end
	end
end

local function ScanInventory()
	ScanBag(BAG_BANK)
	ScanBag(BAG_BACKPACK)
end

local function ScanStyles()
	for name, _ in pairs(CraftExportAddon.Exported.Styles) do
		if IsSmithingStyleKnown(CraftExportAddon.Styles[name]) then
			CraftExportAddon.Exported.Styles[name] = 1
		end
	end
end

function CraftExportAddon.Scan()
	d("CraftExport Started")

	ScanStyles()

	ScanType("Woodworking", CRAFTING_TYPE_WOODWORKING, 1, "WeaponTraits", "Bow")
	ScanType("Woodworking", CRAFTING_TYPE_WOODWORKING, 2, "WeaponTraits", "Firestaff")
	ScanType("Woodworking", CRAFTING_TYPE_WOODWORKING, 3, "WeaponTraits", "Froststaff")
	ScanType("Woodworking", CRAFTING_TYPE_WOODWORKING, 4, "WeaponTraits", "Lightningstaff")
	ScanType("Woodworking", CRAFTING_TYPE_WOODWORKING, 5, "WeaponTraits", "Healingstaff")
	ScanType("Woodworking", CRAFTING_TYPE_WOODWORKING, 6, "ArmorTraits", "Shield")
	
	ScanType("BlackSmithing", CRAFTING_TYPE_BLACKSMITHING, 1, "WeaponTraits", "Axe")
	ScanType("BlackSmithing", CRAFTING_TYPE_BLACKSMITHING, 2, "WeaponTraits", "Hammer")
	ScanType("BlackSmithing", CRAFTING_TYPE_BLACKSMITHING, 3, "WeaponTraits", "Sword")
	ScanType("BlackSmithing", CRAFTING_TYPE_BLACKSMITHING, 4, "WeaponTraits", "Battleaxe")
	ScanType("BlackSmithing", CRAFTING_TYPE_BLACKSMITHING, 5, "WeaponTraits", "Maul")
	ScanType("BlackSmithing", CRAFTING_TYPE_BLACKSMITHING, 6, "WeaponTraits", "Greatsword")
	ScanType("BlackSmithing", CRAFTING_TYPE_BLACKSMITHING, 7, "WeaponTraits", "Dagger")
	
	ScanType("BlackSmithing", CRAFTING_TYPE_BLACKSMITHING, 8, "ArmorTraits", "Chest")
	ScanType("BlackSmithing", CRAFTING_TYPE_BLACKSMITHING, 9, "ArmorTraits", "Boots")
	ScanType("BlackSmithing", CRAFTING_TYPE_BLACKSMITHING, 10, "ArmorTraits", "Gloves")
	ScanType("BlackSmithing", CRAFTING_TYPE_BLACKSMITHING, 11, "ArmorTraits", "Head")
	ScanType("BlackSmithing", CRAFTING_TYPE_BLACKSMITHING, 12, "ArmorTraits", "Legs")
	ScanType("BlackSmithing", CRAFTING_TYPE_BLACKSMITHING, 13, "ArmorTraits", "Shoulders")
	ScanType("BlackSmithing", CRAFTING_TYPE_BLACKSMITHING, 14, "ArmorTraits", "Belt")
	
	ScanType("Clothing_Light", CRAFTING_TYPE_CLOTHIER, 1, "ArmorTraits", "Chest")
	ScanType("Clothing_Light", CRAFTING_TYPE_CLOTHIER, 2, "ArmorTraits", "Boots")
	ScanType("Clothing_Light", CRAFTING_TYPE_CLOTHIER, 3, "ArmorTraits", "Gloves")
	ScanType("Clothing_Light", CRAFTING_TYPE_CLOTHIER, 4, "ArmorTraits", "Head")
	ScanType("Clothing_Light", CRAFTING_TYPE_CLOTHIER, 5, "ArmorTraits", "Legs")
	ScanType("Clothing_Light", CRAFTING_TYPE_CLOTHIER, 6, "ArmorTraits", "Shoulders")
	ScanType("Clothing_Light", CRAFTING_TYPE_CLOTHIER, 7, "ArmorTraits", "Belt")
	
	ScanType("Clothing_Medium", CRAFTING_TYPE_CLOTHIER, 8, "ArmorTraits", "Chest")
	ScanType("Clothing_Medium", CRAFTING_TYPE_CLOTHIER, 9, "ArmorTraits", "Boots")
	ScanType("Clothing_Medium", CRAFTING_TYPE_CLOTHIER, 10, "ArmorTraits", "Gloves")
	ScanType("Clothing_Medium", CRAFTING_TYPE_CLOTHIER, 11, "ArmorTraits", "Head")
	ScanType("Clothing_Medium", CRAFTING_TYPE_CLOTHIER, 12, "ArmorTraits", "Legs")
	ScanType("Clothing_Medium", CRAFTING_TYPE_CLOTHIER, 13, "ArmorTraits", "Shoulders")
	ScanType("Clothing_Medium", CRAFTING_TYPE_CLOTHIER, 14, "ArmorTraits", "Belt")
	
	ScanInventory()
	d("CraftExport Completed")
end

EVENT_MANAGER:RegisterForEvent(CraftExportAddon.AddonID, EVENT_ADD_ON_LOADED, CraftExportAddon.Initialize)