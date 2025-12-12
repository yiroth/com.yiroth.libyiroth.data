/* 
 *  Copyright © yiroth, all right reserved 
 *  Creation date: 2025-12-03
 *  Purpose: Identification for literally anything
*/

using UnityEngine;

namespace LibYiroth.Data
{
    public enum IdentificationCategories
    {
        [InspectorName("None")]
        None = 0,
        [InspectorName("Game")]
        Game,
        [InspectorName("DLC: 1")]
        Dlc1,
        [InspectorName("DLC: 2")]
        Dlc2,
        [InspectorName("DLC: 3")]
        Dlc3
    }

    public enum IdentificationTypes
    {
        [InspectorName("None")]
        None = 0,
        [InspectorName("Data")]
        Data,
        [InspectorName("Level")]
        Level
    }

    [System.Serializable]
    public struct Identification : System.IEquatable<Identification>
    {
        public IdentificationCategories category;
        public IdentificationTypes type;
        public string identifier;
        
        public Identification(IdentificationCategories category, IdentificationTypes type, string identifier)
        {
            this.category = category;
            this.type = type;
            this.identifier = identifier;

            if (!ValidCategory())
            {
                Debug.LogError("Invalid identification category");
            }

            if (!ValidType())
            {
                Debug.LogError("Invalid identification type");
            }
        }

        public bool GetDescription(out string description)
        {
            if (!ValidCategory() || !ValidType() || string.IsNullOrEmpty(identifier))
            {
                description = string.Empty;
                return false;
            }
            
            description = CategoryToString() + "." + TypeToString() + "." + identifier;
            
            return true;
        }
        
        public string CategoryToString()
        {
            return CategoryToString(out string categoryString) ? categoryString : string.Empty;
        }

        public bool CategoryToString(out string toString)
        {
            switch (category)
            {
                case IdentificationCategories.Game:
                    toString = "Game";
                    return true;
                case IdentificationCategories.Dlc1:
                    toString = "DLC1";
                    return true;
                case IdentificationCategories.Dlc2:
                    toString = "DLC2";
                    return true;
                case IdentificationCategories.Dlc3:
                    toString = "DLC3";
                    return true;
                case IdentificationCategories.None:
                default:
                    break;
            }
            
            toString = "NONE";
            return false;
        }

        public string TypeToString()
        {
            return TypeToString(out string typeString) ? typeString : string.Empty;
        }

        public bool TypeToString(out string toString)
        {
            switch (type)
            {
                case IdentificationTypes.Data:
                    toString = "Data";
                    return true;
                case IdentificationTypes.Level:
                    toString = "Level";
                    return true;
                case IdentificationTypes.None:
                default:
                    break;
            }
            
            toString = "NONE";
            return false;
        }

        public bool DescriptionToIdentification(string description, out IdentificationCategories foundCategory, out IdentificationTypes foundType, out string foundIdentifier)
        {
            foundCategory = IdentificationCategories.None;
            foundType = IdentificationTypes.None;
            foundIdentifier = string.Empty;
            
            if (string.IsNullOrEmpty(description))
                return false;

            if (description.Split(' ').Length > 0)
                return false;
            
            string[] descriptionParts = description.Split('.');

            if (descriptionParts.Length != 3)
                return false;

            switch (descriptionParts[0])
            {
                case "Game":
                    foundCategory = IdentificationCategories.Game;
                    break;
                case "DLC1":
                    foundCategory = IdentificationCategories.Dlc1;
                    break;
                case "DLC2":
                    foundCategory = IdentificationCategories.Dlc2;
                    break;
                case "DLC3":
                    foundCategory = IdentificationCategories.Dlc3;
                    break;
                default:
                    return false;
            }

            switch (descriptionParts[1])
            {
                case "Data":
                    foundType = IdentificationTypes.Data;
                    break;
                case "Level":
                    foundType = IdentificationTypes.Level;
                    break;
                default:
                    return false;
            }

            if (!ValidIdentifier(descriptionParts[2]))
                return false;
            
            return true;
        }

        public bool IsValid()
        {
            return ValidCategory() && ValidType() && ValidIdentifier();
        }

        public bool ValidCategory(IdentificationCategories check)
        {
            return check != IdentificationCategories.None;
        }

        public bool ValidCategory()
        {
            return ValidCategory(category);
        }

        public bool ValidType(IdentificationTypes check)
        {
            return check != IdentificationTypes.None;
        }

        public bool ValidType()
        {
            return ValidType(type);
        }

        public bool ValidIdentifier(string check)
        {
            return !string.IsNullOrEmpty(check) && check.Split(' ').Length == 0;
        }

        public bool ValidIdentifier()
        {
            return ValidIdentifier(identifier);
        }

        public bool Equals(Identification other)
        {
            return category == other.category && type == other.type && identifier == other.identifier;
        }

        public override bool Equals(object obj)
        {
            return obj is Identification other && Equals(other);
        }

        public override int GetHashCode()
        {
            return System.HashCode.Combine((int)category, (int)type, identifier);
        }
    }
}