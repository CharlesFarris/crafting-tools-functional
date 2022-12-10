namespace SleepingBearSystems.CraftingTools.Domain

open System

type ProfessionId = ProfessionId of Guid

type ProfessionName = ProfessionName of string

type Profession = {
    Id: ProfessionId
    Name: ProfessionId
    GameId: GameId
}

