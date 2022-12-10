namespace SleepingBearSystems.CraftingTools.Domain

open System

type GameId = GameId of Guid

type GameName = GameName of string

type Game = {
    Id: GameId
    Name: GameName
}
