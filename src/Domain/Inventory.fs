namespace SleepingBearSystems.CraftingTools.Domain

open System

/// <summary>
/// Domain object representing an inventory of items.
/// </summary>
type Inventory = {
    GameId: GameId
    Slots: InventorySlot list
}

module Inventory =
    /// <summary>
    /// Clears an inventory.
    /// </summary>
    /// <param name="inventory">The inventory instance.</param>
    let clear (inventory: Inventory) : Inventory =
        { inventory with Slots = [] }

    /// <summary>
    /// Removes all of an item from an inventory.
    /// </summary>
    let remove (item: Item) (inventory: Inventory) =
        if item.GameId <> inventory.GameId then
            invalidOp "Game IDs do not match."
        else
            { inventory with Slots = inventory.Slots |> List.filter (fun i -> i.ItemId <> item.Id) }

    /// <summary>
    /// Checks if a item exists in an inventory.
    /// </summary>
    let has (item: Item) (inventory: Inventory) =
        if item.GameId <> inventory.GameId then
            invalidOp "Game IDs do not match."
        else
            (inventory.Slots |> List.exists (fun i-> i.ItemId = item.Id))
