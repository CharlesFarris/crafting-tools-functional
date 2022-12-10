namespace SleepingBearSystems.CraftingTools.Domain

open System

type ItemId = ItemId of Guid

type ItemName = ItemName of string

type Item = {
    Id: ItemId
    Name: ItemName
    GameId: GameId
}

