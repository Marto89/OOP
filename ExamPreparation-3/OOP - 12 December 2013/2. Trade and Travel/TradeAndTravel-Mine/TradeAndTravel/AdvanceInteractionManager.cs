using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class AdvanceInteractionManager : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default:
                    item = base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
                    break;
            }
            return item;
        }
        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "mine":
                    location = new Mine(locationName);
                    break;
                case "forest":
                    location = new Forest(locationName);
                    break;
                default:
                    location = base.CreateLocation(locationTypeString, locationName);
                    break;
            }
            return location;
        }
        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    HandleGatherInteraction(commandWords[2], actor);
                    break;
                case "craft":
                    HandleCraftInteraction(commandWords[3], commandWords[2], actor);
                    break;
                default: base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }
        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;
            switch (personTypeString)
            {
                case "merchant":
                    person = new Merchant(personNameString, personLocation);
                    break;
                default:
                    person = base.CreatePerson(personTypeString, personNameString, personLocation);
                    break;
            }
            return person;
        }
        private void HandleCraftInteraction(string commandWords3, string commandWords2, Person actor)
        {
            var items = actor.ListInventory();
            switch (commandWords2)
            {
                case "weapon":
                    var existIronAndWood = items.Any((wood) => wood.ItemType == ItemType.Wood) && items.Any((iron)=>iron.ItemType == ItemType.Iron);
                    if (existIronAndWood)
                    {
                        var weapon = new Weapon(commandWords3);
                        this.AddToPerson(actor, weapon);
                    }
                    break;
                case "armor":
                    var existIron = items.Any((wI) => wI.ItemType == ItemType.Iron);
                    if (existIron)
                    {
                        var armor = new Armor(commandWords3);
                        this.AddToPerson(actor, armor);
                    }
                    break;
            }
        }
        private void HandleGatherInteraction(string itemNameString, Person actor)
        {
            var gatherLoc = actor.Location as IGatheringLocation;
            if (gatherLoc != null && actor.ListInventory().Any(item => item.ItemType == gatherLoc.RequiredItem))
            {
                this.AddToPerson(actor, gatherLoc.ProduceItem(itemNameString));
            }
        }
    }
}
